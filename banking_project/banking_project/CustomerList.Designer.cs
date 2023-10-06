namespace banking_project
{
    partial class CustomerList
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
            label1 = new Label();
            Account_No = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            DOB = new DataGridViewTextBoxColumn();
            phoneNo = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            balance = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Account_No, CustomerName, DOB, phoneNo, Address, balance });
            dataGridView1.Location = new Point(3, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1042, 523);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(392, 40);
            label1.Name = "label1";
            label1.Size = new Size(224, 39);
            label1.TabIndex = 1;
            label1.Text = "All Customer";
            // 
            // Account_No
            // 
            Account_No.DataPropertyName = "Account_No";
            Account_No.HeaderText = "Account_No";
            Account_No.MinimumWidth = 6;
            Account_No.Name = "Account_No";
            Account_No.Width = 125;
            // 
            // CustomerName
            // 
            CustomerName.DataPropertyName = "Name";
            CustomerName.HeaderText = "Name";
            CustomerName.MinimumWidth = 6;
            CustomerName.Name = "CustomerName";
            CustomerName.Width = 125;
            // 
            // DOB
            // 
            DOB.DataPropertyName = "DOB";
            DOB.HeaderText = "Date Of Birth";
            DOB.MinimumWidth = 6;
            DOB.Name = "DOB";
            DOB.Width = 125;
            // 
            // phoneNo
            // 
            phoneNo.DataPropertyName = "PhoneNo";
            phoneNo.HeaderText = "Phone No";
            phoneNo.MinimumWidth = 6;
            phoneNo.Name = "phoneNo";
            phoneNo.Width = 125;
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.Width = 125;
            // 
            // balance
            // 
            balance.DataPropertyName = "balance";
            balance.HeaderText = "Balance";
            balance.MinimumWidth = 6;
            balance.Name = "balance";
            balance.Width = 125;
            // 
            // CustomerList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 732);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "CustomerList";
            Text = "CustomerList";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private DataGridViewTextBoxColumn Account_No;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn DOB;
        private DataGridViewTextBoxColumn phoneNo;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn balance;
    }
}