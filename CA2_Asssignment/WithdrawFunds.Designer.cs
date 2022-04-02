namespace CA2_Asssignment
{
    partial class WithdrawFunds
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
            this.grpdeposit = new System.Windows.Forms.GroupBox();
            this.lblBal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboAccNo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnwithdraw = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpdeposit.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpdeposit
            // 
            this.grpdeposit.Controls.Add(this.lblBal);
            this.grpdeposit.Controls.Add(this.label4);
            this.grpdeposit.Controls.Add(this.txtWAmount);
            this.grpdeposit.Controls.Add(this.label2);
            this.grpdeposit.Controls.Add(this.cboAccNo);
            this.grpdeposit.Controls.Add(this.label11);
            this.grpdeposit.Controls.Add(this.btnwithdraw);
            this.grpdeposit.Controls.Add(this.lblname);
            this.grpdeposit.Controls.Add(this.label1);
            this.grpdeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpdeposit.Location = new System.Drawing.Point(32, 26);
            this.grpdeposit.Name = "grpdeposit";
            this.grpdeposit.Size = new System.Drawing.Size(810, 471);
            this.grpdeposit.TabIndex = 2;
            this.grpdeposit.TabStop = false;
            this.grpdeposit.Text = "Withdraw Funds";
            // 
            // lblBal
            // 
            this.lblBal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblBal.Location = new System.Drawing.Point(343, 215);
            this.lblBal.Name = "lblBal";
            this.lblBal.Size = new System.Drawing.Size(349, 34);
            this.lblBal.TabIndex = 20;
            this.lblBal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Account Balance";
            // 
            // txtWAmount
            // 
            this.txtWAmount.Location = new System.Drawing.Point(343, 292);
            this.txtWAmount.Name = "txtWAmount";
            this.txtWAmount.Size = new System.Drawing.Size(349, 30);
            this.txtWAmount.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Withdraw Amount";
            // 
            // cboAccNo
            // 
            this.cboAccNo.FormattingEnabled = true;
            this.cboAccNo.Location = new System.Drawing.Point(343, 64);
            this.cboAccNo.Name = "cboAccNo";
            this.cboAccNo.Size = new System.Drawing.Size(349, 33);
            this.cboAccNo.TabIndex = 16;
            this.cboAccNo.SelectedIndexChanged += new System.EventHandler(this.cboAccNo_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(71, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(247, 25);
            this.label11.TabIndex = 15;
            this.label11.Text = "Withdrawl From Account";
            // 
            // btnwithdraw
            // 
            this.btnwithdraw.Location = new System.Drawing.Point(287, 394);
            this.btnwithdraw.Name = "btnwithdraw";
            this.btnwithdraw.Size = new System.Drawing.Size(203, 56);
            this.btnwithdraw.TabIndex = 14;
            this.btnwithdraw.Text = "Withdraw Funds";
            this.btnwithdraw.UseVisualStyleBackColor = true;
            this.btnwithdraw.Click += new System.EventHandler(this.btnwithdraw_Click);
            // 
            // lblname
            // 
            this.lblname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblname.Location = new System.Drawing.Point(343, 137);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(349, 34);
            this.lblname.TabIndex = 7;
            this.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Holder Name";
            // 
            // WithdrawFunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 544);
            this.Controls.Add(this.grpdeposit);
            this.Name = "WithdrawFunds";
            this.Text = "WithdrawFunds";
            this.Load += new System.EventHandler(this.WithdrawFunds_Load);
            this.grpdeposit.ResumeLayout(false);
            this.grpdeposit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpdeposit;
        private System.Windows.Forms.Label lblBal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboAccNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnwithdraw;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label1;
    }
}