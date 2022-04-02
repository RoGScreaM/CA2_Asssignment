namespace CA2_Asssignment
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositFundsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawFundsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferFundsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.servicesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(907, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAccountToolStripMenuItem,
            this.editAccountToolStripMenuItem,
            this.depositFundsToolStripMenuItem,
            this.withdrawFundsToolStripMenuItem,
            this.transferFundsToolStripMenuItem,
            this.viewTransactionsToolStripMenuItem});
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.servicesToolStripMenuItem.Text = "Services";
            // 
            // newAccountToolStripMenuItem
            // 
            this.newAccountToolStripMenuItem.Name = "newAccountToolStripMenuItem";
            this.newAccountToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newAccountToolStripMenuItem.Text = "New Account";
            // 
            // editAccountToolStripMenuItem
            // 
            this.editAccountToolStripMenuItem.Name = "editAccountToolStripMenuItem";
            this.editAccountToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editAccountToolStripMenuItem.Text = "Edit Account";
            this.editAccountToolStripMenuItem.Click += new System.EventHandler(this.editAccountToolStripMenuItem_Click);
            // 
            // depositFundsToolStripMenuItem
            // 
            this.depositFundsToolStripMenuItem.Name = "depositFundsToolStripMenuItem";
            this.depositFundsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.depositFundsToolStripMenuItem.Text = "Deposit Funds";
            this.depositFundsToolStripMenuItem.Click += new System.EventHandler(this.depositFundsToolStripMenuItem_Click);
            // 
            // withdrawFundsToolStripMenuItem
            // 
            this.withdrawFundsToolStripMenuItem.Name = "withdrawFundsToolStripMenuItem";
            this.withdrawFundsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.withdrawFundsToolStripMenuItem.Text = "Withdraw Funds";
            this.withdrawFundsToolStripMenuItem.Click += new System.EventHandler(this.withdrawFundsToolStripMenuItem_Click);
            // 
            // transferFundsToolStripMenuItem
            // 
            this.transferFundsToolStripMenuItem.Name = "transferFundsToolStripMenuItem";
            this.transferFundsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.transferFundsToolStripMenuItem.Text = "Transfer Funds";
            this.transferFundsToolStripMenuItem.Click += new System.EventHandler(this.transferFundsToolStripMenuItem_Click);
            // 
            // viewTransactionsToolStripMenuItem
            // 
            this.viewTransactionsToolStripMenuItem.Name = "viewTransactionsToolStripMenuItem";
            this.viewTransactionsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewTransactionsToolStripMenuItem.Text = "View Transactions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 534);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositFundsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawFundsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferFundsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTransactionsToolStripMenuItem;
    }
}

