using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayAndGetState.Objects;
using PayAndGetState.Payture;
using PayAndGetState.Payture.Requests;

namespace PayAndGetState
{
    public partial class MainForm: Form
    {
        private readonly BindingList<Order> _orders;
        private readonly PaytureApiClient _paytureApiClient;

        public MainForm(PaytureApiClient paytureApiClient)
        {
            InitializeComponent();

            _paytureApiClient = paytureApiClient;
            _orders = new BindingList<Order>();

            gv.DataSource = _orders;
            InitPayParams();
        }

        private async void BtnPayOnClick(object sender, System.EventArgs e)
        {
            try
            {
                var payRequest = new PayRequest(
                    orderId: Guid.Parse(txtOrderIdPay.Text),
                    key: "Merchant",
                    amount: int.Parse(txtAmount.Text),
                    pan: "5218851946955484",
                    eMonth: 12,
                    eYear: 23,
                    cardHolder: "Ivan Ivanov",
                    secureCode: "123",
                    ip: "91.20.143.163",
                    product: "Ticket"
                );

                var response = await _paytureApiClient.SendPaymentRequestAsync(payRequest);
                if (response.Success)
                {
                    var order = new Order(response.OrderId, response.Key, response.Amount);
                    _orders.Add(order);
                }

                InitPayParams();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private async void BtnGetStateOnClick(object sender, EventArgs e)
        {
            try
            {
                if (gv.CurrentRow is null)
                {
                    MessageBox.Show("Please select an order.");
                    return;
                }

                var selectedOrder = gv.CurrentRow.DataBoundItem as Order;
                if (selectedOrder == null)
                {
                    MessageBox.Show("Please select an order.");
                    return;
                }

                await SetOrderState(selectedOrder);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void GvSelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (gv.CurrentRow is null)
                {
                    MessageBox.Show("Please select an order.");
                    return;
                }

                var selectedOrder = gv.CurrentRow.DataBoundItem as Order;
                if (selectedOrder is null)
                {
                    return;
                }

                txtOrderIdGetState.Text = selectedOrder.OrderId.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private async void TimerOnTick(object sender, EventArgs e)
        {
            try
            {
                foreach (var order in _orders)
                {
                    await SetOrderState(order);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void InitPayParams()
        {
            txtOrderIdPay.Text = Guid.NewGuid().ToString();
            txtAmount.Text = new Random().Next(12000, 14000).ToString();
        }

        private async Task SetOrderState(Order order)
        {
            var getStateRequest = new GetStateRequest(order.Key, order.OrderId);
            var response = await _paytureApiClient.GetPaymentStateAsync(getStateRequest);
            if (response.Success)
            {
                order.SetState(response.State);
                gv.Refresh();
            }
        }
    }
}
