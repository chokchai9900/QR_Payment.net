﻿namespace QR_Payment.Net
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
            this.QRBox = new System.Windows.Forms.PictureBox();
            this.Amount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.copyClipboard_button = new System.Windows.Forms.Button();
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
            this.cbUse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(442, 217);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(65, 20);
            this.Amount.TabIndex = 4;
            this.Amount.Text = "Amount";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(513, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(12, 428);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(0, 13);
            this.ID.TabIndex = 8;
            // 
            // copyClipboard_button
            // 
            this.copyClipboard_button.Location = new System.Drawing.Point(647, 365);
            this.copyClipboard_button.Name = "copyClipboard_button";
            this.copyClipboard_button.Size = new System.Drawing.Size(112, 23);
            this.copyClipboard_button.TabIndex = 10;
            this.copyClipboard_button.Text = "Copy to clipboard";
            this.copyClipboard_button.UseVisualStyleBackColor = true;
            this.copyClipboard_button.Click += new System.EventHandler(this.copyClipboard_button_Click);
            // 
            // txtTaxID
            // 
            this.txtTaxID.Location = new System.Drawing.Point(513, 78);
            this.txtTaxID.Name = "txtTaxID";
            this.txtTaxID.Size = new System.Drawing.Size(246, 20);
            this.txtTaxID.TabIndex = 1;
            // 
            // txtSuffix
            // 
            this.txtSuffix.Location = new System.Drawing.Point(513, 114);
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Size = new System.Drawing.Size(246, 20);
            this.txtSuffix.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(447, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "TaxID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(449, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Suffix";
            // 
            // txtRef1
            // 
            this.txtRef1.Location = new System.Drawing.Point(513, 146);
            this.txtRef1.Name = "txtRef1";
            this.txtRef1.Size = new System.Drawing.Size(246, 20);
            this.txtRef1.TabIndex = 1;
            // 
            // txtRef2
            // 
            this.txtRef2.Location = new System.Drawing.Point(513, 182);
            this.txtRef2.Name = "txtRef2";
            this.txtRef2.Size = new System.Drawing.Size(246, 20);
            this.txtRef2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(447, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ref1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(447, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ref2";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(559, 304);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(112, 37);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.generate_Btn_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(513, 217);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(246, 20);
            this.txtAmount.TabIndex = 1;
            // 
            // cbUse
            // 
            this.cbUse.FormattingEnabled = true;
            this.cbUse.Items.AddRange(new object[] {
            "single",
            "multi"});
            this.cbUse.Location = new System.Drawing.Point(513, 254);
            this.cbUse.Name = "cbUse";
            this.cbUse.Size = new System.Drawing.Size(246, 21);
            this.cbUse.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "use";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.cbUse);
            this.Controls.Add(this.copyClipboard_button);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtRef2);
            this.Controls.Add(this.txtRef1);
            this.Controls.Add(this.txtSuffix);
            this.Controls.Add(this.txtTaxID);
            this.Controls.Add(this.QRBox);
            this.Name = "Form1";
            this.Text = "PromptPayQR";
            ((System.ComponentModel.ISupportInitialize)(this.QRBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox QRBox;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button copyClipboard_button;
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
        private System.Windows.Forms.ComboBox cbUse;
        private System.Windows.Forms.Label label1;
    }
}
