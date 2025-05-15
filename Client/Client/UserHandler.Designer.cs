namespace Client
{
    partial class UserHandler
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.addMoneyLabel = new System.Windows.Forms.Label();
            this.addMoneyBox = new System.Windows.Forms.TextBox();
            this.userHandlerButton = new System.Windows.Forms.Button();
            this.idBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.infoOfWindow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "username:";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(91, 84);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(100, 23);
            this.usernameBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(91, 128);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(100, 23);
            this.passwordBox.TabIndex = 1;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(91, 66);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(59, 15);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(91, 110);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(57, 15);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "password";
            // 
            // addMoneyLabel
            // 
            this.addMoneyLabel.AutoSize = true;
            this.addMoneyLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addMoneyLabel.Location = new System.Drawing.Point(100, 66);
            this.addMoneyLabel.Name = "addMoneyLabel";
            this.addMoneyLabel.Size = new System.Drawing.Size(82, 15);
            this.addMoneyLabel.TabIndex = 4;
            this.addMoneyLabel.Text = "ADD MONEY!";
            // 
            // addMoneyBox
            // 
            this.addMoneyBox.Location = new System.Drawing.Point(118, 95);
            this.addMoneyBox.Name = "addMoneyBox";
            this.addMoneyBox.Size = new System.Drawing.Size(41, 23);
            this.addMoneyBox.TabIndex = 5;
            // 
            // userHandlerButton
            // 
            this.userHandlerButton.Location = new System.Drawing.Point(100, 229);
            this.userHandlerButton.Name = "userHandlerButton";
            this.userHandlerButton.Size = new System.Drawing.Size(75, 23);
            this.userHandlerButton.TabIndex = 6;
            this.userHandlerButton.UseVisualStyleBackColor = true;
            this.userHandlerButton.Click += new System.EventHandler(this.userHandlerButton_Click);
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(91, 40);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(100, 23);
            this.idBox.TabIndex = 7;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(91, 22);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(17, 15);
            this.idLabel.TabIndex = 8;
            this.idLabel.Text = "id";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Red;
            this.closeButton.ForeColor = System.Drawing.SystemColors.Info;
            this.closeButton.Location = new System.Drawing.Point(252, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 23);
            this.closeButton.TabIndex = 9;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // infoOfWindow
            // 
            this.infoOfWindow.AutoSize = true;
            this.infoOfWindow.Location = new System.Drawing.Point(12, 9);
            this.infoOfWindow.Name = "infoOfWindow";
            this.infoOfWindow.Size = new System.Drawing.Size(12, 15);
            this.infoOfWindow.TabIndex = 10;
            this.infoOfWindow.Text = "-";
            // 
            // UserHandler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(288, 280);
            this.Controls.Add(this.infoOfWindow);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.userHandlerButton);
            this.Controls.Add(this.addMoneyBox);
            this.Controls.Add(this.addMoneyLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserHandler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserHandler";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usernameBox;
        private TextBox passwordBox;
        private Label usernameLabel;
        private Label passwordLabel;
        private Label addMoneyLabel;
        private TextBox addMoneyBox;
        private Button userHandlerButton;
        private TextBox idBox;
        private Label idLabel;
        private Button closeButton;
        private Label infoOfWindow;
    }
}