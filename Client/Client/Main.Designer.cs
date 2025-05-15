namespace Client
{
    partial class Main
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
            this.gameButton = new System.Windows.Forms.Button();
            this.numberBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lossLabel = new System.Windows.Forms.Label();
            this.successLabel = new System.Windows.Forms.Label();
            this.gameResetButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.no9 = new System.Windows.Forms.Label();
            this.no8 = new System.Windows.Forms.Label();
            this.no7 = new System.Windows.Forms.Label();
            this.no6 = new System.Windows.Forms.Label();
            this.no5 = new System.Windows.Forms.Label();
            this.no4 = new System.Windows.Forms.Label();
            this.no3 = new System.Windows.Forms.Label();
            this.no2 = new System.Windows.Forms.Label();
            this.no1 = new System.Windows.Forms.Label();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.winsLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.uploadMoney = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.usersData = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gyozelmek = new System.Windows.Forms.Label();
            this.registrationButton = new System.Windows.Forms.Button();
            this.adminLabel = new System.Windows.Forms.Label();
            this.deleteUser = new System.Windows.Forms.Button();
            this.hufLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersData)).BeginInit();
            this.SuspendLayout();
            // 
            // gameButton
            // 
            this.gameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gameButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gameButton.Location = new System.Drawing.Point(83, 321);
            this.gameButton.Name = "gameButton";
            this.gameButton.Size = new System.Drawing.Size(121, 54);
            this.gameButton.TabIndex = 0;
            this.gameButton.Text = "JÁTÉK";
            this.gameButton.UseVisualStyleBackColor = false;
            this.gameButton.Click += new System.EventHandler(this.gameButton_Click);
            // 
            // numberBox
            // 
            this.numberBox.FormattingEnabled = true;
            this.numberBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.numberBox.Location = new System.Drawing.Point(83, 292);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(121, 23);
            this.numberBox.TabIndex = 1;
            this.numberBox.Text = "Számok";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lossLabel);
            this.panel1.Controls.Add(this.successLabel);
            this.panel1.Controls.Add(this.gameResetButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.no9);
            this.panel1.Controls.Add(this.no8);
            this.panel1.Controls.Add(this.no7);
            this.panel1.Controls.Add(this.no6);
            this.panel1.Controls.Add(this.no5);
            this.panel1.Controls.Add(this.no4);
            this.panel1.Controls.Add(this.no3);
            this.panel1.Controls.Add(this.no2);
            this.panel1.Controls.Add(this.no1);
            this.panel1.Controls.Add(this.numberBox);
            this.panel1.Controls.Add(this.gameButton);
            this.panel1.Location = new System.Drawing.Point(230, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 413);
            this.panel1.TabIndex = 2;
            // 
            // lossLabel
            // 
            this.lossLabel.AutoSize = true;
            this.lossLabel.BackColor = System.Drawing.Color.DimGray;
            this.lossLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lossLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lossLabel.Location = new System.Drawing.Point(83, 101);
            this.lossLabel.Name = "lossLabel";
            this.lossLabel.Size = new System.Drawing.Size(115, 30);
            this.lossLabel.TabIndex = 15;
            this.lossLabel.Text = "Vesztettél!";
            this.lossLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lossLabel.Visible = false;
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.BackColor = System.Drawing.Color.DimGray;
            this.successLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.successLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.successLabel.Location = new System.Drawing.Point(95, 101);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(93, 30);
            this.successLabel.TabIndex = 14;
            this.successLabel.Text = "Nyertél!";
            this.successLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.successLabel.Visible = false;
            // 
            // gameResetButton
            // 
            this.gameResetButton.Location = new System.Drawing.Point(83, 381);
            this.gameResetButton.Name = "gameResetButton";
            this.gameResetButton.Size = new System.Drawing.Size(121, 23);
            this.gameResetButton.TabIndex = 13;
            this.gameResetButton.Text = "próbáld újra";
            this.gameResetButton.UseVisualStyleBackColor = true;
            this.gameResetButton.Click += new System.EventHandler(this.gameResetButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nyeremény ha talált: 4000 HUF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Játék ára: 500 HUF";
            // 
            // no9
            // 
            this.no9.AutoSize = true;
            this.no9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.no9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.no9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.no9.Location = new System.Drawing.Point(209, 153);
            this.no9.Name = "no9";
            this.no9.Size = new System.Drawing.Size(23, 25);
            this.no9.TabIndex = 10;
            this.no9.Text = "9";
            // 
            // no8
            // 
            this.no8.AutoSize = true;
            this.no8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.no8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.no8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.no8.Location = new System.Drawing.Point(190, 153);
            this.no8.Name = "no8";
            this.no8.Size = new System.Drawing.Size(23, 25);
            this.no8.TabIndex = 9;
            this.no8.Text = "8";
            // 
            // no7
            // 
            this.no7.AutoSize = true;
            this.no7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.no7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.no7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.no7.Location = new System.Drawing.Point(171, 153);
            this.no7.Name = "no7";
            this.no7.Size = new System.Drawing.Size(22, 25);
            this.no7.TabIndex = 8;
            this.no7.Text = "7";
            // 
            // no6
            // 
            this.no6.AutoSize = true;
            this.no6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.no6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.no6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.no6.Location = new System.Drawing.Point(152, 153);
            this.no6.Name = "no6";
            this.no6.Size = new System.Drawing.Size(23, 25);
            this.no6.TabIndex = 7;
            this.no6.Text = "6";
            // 
            // no5
            // 
            this.no5.AutoSize = true;
            this.no5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.no5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.no5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.no5.Location = new System.Drawing.Point(133, 153);
            this.no5.Name = "no5";
            this.no5.Size = new System.Drawing.Size(23, 25);
            this.no5.TabIndex = 6;
            this.no5.Text = "5";
            // 
            // no4
            // 
            this.no4.AutoSize = true;
            this.no4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.no4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.no4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.no4.Location = new System.Drawing.Point(114, 153);
            this.no4.Name = "no4";
            this.no4.Size = new System.Drawing.Size(23, 25);
            this.no4.TabIndex = 5;
            this.no4.Text = "4";
            // 
            // no3
            // 
            this.no3.AutoSize = true;
            this.no3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.no3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.no3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.no3.Location = new System.Drawing.Point(95, 153);
            this.no3.Name = "no3";
            this.no3.Size = new System.Drawing.Size(23, 25);
            this.no3.TabIndex = 4;
            this.no3.Text = "3";
            // 
            // no2
            // 
            this.no2.AutoSize = true;
            this.no2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.no2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.no2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.no2.Location = new System.Drawing.Point(76, 153);
            this.no2.Name = "no2";
            this.no2.Size = new System.Drawing.Size(23, 25);
            this.no2.TabIndex = 3;
            this.no2.Text = "2";
            // 
            // no1
            // 
            this.no1.AutoSize = true;
            this.no1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.no1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.no1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.no1.Location = new System.Drawing.Point(57, 153);
            this.no1.Name = "no1";
            this.no1.Size = new System.Drawing.Size(20, 25);
            this.no1.TabIndex = 2;
            this.no1.Text = "1";
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.AutoSize = true;
            this.currentUserLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentUserLabel.Location = new System.Drawing.Point(767, 14);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(24, 32);
            this.currentUserLabel.TabIndex = 3;
            this.currentUserLabel.Text = "-";
            this.currentUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.balanceLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.balanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.balanceLabel.Location = new System.Drawing.Point(61, 15);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(33, 45);
            this.balanceLabel.TabIndex = 4;
            this.balanceLabel.Text = "-";
            // 
            // winsLabel
            // 
            this.winsLabel.AutoSize = true;
            this.winsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.winsLabel.Location = new System.Drawing.Point(767, 54);
            this.winsLabel.Name = "winsLabel";
            this.winsLabel.Size = new System.Drawing.Size(24, 32);
            this.winsLabel.TabIndex = 5;
            this.winsLabel.Text = "-";
            this.winsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(33, 392);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(91, 23);
            this.logoutButton.TabIndex = 6;
            this.logoutButton.Text = "kijelentkezés";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // uploadMoney
            // 
            this.uploadMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.uploadMoney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.uploadMoney.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uploadMoney.ForeColor = System.Drawing.Color.Black;
            this.uploadMoney.Location = new System.Drawing.Point(61, 63);
            this.uploadMoney.Name = "uploadMoney";
            this.uploadMoney.Size = new System.Drawing.Size(105, 38);
            this.uploadMoney.TabIndex = 7;
            this.uploadMoney.Text = "Feltöltés";
            this.uploadMoney.UseVisualStyleBackColor = false;
            this.uploadMoney.Click += new System.EventHandler(this.uploadMoney_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(33, 363);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(91, 23);
            this.loginButton.TabIndex = 8;
            this.loginButton.Text = "bejelentkezés";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // usersData
            // 
            this.usersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersData.Location = new System.Drawing.Point(570, 165);
            this.usersData.Name = "usersData";
            this.usersData.RowTemplate.Height = 25;
            this.usersData.Size = new System.Drawing.Size(428, 257);
            this.usersData.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(758, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ranglista";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(570, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Bejelentkezve mint:";
            // 
            // gyozelmek
            // 
            this.gyozelmek.AutoSize = true;
            this.gyozelmek.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gyozelmek.Location = new System.Drawing.Point(598, 63);
            this.gyozelmek.Name = "gyozelmek";
            this.gyozelmek.Size = new System.Drawing.Size(90, 21);
            this.gyozelmek.TabIndex = 12;
            this.gyozelmek.Text = "Győzelmek:";
            // 
            // registrationButton
            // 
            this.registrationButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.registrationButton.FlatAppearance.BorderSize = 3;
            this.registrationButton.Location = new System.Drawing.Point(33, 334);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(91, 23);
            this.registrationButton.TabIndex = 13;
            this.registrationButton.Text = "regisztráció";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.BackColor = System.Drawing.Color.Black;
            this.adminLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adminLabel.ForeColor = System.Drawing.Color.Transparent;
            this.adminLabel.Location = new System.Drawing.Point(101, 166);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(435, 52);
            this.adminLabel.TabIndex = 15;
            this.adminLabel.Text = "ADMIN CONTROL PANEL";
            this.adminLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.adminLabel.Visible = false;
            // 
            // deleteUser
            // 
            this.deleteUser.BackColor = System.Drawing.Color.Red;
            this.deleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteUser.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteUser.ForeColor = System.Drawing.Color.White;
            this.deleteUser.Location = new System.Drawing.Point(731, 112);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(109, 32);
            this.deleteUser.TabIndex = 16;
            this.deleteUser.Text = "BAN USER";
            this.deleteUser.UseVisualStyleBackColor = false;
            this.deleteUser.Visible = false;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // hufLabel
            // 
            this.hufLabel.AutoSize = true;
            this.hufLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hufLabel.Location = new System.Drawing.Point(1, 28);
            this.hufLabel.Name = "hufLabel";
            this.hufLabel.Size = new System.Drawing.Size(54, 25);
            this.hufLabel.TabIndex = 17;
            this.hufLabel.Text = "HUF:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1028, 450);
            this.Controls.Add(this.hufLabel);
            this.Controls.Add(this.deleteUser);
            this.Controls.Add(this.adminLabel);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.gyozelmek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usersData);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.uploadMoney);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.winsLabel);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.currentUserLabel);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button gameButton;
        private ComboBox numberBox;
        private Panel panel1;
        private Label no9;
        private Label no8;
        private Label no7;
        private Label no6;
        private Label no5;
        private Label no4;
        private Label no3;
        private Label no2;
        private Label no1;
        private Label currentUserLabel;
        private Label label2;
        private Label label1;
        private Label balanceLabel;
        private Label winsLabel;
        private Button logoutButton;
        private Button uploadMoney;
        private Button loginButton;
        private DataGridView usersData;
        private Label label3;
        private Label label4;
        private Label gyozelmek;
        private Button registrationButton;
        private Button gameResetButton;
        private Label adminLabel;
        private Button deleteUser;
        private Label hufLabel;
        private Label successLabel;
        private Label lossLabel;
    }
}