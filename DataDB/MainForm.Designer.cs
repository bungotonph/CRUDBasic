namespace DataDB
{
    partial class MainForm
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
            dataGridView1 = new DataGridView();
            BTNSave = new Button();
            BTNView = new Button();
            LBLDesc = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1444, 200);
            dataGridView1.TabIndex = 0;
            // 
            // BTNSave
            // 
            BTNSave.Location = new Point(38, 244);
            BTNSave.Name = "BTNSave";
            BTNSave.Size = new Size(75, 23);
            BTNSave.TabIndex = 2;
            BTNSave.Text = "Save";
            BTNSave.UseVisualStyleBackColor = true;
            BTNSave.Click += BTNSave_Click;
            // 
            // BTNView
            // 
            BTNView.Location = new Point(37, 214);
            BTNView.Name = "BTNView";
            BTNView.Size = new Size(75, 23);
            BTNView.TabIndex = 3;
            BTNView.Text = "View Data";
            BTNView.UseVisualStyleBackColor = true;
            BTNView.Click += BTNView_Click;
            // 
            // LBLDesc
            // 
            LBLDesc.AutoSize = true;
            LBLDesc.Location = new Point(135, 252);
            LBLDesc.Name = "LBLDesc";
            LBLDesc.Size = new Size(469, 15);
            LBLDesc.TabIndex = 4;
            LBLDesc.Text = "You can edit the data in the DataGridView directly to update the records in the database.";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1444, 290);
            Controls.Add(LBLDesc);
            Controls.Add(BTNView);
            Controls.Add(BTNSave);
            Controls.Add(dataGridView1);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button BTNSave;
        private Button BTNView;
        private Label LBLDesc;
    }
}