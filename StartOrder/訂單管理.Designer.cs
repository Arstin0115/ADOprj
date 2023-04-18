namespace StartOrder
{
    partial class 訂單管理
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
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.dgvOrderData = new System.Windows.Forms.DataGridView();
            this.btnDelAllclu = new System.Windows.Forms.Button();
            this.btnDelOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ckCancel = new System.Windows.Forms.CheckBox();
            this.ckOK = new System.Windows.Forms.CheckBox();
            this.lblTurnover = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateOrder.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdateOrder.Location = new System.Drawing.Point(653, 513);
            this.btnUpdateOrder.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(151, 54);
            this.btnUpdateOrder.TabIndex = 105;
            this.btnUpdateOrder.Text = "修改訂單狀態";
            this.btnUpdateOrder.UseVisualStyleBackColor = false;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // dgvOrderData
            // 
            this.dgvOrderData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOrderData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvOrderData.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvOrderData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrderData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderData.Location = new System.Drawing.Point(8, 31);
            this.dgvOrderData.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dgvOrderData.Name = "dgvOrderData";
            this.dgvOrderData.RowTemplate.Height = 24;
            this.dgvOrderData.Size = new System.Drawing.Size(991, 381);
            this.dgvOrderData.TabIndex = 104;
            this.dgvOrderData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderData_CellClick);
            // 
            // btnDelAllclu
            // 
            this.btnDelAllclu.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelAllclu.Location = new System.Drawing.Point(149, 513);
            this.btnDelAllclu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelAllclu.Name = "btnDelAllclu";
            this.btnDelAllclu.Size = new System.Drawing.Size(153, 55);
            this.btnDelAllclu.TabIndex = 117;
            this.btnDelAllclu.Text = "今日收入總額";
            this.btnDelAllclu.UseVisualStyleBackColor = true;
            this.btnDelAllclu.Click += new System.EventHandler(this.btnDelAllclu_Click);
            // 
            // btnDelOrder
            // 
            this.btnDelOrder.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelOrder.Location = new System.Drawing.Point(404, 513);
            this.btnDelOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelOrder.Name = "btnDelOrder";
            this.btnDelOrder.Size = new System.Drawing.Size(151, 54);
            this.btnDelOrder.TabIndex = 116;
            this.btnDelOrder.Text = "刪除訂單";
            this.btnDelOrder.UseVisualStyleBackColor = true;
            this.btnDelOrder.Click += new System.EventHandler(this.btnDelOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(18, 452);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 120;
            this.label1.Text = "訂單編號 : ";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblID.Font = new System.Drawing.Font("新細明體", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblID.ForeColor = System.Drawing.SystemColors.Window;
            this.lblID.Location = new System.Drawing.Point(145, 452);
            this.lblID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 24);
            this.lblID.TabIndex = 121;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("新細明體", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblName.Location = new System.Drawing.Point(400, 452);
            this.lblName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 24);
            this.lblName.TabIndex = 123;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(296, 452);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 122;
            this.label5.Text = "訂購人 : ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("新細明體", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPrice.Location = new System.Drawing.Point(615, 452);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 24);
            this.lblPrice.TabIndex = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(535, 452);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 24);
            this.label7.TabIndex = 124;
            this.label7.Text = "總價 : ";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("新細明體", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblState.ForeColor = System.Drawing.SystemColors.Window;
            this.lblState.Location = new System.Drawing.Point(880, 452);
            this.lblState.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(0, 24);
            this.lblState.TabIndex = 127;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(751, 452);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 24);
            this.label9.TabIndex = 126;
            this.label9.Text = "訂單狀態 : ";
            // 
            // ckCancel
            // 
            this.ckCancel.AutoSize = true;
            this.ckCancel.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ckCancel.ForeColor = System.Drawing.Color.Red;
            this.ckCancel.Location = new System.Drawing.Point(884, 529);
            this.ckCancel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ckCancel.Name = "ckCancel";
            this.ckCancel.Size = new System.Drawing.Size(117, 25);
            this.ckCancel.TabIndex = 128;
            this.ckCancel.Text = "取消訂單";
            this.ckCancel.UseVisualStyleBackColor = true;
            this.ckCancel.CheckedChanged += new System.EventHandler(this.ckCancel_CheckedChanged);
            // 
            // ckOK
            // 
            this.ckOK.AutoSize = true;
            this.ckOK.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ckOK.ForeColor = System.Drawing.Color.Blue;
            this.ckOK.Location = new System.Drawing.Point(884, 564);
            this.ckOK.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ckOK.Name = "ckOK";
            this.ckOK.Size = new System.Drawing.Size(117, 25);
            this.ckOK.TabIndex = 129;
            this.ckOK.Text = "餐點完成";
            this.ckOK.UseVisualStyleBackColor = true;
            this.ckOK.CheckedChanged += new System.EventHandler(this.ckOK_CheckedChanged);
            // 
            // lblTurnover
            // 
            this.lblTurnover.AutoSize = true;
            this.lblTurnover.Font = new System.Drawing.Font("新細明體", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTurnover.ForeColor = System.Drawing.Color.Yellow;
            this.lblTurnover.Location = new System.Drawing.Point(285, 583);
            this.lblTurnover.Name = "lblTurnover";
            this.lblTurnover.Size = new System.Drawing.Size(69, 19);
            this.lblTurnover.TabIndex = 130;
            this.lblTurnover.Text = "000000";
            this.lblTurnover.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 583);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 131;
            this.label2.Text = "今日營業額 : ";
            this.label2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 583);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 19);
            this.label4.TabIndex = 132;
            this.label4.Text = "元";
            this.label4.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvOrderData);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1008, 420);
            this.groupBox1.TabIndex = 133;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "訂單資料";
            // 
            // 訂單管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1031, 611);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTurnover);
            this.Controls.Add(this.ckOK);
            this.Controls.Add(this.ckCancel);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelAllclu);
            this.Controls.Add(this.btnDelOrder);
            this.Controls.Add(this.btnUpdateOrder);
            this.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "訂單管理";
            this.Text = "訂單管理";
            this.Load += new System.EventHandler(this.訂單管理_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.DataGridView dgvOrderData;
        private System.Windows.Forms.Button btnDelAllclu;
        private System.Windows.Forms.Button btnDelOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox ckCancel;
        private System.Windows.Forms.CheckBox ckOK;
        private System.Windows.Forms.Label lblTurnover;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}