namespace PayAndGetState
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblOrderIdPay = new System.Windows.Forms.Label();
            this.lblOrderAmount = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.txtOrderIdPay = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblGetState = new System.Windows.Forms.Label();
            this.txtOrderIdGetState = new System.Windows.Forms.TextBox();
            this.lblOrderIdGetState = new System.Windows.Forms.Label();
            this.btnGetState = new System.Windows.Forms.Button();
            this.gv = new System.Windows.Forms.DataGridView();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrderIdPay
            // 
            this.lblOrderIdPay.AutoSize = true;
            this.lblOrderIdPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrderIdPay.Location = new System.Drawing.Point(17, 209);
            this.lblOrderIdPay.Name = "lblOrderIdPay";
            this.lblOrderIdPay.Size = new System.Drawing.Size(71, 20);
            this.lblOrderIdPay.TabIndex = 0;
            this.lblOrderIdPay.Text = "Order Id:";
            // 
            // lblOrderAmount
            // 
            this.lblOrderAmount.AutoSize = true;
            this.lblOrderAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrderAmount.Location = new System.Drawing.Point(17, 238);
            this.lblOrderAmount.Name = "lblOrderAmount";
            this.lblOrderAmount.Size = new System.Drawing.Size(69, 20);
            this.lblOrderAmount.TabIndex = 1;
            this.lblOrderAmount.Text = "Amount:";
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPay.Location = new System.Drawing.Point(17, 179);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(38, 20);
            this.lblPay.TabIndex = 2;
            this.lblPay.Text = "Pay";
            // 
            // txtOrderIdPay
            // 
            this.txtOrderIdPay.Location = new System.Drawing.Point(95, 208);
            this.txtOrderIdPay.Name = "txtOrderIdPay";
            this.txtOrderIdPay.ReadOnly = true;
            this.txtOrderIdPay.Size = new System.Drawing.Size(274, 20);
            this.txtOrderIdPay.TabIndex = 3;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(95, 240);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(274, 20);
            this.txtAmount.TabIndex = 4;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(294, 266);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 6;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.BtnPayOnClick);
            // 
            // lblGetState
            // 
            this.lblGetState.AutoSize = true;
            this.lblGetState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGetState.Location = new System.Drawing.Point(424, 175);
            this.lblGetState.Name = "lblGetState";
            this.lblGetState.Size = new System.Drawing.Size(94, 24);
            this.lblGetState.TabIndex = 7;
            this.lblGetState.Text = "Get State";
            // 
            // txtOrderIdGetState
            // 
            this.txtOrderIdGetState.Location = new System.Drawing.Point(501, 206);
            this.txtOrderIdGetState.Name = "txtOrderIdGetState";
            this.txtOrderIdGetState.ReadOnly = true;
            this.txtOrderIdGetState.Size = new System.Drawing.Size(274, 20);
            this.txtOrderIdGetState.TabIndex = 9;
            // 
            // lblOrderIdGetState
            // 
            this.lblOrderIdGetState.AutoSize = true;
            this.lblOrderIdGetState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrderIdGetState.Location = new System.Drawing.Point(424, 206);
            this.lblOrderIdGetState.Name = "lblOrderIdGetState";
            this.lblOrderIdGetState.Size = new System.Drawing.Size(71, 20);
            this.lblOrderIdGetState.TabIndex = 8;
            this.lblOrderIdGetState.Text = "Order Id:";
            // 
            // btnGetState
            // 
            this.btnGetState.Location = new System.Drawing.Point(700, 240);
            this.btnGetState.Name = "btnGetState";
            this.btnGetState.Size = new System.Drawing.Size(75, 23);
            this.btnGetState.TabIndex = 10;
            this.btnGetState.Text = "Get State";
            this.btnGetState.UseVisualStyleBackColor = true;
            this.btnGetState.Click += new System.EventHandler(this.BtnGetStateOnClick);
            // 
            // gv
            // 
            this.gv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Location = new System.Drawing.Point(12, 304);
            this.gv.Name = "gv";
            this.gv.Size = new System.Drawing.Size(788, 269);
            this.gv.TabIndex = 11;
            this.gv.SelectionChanged += new System.EventHandler(this.GvSelectionChanged);
            // 
            // lblSeparator
            // 
            this.lblSeparator.AutoSize = true;
            this.lblSeparator.Location = new System.Drawing.Point(9, 288);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(793, 13);
            this.lblSeparator.TabIndex = 12;
            this.lblSeparator.Text = resources.GetString("lblSeparator.Text");
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo.Location = new System.Drawing.Point(11, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(44, 24);
            this.lblInfo.TabIndex = 13;
            this.lblInfo.Text = "Info";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(15, 37);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(785, 124);
            this.txtInfo.TabIndex = 14;
            this.txtInfo.Text = resources.GetString("txtInfo.Text");
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 5000;
            this.timer.Tick += new System.EventHandler(this.TimerOnTick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 585);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblSeparator);
            this.Controls.Add(this.gv);
            this.Controls.Add(this.btnGetState);
            this.Controls.Add(this.txtOrderIdGetState);
            this.Controls.Add(this.lblOrderIdGetState);
            this.Controls.Add(this.lblGetState);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtOrderIdPay);
            this.Controls.Add(this.lblPay);
            this.Controls.Add(this.lblOrderAmount);
            this.Controls.Add(this.lblOrderIdPay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Плати и проверяй";
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderIdPay;
        private System.Windows.Forms.Label lblOrderAmount;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.TextBox txtOrderIdPay;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblGetState;
        private System.Windows.Forms.TextBox txtOrderIdGetState;
        private System.Windows.Forms.Label lblOrderIdGetState;
        private System.Windows.Forms.Button btnGetState;
        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Timer timer;
    }
}