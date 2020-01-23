namespace QR_Payment.Net
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
            this.ID_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.generate_Btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.amount_textbox = new System.Windows.Forms.NumericUpDown();
            this.ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.copyClipboard_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QRBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount_textbox)).BeginInit();
            this.SuspendLayout();
            // 
            // QRBox
            // 
            this.QRBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.QRBox.Location = new System.Drawing.Point(12, 12);
            this.QRBox.Name = "QRBox";
            this.QRBox.Size = new System.Drawing.Size(400, 400);
            this.QRBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QRBox.TabIndex = 0;
            this.QRBox.TabStop = false;
            // 
            // ID_textBox
            // 
            this.ID_textBox.Location = new System.Drawing.Point(601, 58);
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.Size = new System.Drawing.Size(246, 20);
            this.ID_textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID / Phone";
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(535, 87);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(43, 13);
            this.Amount.TabIndex = 4;
            this.Amount.Text = "Amount";
            // 
            // generate_Btn
            // 
            this.generate_Btn.Location = new System.Drawing.Point(772, 389);
            this.generate_Btn.Name = "generate_Btn";
            this.generate_Btn.Size = new System.Drawing.Size(75, 23);
            this.generate_Btn.TabIndex = 5;
            this.generate_Btn.Text = "Generate";
            this.generate_Btn.UseVisualStyleBackColor = true;
            this.generate_Btn.Click += new System.EventHandler(this.generate_Btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // amount_textbox
            // 
            this.amount_textbox.Location = new System.Drawing.Point(601, 84);
            this.amount_textbox.Name = "amount_textbox";
            this.amount_textbox.Size = new System.Drawing.Size(246, 20);
            this.amount_textbox.TabIndex = 7;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(505, 188);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(0, 13);
            this.ID.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "QR String : ";
            // 
            // copyClipboard_button
            // 
            this.copyClipboard_button.Location = new System.Drawing.Point(668, 311);
            this.copyClipboard_button.Name = "copyClipboard_button";
            this.copyClipboard_button.Size = new System.Drawing.Size(112, 23);
            this.copyClipboard_button.TabIndex = 10;
            this.copyClipboard_button.Text = "Copy to clipboard";
            this.copyClipboard_button.UseVisualStyleBackColor = true;
            this.copyClipboard_button.Click += new System.EventHandler(this.copyClipboard_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 450);
            this.Controls.Add(this.copyClipboard_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.amount_textbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.generate_Btn);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID_textBox);
            this.Controls.Add(this.QRBox);
            this.Name = "Form1";
            this.Text = "PromptPayQR";
            ((System.ComponentModel.ISupportInitialize)(this.QRBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount_textbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox QRBox;
        private System.Windows.Forms.TextBox ID_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Button generate_Btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown amount_textbox;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button copyClipboard_button;
    }
}

