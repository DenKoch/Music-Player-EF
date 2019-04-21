namespace OOP_2_2_Music_Player_EF
{
    partial class FormAuth
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MusicPlayerLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SignInLabel = new System.Windows.Forms.Label();
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.SignInUnderline = new System.Windows.Forms.PictureBox();
            this.SignUpUnderline = new System.Windows.Forms.PictureBox();
            this.ConfirmPassTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SignInUnderline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SignUpUnderline)).BeginInit();
            this.SuspendLayout();
            // 
            // MusicPlayerLabel
            // 
            this.MusicPlayerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MusicPlayerLabel.AutoSize = true;
            this.MusicPlayerLabel.Font = new System.Drawing.Font("Montserrat", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MusicPlayerLabel.ForeColor = System.Drawing.Color.White;
            this.MusicPlayerLabel.Location = new System.Drawing.Point(159, 38);
            this.MusicPlayerLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.MusicPlayerLabel.Name = "MusicPlayerLabel";
            this.MusicPlayerLabel.Size = new System.Drawing.Size(483, 92);
            this.MusicPlayerLabel.TabIndex = 1;
            this.MusicPlayerLabel.Text = "Music Player";
            this.MusicPlayerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Montserrat Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(169)))), ((int)(((byte)(174)))));
            this.UsernameTextBox.Location = new System.Drawing.Point(287, 225);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(220, 25);
            this.UsernameTextBox.TabIndex = 2;
            this.UsernameTextBox.Text = "Username";
            this.UsernameTextBox.Enter += new System.EventHandler(this.UsernameTextBox_Enter);
            this.UsernameTextBox.Leave += new System.EventHandler(this.UsernameTextBox_Leave);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Montserrat Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(169)))), ((int)(((byte)(174)))));
            this.PasswordTextBox.Location = new System.Drawing.Point(287, 271);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(220, 25);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.Text = "Password";
            this.PasswordTextBox.Enter += new System.EventHandler(this.PasswordTextBox_Enter);
            this.PasswordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.ConfirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConfirmButton.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmButton.ForeColor = System.Drawing.Color.White;
            this.ConfirmButton.Location = new System.Drawing.Point(287, 365);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(220, 34);
            this.ConfirmButton.TabIndex = 4;
            this.ConfirmButton.Text = "SIGN IN";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // SignInLabel
            // 
            this.SignInLabel.AutoSize = true;
            this.SignInLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignInLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignInLabel.ForeColor = System.Drawing.Color.White;
            this.SignInLabel.Location = new System.Drawing.Point(308, 170);
            this.SignInLabel.Name = "SignInLabel";
            this.SignInLabel.Size = new System.Drawing.Size(72, 22);
            this.SignInLabel.TabIndex = 5;
            this.SignInLabel.Text = "SIGN IN";
            this.SignInLabel.Click += new System.EventHandler(this.SignInLabel_Click);
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.AutoSize = true;
            this.SignUpLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignUpLabel.ForeColor = System.Drawing.Color.White;
            this.SignUpLabel.Location = new System.Drawing.Point(407, 170);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(79, 22);
            this.SignUpLabel.TabIndex = 6;
            this.SignUpLabel.Text = "SIGN UP";
            this.SignUpLabel.Click += new System.EventHandler(this.SignUpLabel_Click);
            // 
            // SignInUnderline
            // 
            this.SignInUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.SignInUnderline.Location = new System.Drawing.Point(310, 197);
            this.SignInUnderline.Name = "SignInUnderline";
            this.SignInUnderline.Size = new System.Drawing.Size(67, 2);
            this.SignInUnderline.TabIndex = 7;
            this.SignInUnderline.TabStop = false;
            // 
            // SignUpUnderline
            // 
            this.SignUpUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.SignUpUnderline.Location = new System.Drawing.Point(413, 197);
            this.SignUpUnderline.Name = "SignUpUnderline";
            this.SignUpUnderline.Size = new System.Drawing.Size(67, 2);
            this.SignUpUnderline.TabIndex = 8;
            this.SignUpUnderline.TabStop = false;
            this.SignUpUnderline.Visible = false;
            // 
            // ConfirmPassTextBox
            // 
            this.ConfirmPassTextBox.Font = new System.Drawing.Font("Montserrat Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmPassTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(169)))), ((int)(((byte)(174)))));
            this.ConfirmPassTextBox.Location = new System.Drawing.Point(287, 316);
            this.ConfirmPassTextBox.Name = "ConfirmPassTextBox";
            this.ConfirmPassTextBox.Size = new System.Drawing.Size(220, 25);
            this.ConfirmPassTextBox.TabIndex = 9;
            this.ConfirmPassTextBox.Text = "Confirm password";
            this.ConfirmPassTextBox.Visible = false;
            this.ConfirmPassTextBox.Enter += new System.EventHandler(this.ConfirmPassTextBox_Enter);
            this.ConfirmPassTextBox.Leave += new System.EventHandler(this.ConfirmPassTextBox_Leave);
            // 
            // FormAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(802, 443);
            this.Controls.Add(this.ConfirmPassTextBox);
            this.Controls.Add(this.SignUpUnderline);
            this.Controls.Add(this.SignInUnderline);
            this.Controls.Add(this.SignUpLabel);
            this.Controls.Add(this.SignInLabel);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.MusicPlayerLabel);
            this.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAuth";
            this.Text = "Music Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAuth_FormClosing);
            this.Load += new System.EventHandler(this.FormAuth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SignInUnderline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SignUpUnderline)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MusicPlayerLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label SignInLabel;
        private System.Windows.Forms.Label SignUpLabel;
        private System.Windows.Forms.PictureBox SignInUnderline;
        private System.Windows.Forms.PictureBox SignUpUnderline;
        private System.Windows.Forms.TextBox ConfirmPassTextBox;
    }
}

