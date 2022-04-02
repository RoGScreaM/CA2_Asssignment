namespace CA2_Asssignment
{
    partial class TransferFunds
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
            this.grpTransfer = new System.Windows.Forms.GroupBox();
            this.lblBal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSenderAccNo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTransferFunds = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboRecieverAccNo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRname = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRSortCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdoSavings = new System.Windows.Forms.RadioButton();
            this.rdoCurrent = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.lblOL = new System.Windows.Forms.Label();
            this.grpTransfer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTransfer
            // 
            this.grpTransfer.Controls.Add(this.lblOL);
            this.grpTransfer.Controls.Add(this.label7);
            this.grpTransfer.Controls.Add(this.rdoCurrent);
            this.grpTransfer.Controls.Add(this.rdoSavings);
            this.grpTransfer.Controls.Add(this.txtRSortCode);
            this.grpTransfer.Controls.Add(this.label5);
            this.grpTransfer.Controls.Add(this.label3);
            this.grpTransfer.Controls.Add(this.cboRecieverAccNo);
            this.grpTransfer.Controls.Add(this.label6);
            this.grpTransfer.Controls.Add(this.lblRname);
            this.grpTransfer.Controls.Add(this.label8);
            this.grpTransfer.Controls.Add(this.lblBal);
            this.grpTransfer.Controls.Add(this.label4);
            this.grpTransfer.Controls.Add(this.txtTAmount);
            this.grpTransfer.Controls.Add(this.label2);
            this.grpTransfer.Controls.Add(this.cboSenderAccNo);
            this.grpTransfer.Controls.Add(this.label11);
            this.grpTransfer.Controls.Add(this.btnTransferFunds);
            this.grpTransfer.Controls.Add(this.lblname);
            this.grpTransfer.Controls.Add(this.label1);
            this.grpTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTransfer.Location = new System.Drawing.Point(12, 29);
            this.grpTransfer.Name = "grpTransfer";
            this.grpTransfer.Size = new System.Drawing.Size(1099, 575);
            this.grpTransfer.TabIndex = 3;
            this.grpTransfer.TabStop = false;
            this.grpTransfer.Text = "Transfer Funds";
            // 
            // lblBal
            // 
            this.lblBal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblBal.Location = new System.Drawing.Point(841, 100);
            this.lblBal.Name = "lblBal";
            this.lblBal.Size = new System.Drawing.Size(203, 34);
            this.lblBal.TabIndex = 20;
            this.lblBal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(643, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Account Balance";
            // 
            // txtTAmount
            // 
            this.txtTAmount.Location = new System.Drawing.Point(280, 280);
            this.txtTAmount.Name = "txtTAmount";
            this.txtTAmount.Size = new System.Drawing.Size(331, 30);
            this.txtTAmount.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Transfer Amount";
            // 
            // cboSenderAccNo
            // 
            this.cboSenderAccNo.FormattingEnabled = true;
            this.cboSenderAccNo.Location = new System.Drawing.Point(284, 37);
            this.cboSenderAccNo.Name = "cboSenderAccNo";
            this.cboSenderAccNo.Size = new System.Drawing.Size(331, 33);
            this.cboSenderAccNo.TabIndex = 16;
            this.cboSenderAccNo.SelectedIndexChanged += new System.EventHandler(this.cboSenderAccNo_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(233, 25);
            this.label11.TabIndex = 15;
            this.label11.Text = "Transfer From Account";
            // 
            // btnTransferFunds
            // 
            this.btnTransferFunds.Location = new System.Drawing.Point(420, 508);
            this.btnTransferFunds.Name = "btnTransferFunds";
            this.btnTransferFunds.Size = new System.Drawing.Size(264, 56);
            this.btnTransferFunds.TabIndex = 14;
            this.btnTransferFunds.Text = "Transfer Funds";
            this.btnTransferFunds.UseVisualStyleBackColor = true;
            this.btnTransferFunds.Click += new System.EventHandler(this.btnTransferFunds_Click);
            // 
            // lblname
            // 
            this.lblname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblname.Location = new System.Drawing.Point(286, 100);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(329, 34);
            this.lblname.TabIndex = 7;
            this.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Holder Name";
            // 
            // cboRecieverAccNo
            // 
            this.cboRecieverAccNo.FormattingEnabled = true;
            this.cboRecieverAccNo.Location = new System.Drawing.Point(280, 359);
            this.cboRecieverAccNo.Name = "cboRecieverAccNo";
            this.cboRecieverAccNo.Size = new System.Drawing.Size(331, 33);
            this.cboRecieverAccNo.TabIndex = 24;
            this.cboRecieverAccNo.SelectedIndexChanged += new System.EventHandler(this.cboRecieverAccNo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Transfer To Account";
            // 
            // lblRname
            // 
            this.lblRname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblRname.Location = new System.Drawing.Point(282, 422);
            this.lblRname.Name = "lblRname";
            this.lblRname.Size = new System.Drawing.Size(329, 34);
            this.lblRname.TabIndex = 22;
            this.lblRname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 431);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(222, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Account Holder Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Account Type";
            // 
            // txtRSortCode
            // 
            this.txtRSortCode.Location = new System.Drawing.Point(849, 359);
            this.txtRSortCode.Name = "txtRSortCode";
            this.txtRSortCode.Size = new System.Drawing.Size(219, 30);
            this.txtRSortCode.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(643, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Reciever SortCode";
            // 
            // rdoSavings
            // 
            this.rdoSavings.AutoSize = true;
            this.rdoSavings.Checked = true;
            this.rdoSavings.Location = new System.Drawing.Point(284, 212);
            this.rdoSavings.Name = "rdoSavings";
            this.rdoSavings.Size = new System.Drawing.Size(196, 29);
            this.rdoSavings.TabIndex = 29;
            this.rdoSavings.TabStop = true;
            this.rdoSavings.Text = "Savings Account";
            this.rdoSavings.UseVisualStyleBackColor = true;
            // 
            // rdoCurrent
            // 
            this.rdoCurrent.AutoSize = true;
            this.rdoCurrent.Location = new System.Drawing.Point(535, 212);
            this.rdoCurrent.Name = "rdoCurrent";
            this.rdoCurrent.Size = new System.Drawing.Size(190, 29);
            this.rdoCurrent.TabIndex = 30;
            this.rdoCurrent.Text = "Current Account";
            this.rdoCurrent.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 25);
            this.label7.TabIndex = 31;
            this.label7.Text = "Overdraft Limit";
            // 
            // lblOL
            // 
            this.lblOL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblOL.Location = new System.Drawing.Point(286, 158);
            this.lblOL.Name = "lblOL";
            this.lblOL.Size = new System.Drawing.Size(329, 34);
            this.lblOL.TabIndex = 32;
            this.lblOL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TransferFunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 616);
            this.Controls.Add(this.grpTransfer);
            this.Name = "TransferFunds";
            this.Text = "TransferFunds";
            this.Load += new System.EventHandler(this.TransferFunds_Load);
            this.grpTransfer.ResumeLayout(false);
            this.grpTransfer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTransfer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboRecieverAccNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblBal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSenderAccNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnTransferFunds;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRSortCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdoCurrent;
        private System.Windows.Forms.RadioButton rdoSavings;
        private System.Windows.Forms.Label lblOL;
        private System.Windows.Forms.Label label7;
    }
}