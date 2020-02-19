namespace QR_Payment.Net
{
    partial class QRGenetator
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
            this.QRBox = new System.Windows.Forms.PictureBox();
            this.Amount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.txtTaxID = new System.Windows.Forms.TextBox();
            this.txtSuffix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRef1 = new System.Windows.Forms.TextBox();
            this.txtRef2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cbUsese = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMerchantName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTerminalNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCountryCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.QRBox)).BeginInit();
            this.SuspendLayout();
            // 
            // QRBox
            // 
            this.QRBox.BackColor = System.Drawing.Color.White;
            this.QRBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.QRBox.Location = new System.Drawing.Point(12, 12);
            this.QRBox.Name = "QRBox";
            this.QRBox.Size = new System.Drawing.Size(400, 400);
            this.QRBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QRBox.TabIndex = 0;
            this.QRBox.TabStop = false;
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(429, 154);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(53, 16);
            this.Amount.TabIndex = 4;
            this.Amount.Text = "Amount";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(587, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(12, 453);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(0, 13);
            this.ID.TabIndex = 8;
            // 
            // txtTaxID
            // 
            this.txtTaxID.Location = new System.Drawing.Point(535, 45);
            this.txtTaxID.Name = "txtTaxID";
            this.txtTaxID.Size = new System.Drawing.Size(246, 20);
            this.txtTaxID.TabIndex = 1;
            // 
            // txtSuffix
            // 
            this.txtSuffix.Location = new System.Drawing.Point(535, 71);
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Size = new System.Drawing.Size(246, 20);
            this.txtSuffix.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(427, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "TaxID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(429, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Suffix";
            // 
            // txtRef1
            // 
            this.txtRef1.Location = new System.Drawing.Point(535, 97);
            this.txtRef1.Name = "txtRef1";
            this.txtRef1.Size = new System.Drawing.Size(246, 20);
            this.txtRef1.TabIndex = 1;
            // 
            // txtRef2
            // 
            this.txtRef2.Location = new System.Drawing.Point(535, 126);
            this.txtRef2.Name = "txtRef2";
            this.txtRef2.Size = new System.Drawing.Size(246, 20);
            this.txtRef2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(427, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ref1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(427, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ref2";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Red;
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(553, 342);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(134, 43);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.generate_Btn_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(535, 153);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(246, 20);
            this.txtAmount.TabIndex = 1;
            // 
            // cbUsese
            // 
            this.cbUsese.FormattingEnabled = true;
            this.cbUsese.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbUsese.Location = new System.Drawing.Point(535, 290);
            this.cbUsese.Name = "cbUsese";
            this.cbUsese.Size = new System.Drawing.Size(246, 21);
            this.cbUsese.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "MultiUse?";
            // 
            // txtMerchantName
            // 
            this.txtMerchantName.Location = new System.Drawing.Point(535, 234);
            this.txtMerchantName.Name = "txtMerchantName";
            this.txtMerchantName.Size = new System.Drawing.Size(246, 20);
            this.txtMerchantName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(429, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Merc Name";
            // 
            // txtTerminalNumber
            // 
            this.txtTerminalNumber.Location = new System.Drawing.Point(535, 262);
            this.txtTerminalNumber.Name = "txtTerminalNumber";
            this.txtTerminalNumber.Size = new System.Drawing.Size(246, 20);
            this.txtTerminalNumber.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(429, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Terminal Num";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(427, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(429, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Currency";
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(535, 180);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(246, 20);
            this.txtCurrency.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(429, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "CountryCode";
            // 
            // txtCountryCode
            // 
            this.txtCountryCode.Location = new System.Drawing.Point(535, 208);
            this.txtCountryCode.Name = "txtCountryCode";
            this.txtCountryCode.Size = new System.Drawing.Size(246, 20);
            this.txtCountryCode.TabIndex = 16;
            // 
            // QRGenetator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 493);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCountryCode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCurrency);
            this.Controls.Add(this.cbUsese);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTerminalNumber);
            this.Controls.Add(this.txtMerchantName);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtRef2);
            this.Controls.Add(this.txtRef1);
            this.Controls.Add(this.txtSuffix);
            this.Controls.Add(this.txtTaxID);
            this.Controls.Add(this.QRBox);
            this.Name = "QRGenetator";
            this.Text = "PromptPayQR";
            this.Load += new System.EventHandler(this.QRGenetator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QRBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox QRBox;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox txtTaxID;
        private System.Windows.Forms.TextBox txtSuffix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRef1;
        private System.Windows.Forms.TextBox txtRef2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cbUsese;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMerchantName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTerminalNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCountryCode;
    }
}

