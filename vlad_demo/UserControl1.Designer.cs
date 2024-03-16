namespace vlad_demo
{
    partial class UserControl1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            pictureOfProduct = new PictureBox();
            labelProductType = new Label();
            labelProductArtc = new Label();
            labelProductName = new Label();
            labelProductLine = new Label();
            labelProductCost = new Label();
            labelProductMaterials = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureOfProduct).BeginInit();
            SuspendLayout();
            // 
            // pictureOfProduct
            // 
            pictureOfProduct.Location = new Point(13, 35);
            pictureOfProduct.Name = "pictureOfProduct";
            pictureOfProduct.Size = new Size(134, 108);
            pictureOfProduct.TabIndex = 0;
            pictureOfProduct.TabStop = false;
            // 
            // labelProductType
            // 
            labelProductType.AutoSize = true;
            labelProductType.Location = new Point(188, 41);
            labelProductType.Name = "labelProductType";
            labelProductType.Size = new Size(102, 20);
            labelProductType.TabIndex = 1;
            labelProductType.Text = "Тип продукта";
            // 
            // labelProductArtc
            // 
            labelProductArtc.AutoSize = true;
            labelProductArtc.Location = new Point(188, 77);
            labelProductArtc.Name = "labelProductArtc";
            labelProductArtc.Size = new Size(65, 20);
            labelProductArtc.TabIndex = 2;
            labelProductArtc.Text = "Артикул";
            labelProductArtc.Click += label2_Click;
            // 
            // labelProductName
            // 
            labelProductName.AutoSize = true;
            labelProductName.Location = new Point(305, 41);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(183, 20);
            labelProductName.TabIndex = 3;
            labelProductName.Text = "Наименование продукта";
            // 
            // labelProductLine
            // 
            labelProductLine.AutoSize = true;
            labelProductLine.Location = new Point(286, 41);
            labelProductLine.Name = "labelProductLine";
            labelProductLine.Size = new Size(13, 20);
            labelProductLine.TabIndex = 4;
            labelProductLine.Text = "|";
            // 
            // labelProductCost
            // 
            labelProductCost.AutoSize = true;
            labelProductCost.Location = new Point(612, 35);
            labelProductCost.Name = "labelProductCost";
            labelProductCost.Size = new Size(83, 20);
            labelProductCost.TabIndex = 6;
            labelProductCost.Text = "Стоимость";
            // 
            // labelProductMaterials
            // 
            labelProductMaterials.AutoSize = true;
            labelProductMaterials.Location = new Point(188, 107);
            labelProductMaterials.Name = "labelProductMaterials";
            labelProductMaterials.Size = new Size(96, 20);
            labelProductMaterials.TabIndex = 7;
            labelProductMaterials.Text = "Материалы: ";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelProductMaterials);
            Controls.Add(labelProductCost);
            Controls.Add(labelProductLine);
            Controls.Add(labelProductName);
            Controls.Add(labelProductArtc);
            Controls.Add(labelProductType);
            Controls.Add(pictureOfProduct);
            Name = "UserControl1";
            Size = new Size(718, 188);
            Load += UserControl1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureOfProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label labelProductArtc;
        public Label labelProductType;
        public Label labelProductName;
        public Label labelProductLine;
        public Label labelProductCost;
        public Label labelProductMaterials;
        public PictureBox pictureOfProduct;
    }
}
