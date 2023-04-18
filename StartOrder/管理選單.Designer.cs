namespace StartOrder
{
    partial class 管理選單
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
            this.btnOrderData = new System.Windows.Forms.Button();
            this.btnProductData = new System.Windows.Forms.Button();
            this.btnPersonsData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrderData
            // 
            this.btnOrderData.BackColor = System.Drawing.SystemColors.Control;
            this.btnOrderData.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrderData.Location = new System.Drawing.Point(40, 208);
            this.btnOrderData.Name = "btnOrderData";
            this.btnOrderData.Size = new System.Drawing.Size(192, 47);
            this.btnOrderData.TabIndex = 5;
            this.btnOrderData.Text = "訂單管理";
            this.btnOrderData.UseVisualStyleBackColor = false;
            this.btnOrderData.Click += new System.EventHandler(this.btnOrderData_Click);
            // 
            // btnProductData
            // 
            this.btnProductData.BackColor = System.Drawing.SystemColors.Control;
            this.btnProductData.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnProductData.Location = new System.Drawing.Point(40, 120);
            this.btnProductData.Name = "btnProductData";
            this.btnProductData.Size = new System.Drawing.Size(192, 47);
            this.btnProductData.TabIndex = 4;
            this.btnProductData.Text = "商品管理";
            this.btnProductData.UseVisualStyleBackColor = false;
            this.btnProductData.Click += new System.EventHandler(this.btnProductData_Click);
            // 
            // btnPersonsData
            // 
            this.btnPersonsData.BackColor = System.Drawing.SystemColors.Control;
            this.btnPersonsData.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPersonsData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPersonsData.Location = new System.Drawing.Point(40, 35);
            this.btnPersonsData.Name = "btnPersonsData";
            this.btnPersonsData.Size = new System.Drawing.Size(192, 47);
            this.btnPersonsData.TabIndex = 3;
            this.btnPersonsData.Text = "會員資料管理";
            this.btnPersonsData.UseVisualStyleBackColor = false;
            this.btnPersonsData.Click += new System.EventHandler(this.btnPersonsData_Click);
            // 
            // 管理選單
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(267, 287);
            this.Controls.Add(this.btnOrderData);
            this.Controls.Add(this.btnProductData);
            this.Controls.Add(this.btnPersonsData);
            this.Name = "管理選單";
            this.Text = "管理選單";
            this.Load += new System.EventHandler(this.管理選單_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrderData;
        private System.Windows.Forms.Button btnProductData;
        private System.Windows.Forms.Button btnPersonsData;
    }
}