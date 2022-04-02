namespace CA2_Asssignment
{
    partial class DepositFunds
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
            this.lblname = new System.Windows.Forms.Label();
            this.btndeposit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cboAccNo = new System.Windows.Forms.ComboBox();
            this.grpdeposit = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDAmount = new System.Windows.Forms.TextBox();
            this.lblBal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpdeposit.SuspendLayout();
            this.SuspendLayout();
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
            // lblname
            // 
            this.lblname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblname.Location = new System.Drawing.Point(316, 137);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(349, 34);
            this.lblname.TabIndex = 7;
            this.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btndeposit
            // 
            this.btndeposit.Location = new System.Drawing.Point(323, 428);
            this.btndeposit.Name = "btndeposit";
            this.btndeposit.Size = new System.Drawing.Size(180, 56);
            this.btndeposit.TabIndex = 14;
            this.btndeposit.Text = "Deposit Funds";
            this.btndeposit.UseVisualStyleBackColor = true;
            this.btndeposit.Click += new System.EventHandler(this.btndeposit_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(71, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 25);
            this.label11.TabIndex = 15;
            this.label11.Text = "Deposit To Account";
            // 
            // cboAccNo
            // 
            this.cboAccNo.FormattingEnabled = true;
            this.cboAccNo.Location = new System.Drawing.Point(316, 64);
            this.cboAccNo.Name = "cboAccNo";
            this.cboAccNo.Size = new System.Drawing.Size(349, 33);
            this.cboAccNo.TabIndex = 16;
            this.cboAccNo.SelectedIndexChanged += new System.EventHandler(this.cboAccNo_SelectedIndexChanged);
            // 
            // grpdeposit
            // 
            this.grpdeposit.Controls.Add(this.lblBal);
            this.grpdeposit.Controls.Add(this.label4);
            this.grpdeposit.Controls.Add(this.txtDAmount);
            this.grpdeposit.Controls.Add(this.label2);
            this.grpdeposit.Controls.Add(this.cboAccNo);
            this.grpdeposit.Controls.Add(this.label11);
            this.grpdeposit.Controls.Add(this.btndeposit);
            this.grpdeposit.Controls.Add(this.lblname);
            this.grpdeposit.Controls.Add(this.label1);
            this.grpdeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpdeposit.Location = new System.Drawing.Point(21, 21);
            this.grpdeposit.Name = "grpdeposit";
            this.grpdeposit.Size = new System.Drawing.Size(821, 534);
            this.grpdeposit.TabIndex = 1;
            this.grpdeposit.TabStop = false;
            this.grpdeposit.Text = "Deposit Funds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Deposit Amount";
            // 
            // txtDAmount
            // 
            this.txtDAmount.Location = new System.Drawing.Point(316, 292);
            this.txtDAmount.Name = "txtDAmount";
            this.txtDAmount.Size = new System.Drawing.Size(349, 30);
            this.txtDAmount.TabIndex = 18;
            // 
            // lblBal
            // 
            this.lblBal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblBal.Location = new System.Drawing.Point(316, 215);
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
            // DepositFunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 605);
            this.Controls.Add(this.grpdeposit);
            this.Name = "DepositFunds";
            this.Text = "DepositFunds";
            this.Load += new System.EventHandler(this.DepositFunds_Load);
            this.grpdeposit.ResumeLayout(false);
            this.grpdeposit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button btndeposit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboAccNo;
        private System.Windows.Forms.GroupBox grpdeposit;
        private System.Windows.Forms.TextBox txtDAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBal;
        private System.Windows.Forms.Label label4;
    }
}