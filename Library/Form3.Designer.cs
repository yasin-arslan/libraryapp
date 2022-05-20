
namespace Library
{
    partial class Form3
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
            this.titleText = new System.Windows.Forms.TextBox();
            this.authorText = new System.Windows.Forms.TextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.priceText = new System.Windows.Forms.TextBox();
            this.addBookTitle = new System.Windows.Forms.Label();
            this.addBookAuthor = new System.Windows.Forms.Label();
            this.addBookPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(92, 20);
            this.titleText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(110, 23);
            this.titleText.TabIndex = 31;
            // 
            // authorText
            // 
            this.authorText.Location = new System.Drawing.Point(92, 47);
            this.authorText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.authorText.Name = "authorText";
            this.authorText.Size = new System.Drawing.Size(110, 23);
            this.authorText.TabIndex = 32;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(12, 112);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(189, 22);
            this.metroButton1.TabIndex = 33;
            this.metroButton1.Text = "Veritabanına Ekle";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(92, 74);
            this.priceText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(110, 23);
            this.priceText.TabIndex = 35;
            // 
            // addBookTitle
            // 
            this.addBookTitle.AutoSize = true;
            this.addBookTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addBookTitle.Location = new System.Drawing.Point(12, 24);
            this.addBookTitle.Name = "addBookTitle";
            this.addBookTitle.Size = new System.Drawing.Size(71, 19);
            this.addBookTitle.TabIndex = 37;
            this.addBookTitle.Text = "Kitap Adı:";
            // 
            // addBookAuthor
            // 
            this.addBookAuthor.AutoSize = true;
            this.addBookAuthor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addBookAuthor.Location = new System.Drawing.Point(12, 51);
            this.addBookAuthor.Name = "addBookAuthor";
            this.addBookAuthor.Size = new System.Drawing.Size(46, 19);
            this.addBookAuthor.TabIndex = 38;
            this.addBookAuthor.Text = "Yazar:";
            // 
            // addBookPrice
            // 
            this.addBookPrice.AutoSize = true;
            this.addBookPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addBookPrice.Location = new System.Drawing.Point(12, 74);
            this.addBookPrice.Name = "addBookPrice";
            this.addBookPrice.Size = new System.Drawing.Size(42, 19);
            this.addBookPrice.TabIndex = 39;
            this.addBookPrice.Text = "Fiyat:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 147);
            this.Controls.Add(this.addBookPrice);
            this.Controls.Add(this.addBookAuthor);
            this.Controls.Add(this.addBookTitle);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.authorText);
            this.Controls.Add(this.titleText);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Kitap Ekleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox authorText;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.Label addBookTitle;
        private System.Windows.Forms.Label addBookAuthor;
        private System.Windows.Forms.Label addBookPrice;
    }
}