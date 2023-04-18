namespace StartOrder
{
    partial class 訂購系統
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.listViewShowPd = new System.Windows.Forms.ListView();
            this.txtHowMany = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAllPrice = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckMisoSoup = new System.Windows.Forms.CheckBox();
            this.ckQbSoup = new System.Windows.Forms.CheckBox();
            this.ckVagSoup = new System.Windows.Forms.CheckBox();
            this.ckVag = new System.Windows.Forms.CheckBox();
            this.cbxDrink = new System.Windows.Forms.ComboBox();
            this.cbxMent = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList產品圖檔 = new System.Windows.Forms.ImageList(this.components);
            this.btnSelect = new System.Windows.Forms.Button();
            this.ckBag = new System.Windows.Forms.CheckBox();
            this.ckBox = new System.Windows.Forms.CheckBox();
            this.lblPersonsName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPersonsPhone = new System.Windows.Forms.Label();
            this.lblOrdersName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvData.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(6, 32);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(554, 302);
            this.dgvData.TabIndex = 82;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // listViewShowPd
            // 
            this.listViewShowPd.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewShowPd.BackColor = System.Drawing.Color.BurlyWood;
            this.listViewShowPd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewShowPd.HideSelection = false;
            this.listViewShowPd.Location = new System.Drawing.Point(6, 32);
            this.listViewShowPd.Name = "listViewShowPd";
            this.listViewShowPd.Size = new System.Drawing.Size(355, 563);
            this.listViewShowPd.TabIndex = 81;
            this.listViewShowPd.UseCompatibleStateImageBehavior = false;
            this.listViewShowPd.ItemActivate += new System.EventHandler(this.listViewShowPd_ItemActivate);
            // 
            // txtHowMany
            // 
            this.txtHowMany.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtHowMany.Location = new System.Drawing.Point(375, 430);
            this.txtHowMany.Name = "txtHowMany";
            this.txtHowMany.Size = new System.Drawing.Size(100, 33);
            this.txtHowMany.TabIndex = 79;
            this.txtHowMany.TextChanged += new System.EventHandler(this.txtHowMany_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lblPrice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPrice.Location = new System.Drawing.Point(380, 395);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(84, 24);
            this.lblPrice.TabIndex = 78;
            this.lblPrice.Text = "00000元";
            // 
            // lblAllPrice
            // 
            this.lblAllPrice.AutoSize = true;
            this.lblAllPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lblAllPrice.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAllPrice.Location = new System.Drawing.Point(701, 482);
            this.lblAllPrice.Name = "lblAllPrice";
            this.lblAllPrice.Size = new System.Drawing.Size(77, 26);
            this.lblAllPrice.TabIndex = 77;
            this.lblAllPrice.Text = "00000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(579, 480);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 31);
            this.label10.TabIndex = 76;
            this.label10.Text = "品項總價:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(312, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 31);
            this.label9.TabIndex = 75;
            this.label9.Text = "單價:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckMisoSoup);
            this.groupBox1.Controls.Add(this.ckQbSoup);
            this.groupBox1.Controls.Add(this.ckVagSoup);
            this.groupBox1.Controls.Add(this.ckVag);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(24, 432);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 184);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "加購(單點專區)";
            // 
            // ckMisoSoup
            // 
            this.ckMisoSoup.AutoSize = true;
            this.ckMisoSoup.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ckMisoSoup.Location = new System.Drawing.Point(9, 150);
            this.ckMisoSoup.Name = "ckMisoSoup";
            this.ckMisoSoup.Size = new System.Drawing.Size(132, 28);
            this.ckMisoSoup.TabIndex = 3;
            this.ckMisoSoup.Text = "味噌湯 45元";
            this.ckMisoSoup.UseVisualStyleBackColor = true;
            this.ckMisoSoup.CheckedChanged += new System.EventHandler(this.ckMisoSoup_CheckedChanged);
            // 
            // ckQbSoup
            // 
            this.ckQbSoup.AutoSize = true;
            this.ckQbSoup.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ckQbSoup.Location = new System.Drawing.Point(9, 116);
            this.ckQbSoup.Name = "ckQbSoup";
            this.ckQbSoup.Size = new System.Drawing.Size(132, 28);
            this.ckQbSoup.TabIndex = 2;
            this.ckQbSoup.Text = "昆布湯 50元";
            this.ckQbSoup.UseVisualStyleBackColor = true;
            this.ckQbSoup.CheckedChanged += new System.EventHandler(this.ckQbSoup_CheckedChanged);
            // 
            // ckVagSoup
            // 
            this.ckVagSoup.AutoSize = true;
            this.ckVagSoup.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ckVagSoup.Location = new System.Drawing.Point(9, 82);
            this.ckVagSoup.Name = "ckVagSoup";
            this.ckVagSoup.Size = new System.Drawing.Size(132, 28);
            this.ckVagSoup.TabIndex = 1;
            this.ckVagSoup.Text = "蔬菜湯 40元";
            this.ckVagSoup.UseVisualStyleBackColor = true;
            this.ckVagSoup.CheckedChanged += new System.EventHandler(this.ckVagSoup_CheckedChanged);
            // 
            // ckVag
            // 
            this.ckVag.AutoSize = true;
            this.ckVag.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ckVag.Location = new System.Drawing.Point(9, 48);
            this.ckVag.Name = "ckVag";
            this.ckVag.Size = new System.Drawing.Size(170, 28);
            this.ckVag.TabIndex = 0;
            this.ckVag.Text = "綜合蔬菜盤 90元";
            this.ckVag.UseVisualStyleBackColor = true;
            this.ckVag.CheckedChanged += new System.EventHandler(this.ckVag_CheckedChanged);
            // 
            // cbxDrink
            // 
            this.cbxDrink.BackColor = System.Drawing.SystemColors.Window;
            this.cbxDrink.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxDrink.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxDrink.FormattingEnabled = true;
            this.cbxDrink.Location = new System.Drawing.Point(12, 180);
            this.cbxDrink.Name = "cbxDrink";
            this.cbxDrink.Size = new System.Drawing.Size(143, 34);
            this.cbxDrink.TabIndex = 72;
            // 
            // cbxMent
            // 
            this.cbxMent.BackColor = System.Drawing.SystemColors.Window;
            this.cbxMent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxMent.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxMent.FormattingEnabled = true;
            this.cbxMent.Location = new System.Drawing.Point(13, 77);
            this.cbxMent.Name = "cbxMent";
            this.cbxMent.Size = new System.Drawing.Size(143, 34);
            this.cbxMent.TabIndex = 71;
            this.cbxMent.SelectedIndexChanged += new System.EventHandler(this.cbxMent_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(312, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 31);
            this.label8.TabIndex = 68;
            this.label8.Text = "數量:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 31);
            this.label5.TabIndex = 66;
            this.label5.Text = "加肉";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(6, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 31);
            this.label7.TabIndex = 65;
            this.label7.Text = "附餐飲料(免費)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 31);
            this.label2.TabIndex = 63;
            this.label2.Text = "選擇的主餐 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 31);
            this.label1.TabIndex = 62;
            this.label1.Text = "歡迎會員 :";
            // 
            // imageList產品圖檔
            // 
            this.imageList產品圖檔.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList產品圖檔.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList產品圖檔.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.Control;
            this.btnSelect.Location = new System.Drawing.Point(631, 548);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(166, 59);
            this.btnSelect.TabIndex = 83;
            this.btnSelect.Text = "確認訂購";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // ckBag
            // 
            this.ckBag.AutoSize = true;
            this.ckBag.Font = new System.Drawing.Font("微軟正黑體", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ckBag.Location = new System.Drawing.Point(230, 512);
            this.ckBag.Name = "ckBag";
            this.ckBag.Size = new System.Drawing.Size(133, 30);
            this.ckBag.TabIndex = 85;
            this.ckBag.Text = "購物袋 2元";
            this.ckBag.UseVisualStyleBackColor = true;
            this.ckBag.CheckedChanged += new System.EventHandler(this.ckBag_CheckedChanged);
            // 
            // ckBox
            // 
            this.ckBox.AutoSize = true;
            this.ckBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ckBox.Location = new System.Drawing.Point(230, 548);
            this.ckBox.Name = "ckBox";
            this.ckBox.Size = new System.Drawing.Size(163, 30);
            this.ckBox.TabIndex = 86;
            this.ckBox.Text = "自備餐盒 -5元";
            this.ckBox.UseVisualStyleBackColor = true;
            this.ckBox.CheckedChanged += new System.EventHandler(this.ckBox_CheckedChanged);
            // 
            // lblPersonsName
            // 
            this.lblPersonsName.AutoSize = true;
            this.lblPersonsName.Font = new System.Drawing.Font("新細明體", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPersonsName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPersonsName.Location = new System.Drawing.Point(130, 11);
            this.lblPersonsName.Name = "lblPersonsName";
            this.lblPersonsName.Size = new System.Drawing.Size(152, 27);
            this.lblPersonsName.TabIndex = 87;
            this.lblPersonsName.Text = "訂購人姓名";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 31);
            this.label6.TabIndex = 88;
            this.label6.Text = "手機 :";
            // 
            // lblPersonsPhone
            // 
            this.lblPersonsPhone.AutoSize = true;
            this.lblPersonsPhone.Font = new System.Drawing.Font("新細明體", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPersonsPhone.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPersonsPhone.Location = new System.Drawing.Point(130, 60);
            this.lblPersonsPhone.Name = "lblPersonsPhone";
            this.lblPersonsPhone.Size = new System.Drawing.Size(152, 27);
            this.lblPersonsPhone.TabIndex = 89;
            this.lblPersonsPhone.Text = "訂購人手機";
            // 
            // lblOrdersName
            // 
            this.lblOrdersName.AutoSize = true;
            this.lblOrdersName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrdersName.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOrdersName.ForeColor = System.Drawing.Color.Red;
            this.lblOrdersName.Location = new System.Drawing.Point(78, 157);
            this.lblOrdersName.Name = "lblOrdersName";
            this.lblOrdersName.Size = new System.Drawing.Size(135, 31);
            this.lblOrdersName.TabIndex = 90;
            this.lblOrdersName.Text = "主餐名稱";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbxMent);
            this.groupBox2.Controls.Add(this.cbxDrink);
            this.groupBox2.Location = new System.Drawing.Point(24, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 232);
            this.groupBox2.TabIndex = 91;
            this.groupBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(481, 432);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 31);
            this.label12.TabIndex = 80;
            this.label12.Text = "份";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(784, 480);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 31);
            this.label11.TabIndex = 92;
            this.label11.Text = "元";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(803, 581);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(75, 26);
            this.lblState.TabIndex = 93;
            this.lblState.Text = "製做中";
            this.lblState.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvData);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(312, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(566, 351);
            this.groupBox3.TabIndex = 94;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "菜單Ｍｅｎｕ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listViewShowPd);
            this.groupBox4.Location = new System.Drawing.Point(909, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(367, 606);
            this.groupBox4.TabIndex = 95;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "餐點詳細營養值(請點擊圖片)";
            // 
            // 訂購系統
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1299, 630);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblOrdersName);
            this.Controls.Add(this.lblPersonsPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPersonsName);
            this.Controls.Add(this.ckBox);
            this.Controls.Add(this.ckBag);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtHowMany);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblAllPrice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "訂購系統";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.ListView listViewShowPd;
        private System.Windows.Forms.TextBox txtHowMany;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblAllPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckMisoSoup;
        private System.Windows.Forms.CheckBox ckQbSoup;
        private System.Windows.Forms.CheckBox ckVagSoup;
        private System.Windows.Forms.CheckBox ckVag;
        private System.Windows.Forms.ComboBox cbxDrink;
        private System.Windows.Forms.ComboBox cbxMent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList產品圖檔;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.CheckBox ckBag;
        private System.Windows.Forms.CheckBox ckBox;
        private System.Windows.Forms.Label lblPersonsName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPersonsPhone;
        private System.Windows.Forms.Label lblOrdersName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}