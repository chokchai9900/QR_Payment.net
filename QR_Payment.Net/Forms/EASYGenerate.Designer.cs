namespace QR_Payment.Net.Forms
{
    partial class EASYGenerate
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
            this.ID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtRef2 = new System.Windows.Forms.TextBox();
            this.txtRef1 = new System.Windows.Forms.TextBox();
            this.QRBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.QRBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(16, 439);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(0, 13);
            this.ID.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(563, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Red;
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(533, 189);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(134, 43);
            this.btnGenerate.TabIndex = 34;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(434, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Ref2";
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(436, 144);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(53, 16);
            this.Amount.TabIndex = 30;
            this.Amount.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(434, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Ref1";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(497, 144);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(246, 20);
            this.txtAmount.TabIndex = 22;
            // 
            // txtRef2
            // 
            this.txtRef2.Location = new System.Drawing.Point(497, 117);
            this.txtRef2.Name = "txtRef2";
            this.txtRef2.Size = new System.Drawing.Size(246, 20);
            this.txtRef2.TabIndex = 21;
            // 
            // txtRef1
            // 
            this.txtRef1.Location = new System.Drawing.Point(497, 88);
            this.txtRef1.Name = "txtRef1";
            this.txtRef1.Size = new System.Drawing.Size(246, 20);
            this.txtRef1.TabIndex = 20;
            // 
            // QRBox
            // 
            this.QRBox.BackColor = System.Drawing.Color.White;
            this.QRBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.QRBox.Location = new System.Drawing.Point(16, -2);
            this.QRBox.Name = "QRBox";
            this.QRBox.Size = new System.Drawing.Size(400, 400);
            this.QRBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QRBox.TabIndex = 18;
            this.QRBox.TabStop = false;
            // 
            // EASYGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtRef2);
            this.Controls.Add(this.txtRef1);
            this.Controls.Add(this.QRBox);
            this.Name = "EASYGenerate";
            this.Text = "EASYGenerate";
            ((System.ComponentModel.ISupportInitialize)(this.QRBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtRef2;
        private System.Windows.Forms.TextBox txtRef1;
        private System.Windows.Forms.PictureBox QRBox;
    }
}