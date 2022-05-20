namespace Library
{
    partial class Form4
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
            this.form4BookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.borrowBookBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.form4Author = new System.Windows.Forms.TextBox();
            this.form4Price = new System.Windows.Forms.TextBox();
            this.form4Borrower = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.form4BookID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // form4BookName
            // 
            this.form4BookName.Location = new System.Drawing.Point(84, 34);
            this.form4BookName.Name = "form4BookName";
            this.form4BookName.ReadOnly = true;
            this.form4BookName.Size = new System.Drawing.Size(100, 23);
            this.form4BookName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitabın Adı:";
            // 
            // borrowBookBtn
            // 
            this.borrowBookBtn.Location = new System.Drawing.Point(244, 157);
            this.borrowBookBtn.Name = "borrowBookBtn";
            this.borrowBookBtn.Size = new System.Drawing.Size(75, 23);
            this.borrowBookBtn.TabIndex = 2;
            this.borrowBookBtn.Text = "Ödünç Ver";
            this.borrowBookBtn.UseVisualStyleBackColor = true;
            this.borrowBookBtn.Click += new System.EventHandler(this.borrowBookBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yazar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fiyat:";
            // 
            // form4Author
            // 
            this.form4Author.Location = new System.Drawing.Point(84, 61);
            this.form4Author.Name = "form4Author";
            this.form4Author.ReadOnly = true;
            this.form4Author.Size = new System.Drawing.Size(100, 23);
            this.form4Author.TabIndex = 6;
            // 
            // form4Price
            // 
            this.form4Price.Location = new System.Drawing.Point(84, 90);
            this.form4Price.Name = "form4Price";
            this.form4Price.ReadOnly = true;
            this.form4Price.Size = new System.Drawing.Size(100, 23);
            this.form4Price.TabIndex = 7;
            // 
            // form4Borrower
            // 
            this.form4Borrower.FormattingEnabled = true;
            this.form4Borrower.Location = new System.Drawing.Point(84, 119);
            this.form4Borrower.Name = "form4Borrower";
            this.form4Borrower.Size = new System.Drawing.Size(233, 23);
            this.form4Borrower.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ödünç Alan:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kitap ID:";
            // 
            // form4BookID
            // 
            this.form4BookID.Location = new System.Drawing.Point(84, 6);
            this.form4BookID.Name = "form4BookID";
            this.form4BookID.ReadOnly = true;
            this.form4BookID.Size = new System.Drawing.Size(100, 23);
            this.form4BookID.TabIndex = 11;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 187);
            this.Controls.Add(this.form4BookID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.form4Borrower);
            this.Controls.Add(this.form4Price);
            this.Controls.Add(this.form4Author);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.borrowBookBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.form4BookName);
            this.Name = "Form4";
            this.Text = "Ödünç Verme Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox form4BookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button borrowBookBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox form4Author;
        private System.Windows.Forms.TextBox form4Price;
        private System.Windows.Forms.ComboBox form4Borrower;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox form4BookID;
    }
}