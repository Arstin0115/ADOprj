namespace StartOrder
{
    partial class 商品管理表單
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
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAddProducts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewShowPd = new System.Windows.Forms.ListView();
            this.imageList產品圖檔 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReload.Location = new System.Drawing.Point(536, 481);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(149, 57);
            this.btnReload.TabIndex = 13;
            this.btnReload.Text = "重新載入";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddProducts.Location = new System.Drawing.Point(12, 481);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(149, 57);
            this.btnAddProducts.TabIndex = 12;
            this.btnAddProducts.Text = "上架新商品";
            this.btnAddProducts.UseVisualStyleBackColor = true;
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(239, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 61);
            this.label1.TabIndex = 11;
            this.label1.Text = "所有商品";
            // 
            // listViewShowPd
            // 
            this.listViewShowPd.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewShowPd.HideSelection = false;
            this.listViewShowPd.Location = new System.Drawing.Point(12, 67);
            this.listViewShowPd.Name = "listViewShowPd";
            this.listViewShowPd.Size = new System.Drawing.Size(673, 400);
            this.listViewShowPd.TabIndex = 10;
            this.listViewShowPd.UseCompatibleStateImageBehavior = false;
            this.listViewShowPd.View = System.Windows.Forms.View.Details;
            this.listViewShowPd.ItemActivate += new System.EventHandler(this.listViewShowPd_ItemActivate);
            // 
            // imageList產品圖檔
            // 
            this.imageList產品圖檔.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList產品圖檔.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList產品圖檔.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // 商品管理表單
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 550);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnAddProducts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewShowPd);
            this.Name = "商品管理表單";
            this.Text = "商品管理表單";
            this.Load += new System.EventHandler(this.商品管理表單_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnAddProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewShowPd;
        private System.Windows.Forms.ImageList imageList產品圖檔;
    }
}