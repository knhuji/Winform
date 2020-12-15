namespace QUANLYBANHANG.GUI
{
    partial class FormAddPro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbCatalog = new System.Windows.Forms.ComboBox();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.tbDetail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 625);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbCatalog);
            this.panel3.Controls.Add(this.btnChooseFile);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.tbURL);
            this.panel3.Controls.Add(this.tbAmount);
            this.panel3.Controls.Add(this.tbPrice);
            this.panel3.Controls.Add(this.btnCancle);
            this.panel3.Controls.Add(this.btnAddProduct);
            this.panel3.Controls.Add(this.tbDetail);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tbName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(12, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(579, 546);
            this.panel3.TabIndex = 1;
            // 
            // cbCatalog
            // 
            this.cbCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cbCatalog.FormattingEnabled = true;
            this.cbCatalog.Location = new System.Drawing.Point(164, 67);
            this.cbCatalog.Name = "cbCatalog";
            this.cbCatalog.Size = new System.Drawing.Size(390, 28);
            this.cbCatalog.TabIndex = 31;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChooseFile.BackColor = System.Drawing.Color.Crimson;
            this.btnChooseFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChooseFile.Location = new System.Drawing.Point(19, 401);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(127, 39);
            this.btnChooseFile.TabIndex = 29;
            this.btnChooseFile.Text = "Chọn File";
            this.btnChooseFile.UseVisualStyleBackColor = false;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 27);
            this.label8.TabIndex = 27;
            this.label8.Text = "URL:";
            // 
            // tbURL
            // 
            this.tbURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbURL.Location = new System.Drawing.Point(19, 328);
            this.tbURL.Multiline = true;
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(535, 67);
            this.tbURL.TabIndex = 26;
            // 
            // tbAmount
            // 
            this.tbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmount.Location = new System.Drawing.Point(305, 151);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(249, 27);
            this.tbAmount.TabIndex = 23;
            this.tbAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(19, 151);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(241, 27);
            this.tbPrice.TabIndex = 22;
            this.tbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCancle
            // 
            this.btnCancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancle.BackColor = System.Drawing.Color.Beige;
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Location = new System.Drawing.Point(282, 485);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(133, 48);
            this.btnCancle.TabIndex = 18;
            this.btnCancle.Text = "Hủy";
            this.btnCancle.UseVisualStyleBackColor = false;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddProduct.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddProduct.Location = new System.Drawing.Point(421, 485);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(133, 48);
            this.btnAddProduct.TabIndex = 17;
            this.btnAddProduct.Text = "Thêm";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // tbDetail
            // 
            this.tbDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDetail.Location = new System.Drawing.Point(164, 206);
            this.tbDetail.Multiline = true;
            this.tbDetail.Name = "tbDetail";
            this.tbDetail.Size = new System.Drawing.Size(390, 71);
            this.tbDetail.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 27);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mô tả: ";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(301, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 27);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số lượng: ";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Giá: ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(164, 20);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(390, 27);
            this.tbName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sản phẩm:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 62);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÊM SẢN PHẨM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAddPro
            // 
            this.AcceptButton = this.btnAddProduct;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancle;
            this.ClientSize = new System.Drawing.Size(601, 625);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "FormAddPro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm sản phẩm";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox tbDetail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.ComboBox cbCatalog;
    }
}