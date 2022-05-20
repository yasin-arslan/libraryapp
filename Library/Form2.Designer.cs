
namespace Library
{
    partial class Form2
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
            this.bookData = new System.Windows.Forms.DataGridView();
            this.showInfos = new MetroFramework.Controls.MetroButton();
            this.bookIdText = new System.Windows.Forms.TextBox();
            this.authorText = new System.Windows.Forms.TextBox();
            this.priceText = new System.Windows.Forms.TextBox();
            this.borrowerText = new System.Windows.Forms.TextBox();
            this.bookTitleText = new System.Windows.Forms.TextBox();
            this.borrowDateText = new System.Windows.Forms.TextBox();
            this.dateDueText = new System.Windows.Forms.TextBox();
            this.dateReturnedText = new System.Windows.Forms.TextBox();
            this.overDueText = new System.Windows.Forms.TextBox();
            this.returnFineText = new System.Windows.Forms.TextBox();
            this.addBookBtn = new MetroFramework.Controls.MetroButton();
            this.removeBtn = new MetroFramework.Controls.MetroButton();
            this.refreshBtn = new MetroFramework.Controls.MetroButton();
            this.borrowBookBtn = new MetroFramework.Controls.MetroButton();
            this.dOverDueLabel = new System.Windows.Forms.Label();
            this.labelBookID = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelBorrower = new System.Windows.Forms.Label();
            this.labelBorrowDate = new System.Windows.Forms.Label();
            this.labelDateDue = new System.Windows.Forms.Label();
            this.labelReturnDate = new System.Windows.Forms.Label();
            this.labelDueFine = new System.Windows.Forms.Label();
            this.logOut = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.bookData)).BeginInit();
            this.logOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookData
            // 
            this.bookData.AllowUserToAddRows = false;
            this.bookData.AllowUserToDeleteRows = false;
            this.bookData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookData.Location = new System.Drawing.Point(7, 202);
            this.bookData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookData.MultiSelect = false;
            this.bookData.Name = "bookData";
            this.bookData.ReadOnly = true;
            this.bookData.RowHeadersWidth = 51;
            this.bookData.RowTemplate.Height = 29;
            this.bookData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookData.Size = new System.Drawing.Size(455, 279);
            this.bookData.TabIndex = 0;
            // 
            // showInfos
            // 
            this.showInfos.Location = new System.Drawing.Point(137, 176);
            this.showInfos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showInfos.Name = "showInfos";
            this.showInfos.Size = new System.Drawing.Size(83, 22);
            this.showInfos.TabIndex = 1;
            this.showInfos.Text = "Bilgileri Göster";
            this.showInfos.UseSelectable = true;
            this.showInfos.Click += new System.EventHandler(this.showInfos_Click);
            // 
            // bookIdText
            // 
            this.bookIdText.Location = new System.Drawing.Point(71, 81);
            this.bookIdText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookIdText.Name = "bookIdText";
            this.bookIdText.ReadOnly = true;
            this.bookIdText.Size = new System.Drawing.Size(118, 23);
            this.bookIdText.TabIndex = 14;
            // 
            // authorText
            // 
            this.authorText.Location = new System.Drawing.Point(71, 48);
            this.authorText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.authorText.Name = "authorText";
            this.authorText.ReadOnly = true;
            this.authorText.Size = new System.Drawing.Size(134, 23);
            this.authorText.TabIndex = 15;
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(71, 110);
            this.priceText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceText.Name = "priceText";
            this.priceText.ReadOnly = true;
            this.priceText.Size = new System.Drawing.Size(142, 23);
            this.priceText.TabIndex = 16;
            // 
            // borrowerText
            // 
            this.borrowerText.Location = new System.Drawing.Point(86, 140);
            this.borrowerText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.borrowerText.Name = "borrowerText";
            this.borrowerText.ReadOnly = true;
            this.borrowerText.Size = new System.Drawing.Size(155, 23);
            this.borrowerText.TabIndex = 17;
            // 
            // bookTitleText
            // 
            this.bookTitleText.Location = new System.Drawing.Point(71, 21);
            this.bookTitleText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookTitleText.Name = "bookTitleText";
            this.bookTitleText.ReadOnly = true;
            this.bookTitleText.Size = new System.Drawing.Size(134, 23);
            this.bookTitleText.TabIndex = 18;
            // 
            // borrowDateText
            // 
            this.borrowDateText.Location = new System.Drawing.Point(323, 24);
            this.borrowDateText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.borrowDateText.Name = "borrowDateText";
            this.borrowDateText.ReadOnly = true;
            this.borrowDateText.Size = new System.Drawing.Size(139, 23);
            this.borrowDateText.TabIndex = 19;
            // 
            // dateDueText
            // 
            this.dateDueText.Location = new System.Drawing.Point(323, 53);
            this.dateDueText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateDueText.Name = "dateDueText";
            this.dateDueText.ReadOnly = true;
            this.dateDueText.Size = new System.Drawing.Size(139, 23);
            this.dateDueText.TabIndex = 20;
            // 
            // dateReturnedText
            // 
            this.dateReturnedText.Location = new System.Drawing.Point(323, 81);
            this.dateReturnedText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateReturnedText.Name = "dateReturnedText";
            this.dateReturnedText.ReadOnly = true;
            this.dateReturnedText.Size = new System.Drawing.Size(139, 23);
            this.dateReturnedText.TabIndex = 21;
            // 
            // overDueText
            // 
            this.overDueText.Location = new System.Drawing.Point(323, 110);
            this.overDueText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.overDueText.Name = "overDueText";
            this.overDueText.ReadOnly = true;
            this.overDueText.Size = new System.Drawing.Size(139, 23);
            this.overDueText.TabIndex = 22;
            // 
            // returnFineText
            // 
            this.returnFineText.Location = new System.Drawing.Point(323, 140);
            this.returnFineText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.returnFineText.Name = "returnFineText";
            this.returnFineText.ReadOnly = true;
            this.returnFineText.Size = new System.Drawing.Size(139, 23);
            this.returnFineText.TabIndex = 23;
            // 
            // addBookBtn
            // 
            this.addBookBtn.Location = new System.Drawing.Point(226, 176);
            this.addBookBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(82, 22);
            this.addBookBtn.TabIndex = 25;
            this.addBookBtn.Text = "Kitap Ekle";
            this.addBookBtn.UseSelectable = true;
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(314, 176);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(82, 22);
            this.removeBtn.TabIndex = 26;
            this.removeBtn.Text = "Kitabı Sil";
            this.removeBtn.UseSelectable = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(402, 176);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(60, 22);
            this.refreshBtn.TabIndex = 27;
            this.refreshBtn.Text = "Yenile";
            this.refreshBtn.UseSelectable = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // borrowBookBtn
            // 
            this.borrowBookBtn.Location = new System.Drawing.Point(7, 176);
            this.borrowBookBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.borrowBookBtn.Name = "borrowBookBtn";
            this.borrowBookBtn.Size = new System.Drawing.Size(124, 22);
            this.borrowBookBtn.TabIndex = 29;
            this.borrowBookBtn.Text = "Seçili Kitabı Ödünç Ver";
            this.borrowBookBtn.UseSelectable = true;
            this.borrowBookBtn.Click += new System.EventHandler(this.borrowBookBtn_Click);
            // 
            // dOverDueLabel
            // 
            this.dOverDueLabel.AutoSize = true;
            this.dOverDueLabel.Location = new System.Drawing.Point(219, 113);
            this.dOverDueLabel.Name = "dOverDueLabel";
            this.dOverDueLabel.Size = new System.Drawing.Size(98, 15);
            this.dOverDueLabel.TabIndex = 31;
            this.dOverDueLabel.Text = "Cezalı Saat Sayısı:";
            // 
            // labelBookID
            // 
            this.labelBookID.AutoSize = true;
            this.labelBookID.Location = new System.Drawing.Point(10, 84);
            this.labelBookID.Name = "labelBookID";
            this.labelBookID.Size = new System.Drawing.Size(51, 15);
            this.labelBookID.TabIndex = 32;
            this.labelBookID.Text = "Kitap ID:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(7, 27);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(58, 15);
            this.labelTitle.TabIndex = 33;
            this.labelTitle.Text = "Kitap Adı:";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(7, 53);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(37, 15);
            this.labelAuthor.TabIndex = 34;
            this.labelAuthor.Text = "Yazar:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(10, 113);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(35, 15);
            this.labelPrice.TabIndex = 35;
            this.labelPrice.Text = "Fiyat:";
            // 
            // labelBorrower
            // 
            this.labelBorrower.AutoSize = true;
            this.labelBorrower.Location = new System.Drawing.Point(7, 143);
            this.labelBorrower.Name = "labelBorrower";
            this.labelBorrower.Size = new System.Drawing.Size(73, 15);
            this.labelBorrower.TabIndex = 36;
            this.labelBorrower.Text = "Ödünç Alan:";
            // 
            // labelBorrowDate
            // 
            this.labelBorrowDate.AutoSize = true;
            this.labelBorrowDate.Location = new System.Drawing.Point(211, 27);
            this.labelBorrowDate.Name = "labelBorrowDate";
            this.labelBorrowDate.Size = new System.Drawing.Size(108, 15);
            this.labelBorrowDate.TabIndex = 37;
            this.labelBorrowDate.Text = "Ödünç Alma Tarihi:";
            // 
            // labelDateDue
            // 
            this.labelDateDue.AutoSize = true;
            this.labelDateDue.Location = new System.Drawing.Point(220, 56);
            this.labelDateDue.Name = "labelDateDue";
            this.labelDateDue.Size = new System.Drawing.Size(97, 15);
            this.labelDateDue.TabIndex = 38;
            this.labelDateDue.Text = "Son Teslim Tarihi:";
            // 
            // labelReturnDate
            // 
            this.labelReturnDate.AutoSize = true;
            this.labelReturnDate.Location = new System.Drawing.Point(195, 84);
            this.labelReturnDate.Name = "labelReturnDate";
            this.labelReturnDate.Size = new System.Drawing.Size(122, 15);
            this.labelReturnDate.TabIndex = 39;
            this.labelReturnDate.Text = "Kullanıcı Teslim Tarihi:";
            // 
            // labelDueFine
            // 
            this.labelDueFine.AutoSize = true;
            this.labelDueFine.Location = new System.Drawing.Point(247, 143);
            this.labelDueFine.Name = "labelDueFine";
            this.labelDueFine.Size = new System.Drawing.Size(70, 15);
            this.labelDueFine.TabIndex = 40;
            this.labelDueFine.Text = "Ceza Bedeli:";
            // 
            // logOut
            // 
            this.logOut.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem});
            this.logOut.Location = new System.Drawing.Point(0, 0);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(474, 24);
            this.logOut.TabIndex = 41;
            this.logOut.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışYapToolStripMenuItem});
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menüToolStripMenuItem.Text = "Menü";
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 490);
            this.Controls.Add(this.labelDueFine);
            this.Controls.Add(this.labelReturnDate);
            this.Controls.Add(this.labelDateDue);
            this.Controls.Add(this.labelBorrowDate);
            this.Controls.Add(this.labelBorrower);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelBookID);
            this.Controls.Add(this.dOverDueLabel);
            this.Controls.Add(this.borrowBookBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBookBtn);
            this.Controls.Add(this.returnFineText);
            this.Controls.Add(this.overDueText);
            this.Controls.Add(this.dateReturnedText);
            this.Controls.Add(this.dateDueText);
            this.Controls.Add(this.borrowDateText);
            this.Controls.Add(this.bookTitleText);
            this.Controls.Add(this.borrowerText);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.authorText);
            this.Controls.Add(this.bookIdText);
            this.Controls.Add(this.showInfos);
            this.Controls.Add(this.bookData);
            this.Controls.Add(this.logOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.logOut;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookData)).EndInit();
            this.logOut.ResumeLayout(false);
            this.logOut.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bookData;
        private MetroFramework.Controls.MetroButton showInfos;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TextBox bookIdText;
        private System.Windows.Forms.TextBox authorText;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.TextBox borrowerText;
        private System.Windows.Forms.TextBox bookTitleText;
        private System.Windows.Forms.TextBox borrowDateText;
        private System.Windows.Forms.TextBox dateDueText;
        private System.Windows.Forms.TextBox dateReturnedText;
        private System.Windows.Forms.TextBox overDueText;
        private System.Windows.Forms.TextBox returnFineText;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton addBookBtn;
        private MetroFramework.Controls.MetroButton removeBtn;
        private MetroFramework.Controls.MetroButton refreshBtn;
        private MetroFramework.Controls.MetroButton logoutBtn;
        private MetroFramework.Controls.MetroButton borrowBookBtn;
        private System.Windows.Forms.TextBox borrowSelectedText;
        private System.Windows.Forms.Label dOverDueLabel;
        private System.Windows.Forms.Label labelBookID;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelBorrower;
        private System.Windows.Forms.Label labelBorrowDate;
        private System.Windows.Forms.Label labelDateDue;
        private System.Windows.Forms.Label labelReturnDate;
        private System.Windows.Forms.Label labelDueFine;
        private System.Windows.Forms.MenuStrip logOut;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
    }
}