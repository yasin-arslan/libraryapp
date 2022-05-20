
namespace Library
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.userText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.studentCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.managerCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.passwordHider = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(142, 252);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(64, 27);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Giriş Yap";
            this.loginButton.UseSelectable = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 161);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(86, 20);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Kullanıcı Adı:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(67, 201);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(39, 20);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Şifre:";
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(112, 161);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(125, 27);
            this.userText.TabIndex = 3;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(112, 201);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(125, 27);
            this.passwordText.TabIndex = 4;
            // 
            // studentCheckBox
            // 
            this.studentCheckBox.AutoSize = true;
            this.studentCheckBox.Location = new System.Drawing.Point(116, 88);
            this.studentCheckBox.Name = "studentCheckBox";
            this.studentCheckBox.Size = new System.Drawing.Size(70, 17);
            this.studentCheckBox.TabIndex = 5;
            this.studentCheckBox.Text = "Öğrenci";
            this.studentCheckBox.UseSelectable = true;
            this.studentCheckBox.CheckedChanged += new System.EventHandler(this.studentCheckBox_CheckedChanged);
            // 
            // managerCheckBox
            // 
            this.managerCheckBox.AutoSize = true;
            this.managerCheckBox.Location = new System.Drawing.Point(116, 121);
            this.managerCheckBox.Name = "managerCheckBox";
            this.managerCheckBox.Size = new System.Drawing.Size(133, 17);
            this.managerCheckBox.TabIndex = 6;
            this.managerCheckBox.Text = "Öğretmen/Yönetici";
            this.managerCheckBox.UseSelectable = true;
            this.managerCheckBox.CheckedChanged += new System.EventHandler(this.managerCheckBox_CheckedChanged);
            // 
            // passwordHider
            // 
            this.passwordHider.AutoSize = true;
            this.passwordHider.Location = new System.Drawing.Point(252, 204);
            this.passwordHider.Name = "passwordHider";
            this.passwordHider.Size = new System.Drawing.Size(52, 17);
            this.passwordHider.TabIndex = 7;
            this.passwordHider.Text = "Gizle";
            this.passwordHider.UseSelectable = true;
            this.passwordHider.CheckedChanged += new System.EventHandler(this.passwordHider_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 389);
            this.Controls.Add(this.passwordHider);
            this.Controls.Add(this.managerCheckBox);
            this.Controls.Add(this.studentCheckBox);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.loginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton loginButton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.TextBox passwordText;
        private MetroFramework.Controls.MetroCheckBox studentCheckBox;
        private MetroFramework.Controls.MetroCheckBox managerCheckBox;
        private MetroFramework.Controls.MetroCheckBox passwordHider;
    }
}

