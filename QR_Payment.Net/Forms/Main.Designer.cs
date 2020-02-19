namespace QR_Payment.Net.Forms
{
    partial class Main
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
            this.GotoBillbutton = new System.Windows.Forms.Button();
            this.GoToGenbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GotoBillbutton
            // 
            this.GotoBillbutton.Location = new System.Drawing.Point(102, 44);
            this.GotoBillbutton.Name = "GotoBillbutton";
            this.GotoBillbutton.Size = new System.Drawing.Size(193, 79);
            this.GotoBillbutton.TabIndex = 0;
            this.GotoBillbutton.Text = "Decode QR Payment";
            this.GotoBillbutton.UseVisualStyleBackColor = true;
            this.GotoBillbutton.Click += new System.EventHandler(this.GotoBillbutton_Click);
            // 
            // GoToGenbutton
            // 
            this.GoToGenbutton.Location = new System.Drawing.Point(102, 129);
            this.GoToGenbutton.Name = "GoToGenbutton";
            this.GoToGenbutton.Size = new System.Drawing.Size(193, 79);
            this.GoToGenbutton.TabIndex = 1;
            this.GoToGenbutton.Text = "Encode QR Payment";
            this.GoToGenbutton.UseVisualStyleBackColor = true;
            this.GoToGenbutton.Click += new System.EventHandler(this.GoToGenbutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 79);
            this.button1.TabIndex = 2;
            this.button1.Text = "EASY QR Payment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 454);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GoToGenbutton);
            this.Controls.Add(this.GotoBillbutton);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GotoBillbutton;
        private System.Windows.Forms.Button GoToGenbutton;
        private System.Windows.Forms.Button button1;
    }
}