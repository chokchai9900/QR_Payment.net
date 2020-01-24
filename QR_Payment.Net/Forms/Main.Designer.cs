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
            this.SuspendLayout();
            // 
            // GotoBillbutton
            // 
            this.GotoBillbutton.Location = new System.Drawing.Point(99, 115);
            this.GotoBillbutton.Name = "GotoBillbutton";
            this.GotoBillbutton.Size = new System.Drawing.Size(193, 79);
            this.GotoBillbutton.TabIndex = 0;
            this.GotoBillbutton.Text = "Encode QR Payment";
            this.GotoBillbutton.UseVisualStyleBackColor = true;
            this.GotoBillbutton.Click += new System.EventHandler(this.GotoBillbutton_Click);
            // 
            // GoToGenbutton
            // 
            this.GoToGenbutton.Location = new System.Drawing.Point(99, 218);
            this.GoToGenbutton.Name = "GoToGenbutton";
            this.GoToGenbutton.Size = new System.Drawing.Size(193, 79);
            this.GoToGenbutton.TabIndex = 1;
            this.GoToGenbutton.Text = "Decode QR Payment";
            this.GoToGenbutton.UseVisualStyleBackColor = true;
            this.GoToGenbutton.Click += new System.EventHandler(this.GoToGenbutton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 454);
            this.Controls.Add(this.GoToGenbutton);
            this.Controls.Add(this.GotoBillbutton);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GotoBillbutton;
        private System.Windows.Forms.Button GoToGenbutton;
    }
}