namespace banking_project
{
    partial class Menu
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
            menuStrip1 = new MenuStrip();
            accountToolStripMenuItem = new ToolStripMenuItem();
            newAccountToolStripMenuItem = new ToolStripMenuItem();
            updateSearchAccountToolStripMenuItem = new ToolStripMenuItem();
            allCustomersToolStripMenuItem = new ToolStripMenuItem();
            traToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            othersToolStripMenuItem = new ToolStripMenuItem();
            depositeToolStripMenuItem = new ToolStripMenuItem();
            withdrawToolStripMenuItem = new ToolStripMenuItem();
            transferToolStripMenuItem = new ToolStripMenuItem();
            fDFormToolStripMenuItem = new ToolStripMenuItem();
            balanceSheetToolStripMenuItem = new ToolStripMenuItem();
            viewFDToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { accountToolStripMenuItem, traToolStripMenuItem, viewToolStripMenuItem, othersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1072, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newAccountToolStripMenuItem, updateSearchAccountToolStripMenuItem, allCustomersToolStripMenuItem });
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(77, 24);
            accountToolStripMenuItem.Text = "Account";
            // 
            // newAccountToolStripMenuItem
            // 
            newAccountToolStripMenuItem.Name = "newAccountToolStripMenuItem";
            newAccountToolStripMenuItem.Size = new Size(249, 26);
            newAccountToolStripMenuItem.Text = "New Account";
            newAccountToolStripMenuItem.Click += newAccountToolStripMenuItem_Click;
            // 
            // updateSearchAccountToolStripMenuItem
            // 
            updateSearchAccountToolStripMenuItem.Name = "updateSearchAccountToolStripMenuItem";
            updateSearchAccountToolStripMenuItem.Size = new Size(249, 26);
            updateSearchAccountToolStripMenuItem.Text = "Update/Search Account";
            updateSearchAccountToolStripMenuItem.Click += updateSearchAccountToolStripMenuItem_Click;
            // 
            // allCustomersToolStripMenuItem
            // 
            allCustomersToolStripMenuItem.Name = "allCustomersToolStripMenuItem";
            allCustomersToolStripMenuItem.Size = new Size(249, 26);
            allCustomersToolStripMenuItem.Text = "All Customers";
            allCustomersToolStripMenuItem.Click += allCustomersToolStripMenuItem_Click;
            // 
            // traToolStripMenuItem
            // 
            traToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { depositeToolStripMenuItem, withdrawToolStripMenuItem, transferToolStripMenuItem, fDFormToolStripMenuItem });
            traToolStripMenuItem.Name = "traToolStripMenuItem";
            traToolStripMenuItem.Size = new Size(104, 24);
            traToolStripMenuItem.Text = "Transcations";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { balanceSheetToolStripMenuItem, viewFDToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // othersToolStripMenuItem
            // 
            othersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem, changePasswordToolStripMenuItem, exitToolStripMenuItem });
            othersToolStripMenuItem.Name = "othersToolStripMenuItem";
            othersToolStripMenuItem.Size = new Size(66, 24);
            othersToolStripMenuItem.Text = "Others";
            // 
            // depositeToolStripMenuItem
            // 
            depositeToolStripMenuItem.Name = "depositeToolStripMenuItem";
            depositeToolStripMenuItem.Size = new Size(224, 26);
            depositeToolStripMenuItem.Text = "Deposite";
            depositeToolStripMenuItem.Click += depositeToolStripMenuItem_Click;
            // 
            // withdrawToolStripMenuItem
            // 
            withdrawToolStripMenuItem.Name = "withdrawToolStripMenuItem";
            withdrawToolStripMenuItem.Size = new Size(224, 26);
            withdrawToolStripMenuItem.Text = "Withdraw";
            withdrawToolStripMenuItem.Click += withdrawToolStripMenuItem_Click;
            // 
            // transferToolStripMenuItem
            // 
            transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            transferToolStripMenuItem.Size = new Size(224, 26);
            transferToolStripMenuItem.Text = "Transfer";
            transferToolStripMenuItem.Click += transferToolStripMenuItem_Click;
            // 
            // fDFormToolStripMenuItem
            // 
            fDFormToolStripMenuItem.Name = "fDFormToolStripMenuItem";
            fDFormToolStripMenuItem.Size = new Size(224, 26);
            fDFormToolStripMenuItem.Text = "FD Form";
            fDFormToolStripMenuItem.Click += fDFormToolStripMenuItem_Click;
            // 
            // balanceSheetToolStripMenuItem
            // 
            balanceSheetToolStripMenuItem.Name = "balanceSheetToolStripMenuItem";
            balanceSheetToolStripMenuItem.Size = new Size(224, 26);
            balanceSheetToolStripMenuItem.Text = "Balance Sheet";
            balanceSheetToolStripMenuItem.Click += balanceSheetToolStripMenuItem_Click;
            // 
            // viewFDToolStripMenuItem
            // 
            viewFDToolStripMenuItem.Name = "viewFDToolStripMenuItem";
            viewFDToolStripMenuItem.Size = new Size(224, 26);
            viewFDToolStripMenuItem.Text = "View FD";
            viewFDToolStripMenuItem.Click += viewFDToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(224, 26);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(224, 26);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 646);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem newAccountToolStripMenuItem;
        private ToolStripMenuItem updateSearchAccountToolStripMenuItem;
        private ToolStripMenuItem allCustomersToolStripMenuItem;
        private ToolStripMenuItem traToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem othersToolStripMenuItem;
        private ToolStripMenuItem depositeToolStripMenuItem;
        private ToolStripMenuItem withdrawToolStripMenuItem;
        private ToolStripMenuItem transferToolStripMenuItem;
        private ToolStripMenuItem fDFormToolStripMenuItem;
        private ToolStripMenuItem balanceSheetToolStripMenuItem;
        private ToolStripMenuItem viewFDToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}