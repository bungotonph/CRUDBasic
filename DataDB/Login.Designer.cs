namespace DataDB
{
    partial class ConnectionWindow
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
            BTNConnect = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            serverTextBox = new TextBox();
            databaseTextBox = new TextBox();
            userTextBox = new TextBox();
            passwordTextBox = new TextBox();
            SuspendLayout();
            // 
            // BTNConnect
            // 
            BTNConnect.Location = new Point(194, 61);
            BTNConnect.Name = "BTNConnect";
            BTNConnect.Size = new Size(173, 59);
            BTNConnect.TabIndex = 0;
            BTNConnect.Text = "Connect";
            BTNConnect.UseVisualStyleBackColor = true;
            BTNConnect.Click += BTNConnect_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 12);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Server";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 12);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 2;
            label2.Text = "Database";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 70);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 3;
            label3.Text = "User";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 99);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // serverTextBox
            // 
            serverTextBox.Location = new Point(76, 10);
            serverTextBox.Name = "serverTextBox";
            serverTextBox.Size = new Size(100, 23);
            serverTextBox.TabIndex = 5;
            // 
            // databaseTextBox
            // 
            databaseTextBox.Location = new Point(267, 10);
            databaseTextBox.Name = "databaseTextBox";
            databaseTextBox.Size = new Size(100, 23);
            databaseTextBox.TabIndex = 6;
            // 
            // userTextBox
            // 
            userTextBox.Location = new Point(76, 68);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(100, 23);
            userTextBox.TabIndex = 7;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(76, 97);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(100, 23);
            passwordTextBox.TabIndex = 8;
            // 
            // ConnectionWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 145);
            Controls.Add(passwordTextBox);
            Controls.Add(userTextBox);
            Controls.Add(databaseTextBox);
            Controls.Add(serverTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BTNConnect);
            Name = "ConnectionWindow";
            Text = "SQL Authentication";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNConnect;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox serverTextBox;
        private TextBox databaseTextBox;
        private TextBox userTextBox;
        private TextBox passwordTextBox;
    }
}