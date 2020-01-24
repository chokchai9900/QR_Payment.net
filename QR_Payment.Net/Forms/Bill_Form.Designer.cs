namespace QR_Payment.Net
{
    partial class Bill_Form
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
            this.SelectQRImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CRC_button = new System.Windows.Forms.Button();
            this.Ref3_button = new System.Windows.Forms.Button();
            this.MerchantName_button = new System.Windows.Forms.Button();
            this.CountryCode_button = new System.Windows.Forms.Button();
            this.Amount_button = new System.Windows.Forms.Button();
            this.CurrencyID_button = new System.Windows.Forms.Button();
            this.Ref2_button = new System.Windows.Forms.Button();
            this.Ref1_button = new System.Windows.Forms.Button();
            this.BillerID_button = new System.Windows.Forms.Button();
            this.AppID_button = new System.Windows.Forms.Button();
            this.QRFormat_button = new System.Windows.Forms.Button();
            this.VersionQR_button = new System.Windows.Forms.Button();
            this.CheckSum = new System.Windows.Forms.TextBox();
            this.Ref3 = new System.Windows.Forms.TextBox();
            this.MerchantName = new System.Windows.Forms.TextBox();
            this.CountryCode = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.TextBox();
            this.CurrencyID = new System.Windows.Forms.TextBox();
            this.Ref2 = new System.Windows.Forms.TextBox();
            this.Ref1 = new System.Windows.Forms.TextBox();
            this.BillerID = new System.Windows.Forms.TextBox();
            this.ApplicationID = new System.Windows.Forms.TextBox();
            this.QRType = new System.Windows.Forms.TextBox();
            this.QRVersion = new System.Windows.Forms.TextBox();
            this.copyClipboard_button = new System.Windows.Forms.Button();
            this.QRString = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GenerateQR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectQRImage
            // 
            this.SelectQRImage.Location = new System.Drawing.Point(12, 439);
            this.SelectQRImage.Name = "SelectQRImage";
            this.SelectQRImage.Size = new System.Drawing.Size(400, 47);
            this.SelectQRImage.TabIndex = 7;
            this.SelectQRImage.Text = "Select Image QR Code";
            this.SelectQRImage.UseVisualStyleBackColor = true;
            this.SelectQRImage.Click += new System.EventHandler(this.SelectQRImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CRC_button);
            this.panel1.Controls.Add(this.Ref3_button);
            this.panel1.Controls.Add(this.MerchantName_button);
            this.panel1.Controls.Add(this.CountryCode_button);
            this.panel1.Controls.Add(this.Amount_button);
            this.panel1.Controls.Add(this.CurrencyID_button);
            this.panel1.Controls.Add(this.Ref2_button);
            this.panel1.Controls.Add(this.Ref1_button);
            this.panel1.Controls.Add(this.BillerID_button);
            this.panel1.Controls.Add(this.AppID_button);
            this.panel1.Controls.Add(this.QRFormat_button);
            this.panel1.Controls.Add(this.VersionQR_button);
            this.panel1.Controls.Add(this.CheckSum);
            this.panel1.Controls.Add(this.Ref3);
            this.panel1.Controls.Add(this.MerchantName);
            this.panel1.Controls.Add(this.CountryCode);
            this.panel1.Controls.Add(this.Amount);
            this.panel1.Controls.Add(this.CurrencyID);
            this.panel1.Controls.Add(this.Ref2);
            this.panel1.Controls.Add(this.Ref1);
            this.panel1.Controls.Add(this.BillerID);
            this.panel1.Controls.Add(this.ApplicationID);
            this.panel1.Controls.Add(this.QRType);
            this.panel1.Controls.Add(this.QRVersion);
            this.panel1.Controls.Add(this.copyClipboard_button);
            this.panel1.Controls.Add(this.QRString);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(432, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 575);
            this.panel1.TabIndex = 6;
            // 
            // CRC_button
            // 
            this.CRC_button.Location = new System.Drawing.Point(644, 446);
            this.CRC_button.Name = "CRC_button";
            this.CRC_button.Size = new System.Drawing.Size(112, 23);
            this.CRC_button.TabIndex = 44;
            this.CRC_button.Text = "Copy to clipboard";
            this.CRC_button.UseVisualStyleBackColor = true;
            this.CRC_button.Click += new System.EventHandler(this.CRC_button_Click);
            // 
            // Ref3_button
            // 
            this.Ref3_button.Location = new System.Drawing.Point(644, 413);
            this.Ref3_button.Name = "Ref3_button";
            this.Ref3_button.Size = new System.Drawing.Size(112, 23);
            this.Ref3_button.TabIndex = 43;
            this.Ref3_button.Text = "Copy to clipboard";
            this.Ref3_button.UseVisualStyleBackColor = true;
            this.Ref3_button.Click += new System.EventHandler(this.Ref3_button_Click);
            // 
            // MerchantName_button
            // 
            this.MerchantName_button.Location = new System.Drawing.Point(644, 380);
            this.MerchantName_button.Name = "MerchantName_button";
            this.MerchantName_button.Size = new System.Drawing.Size(112, 23);
            this.MerchantName_button.TabIndex = 42;
            this.MerchantName_button.Text = "Copy to clipboard";
            this.MerchantName_button.UseVisualStyleBackColor = true;
            this.MerchantName_button.Click += new System.EventHandler(this.MerchantName_button_Click);
            // 
            // CountryCode_button
            // 
            this.CountryCode_button.Location = new System.Drawing.Point(644, 347);
            this.CountryCode_button.Name = "CountryCode_button";
            this.CountryCode_button.Size = new System.Drawing.Size(112, 23);
            this.CountryCode_button.TabIndex = 41;
            this.CountryCode_button.Text = "Copy to clipboard";
            this.CountryCode_button.UseVisualStyleBackColor = true;
            this.CountryCode_button.Click += new System.EventHandler(this.CountryCode_button_Click);
            // 
            // Amount_button
            // 
            this.Amount_button.Location = new System.Drawing.Point(644, 314);
            this.Amount_button.Name = "Amount_button";
            this.Amount_button.Size = new System.Drawing.Size(112, 23);
            this.Amount_button.TabIndex = 40;
            this.Amount_button.Text = "Copy to clipboard";
            this.Amount_button.UseVisualStyleBackColor = true;
            this.Amount_button.Click += new System.EventHandler(this.Amount_button_Click);
            // 
            // CurrencyID_button
            // 
            this.CurrencyID_button.Location = new System.Drawing.Point(644, 281);
            this.CurrencyID_button.Name = "CurrencyID_button";
            this.CurrencyID_button.Size = new System.Drawing.Size(112, 23);
            this.CurrencyID_button.TabIndex = 39;
            this.CurrencyID_button.Text = "Copy to clipboard";
            this.CurrencyID_button.UseVisualStyleBackColor = true;
            this.CurrencyID_button.Click += new System.EventHandler(this.CurrencyID_button_Click);
            // 
            // Ref2_button
            // 
            this.Ref2_button.Location = new System.Drawing.Point(644, 248);
            this.Ref2_button.Name = "Ref2_button";
            this.Ref2_button.Size = new System.Drawing.Size(112, 23);
            this.Ref2_button.TabIndex = 38;
            this.Ref2_button.Text = "Copy to clipboard";
            this.Ref2_button.UseVisualStyleBackColor = true;
            this.Ref2_button.Click += new System.EventHandler(this.Ref2_button_Click);
            // 
            // Ref1_button
            // 
            this.Ref1_button.Location = new System.Drawing.Point(644, 215);
            this.Ref1_button.Name = "Ref1_button";
            this.Ref1_button.Size = new System.Drawing.Size(112, 23);
            this.Ref1_button.TabIndex = 37;
            this.Ref1_button.Text = "Copy to clipboard";
            this.Ref1_button.UseVisualStyleBackColor = true;
            this.Ref1_button.Click += new System.EventHandler(this.Ref1_button_Click);
            // 
            // BillerID_button
            // 
            this.BillerID_button.Location = new System.Drawing.Point(644, 182);
            this.BillerID_button.Name = "BillerID_button";
            this.BillerID_button.Size = new System.Drawing.Size(112, 23);
            this.BillerID_button.TabIndex = 36;
            this.BillerID_button.Text = "Copy to clipboard";
            this.BillerID_button.UseVisualStyleBackColor = true;
            this.BillerID_button.Click += new System.EventHandler(this.BillerID_button_Click);
            // 
            // AppID_button
            // 
            this.AppID_button.Location = new System.Drawing.Point(644, 149);
            this.AppID_button.Name = "AppID_button";
            this.AppID_button.Size = new System.Drawing.Size(112, 23);
            this.AppID_button.TabIndex = 35;
            this.AppID_button.Text = "Copy to clipboard";
            this.AppID_button.UseVisualStyleBackColor = true;
            this.AppID_button.Click += new System.EventHandler(this.AppID_button_Click);
            // 
            // QRFormat_button
            // 
            this.QRFormat_button.Location = new System.Drawing.Point(644, 116);
            this.QRFormat_button.Name = "QRFormat_button";
            this.QRFormat_button.Size = new System.Drawing.Size(112, 23);
            this.QRFormat_button.TabIndex = 34;
            this.QRFormat_button.Text = "Copy to clipboard";
            this.QRFormat_button.UseVisualStyleBackColor = true;
            this.QRFormat_button.Click += new System.EventHandler(this.QRFormat_button_Click);
            // 
            // VersionQR_button
            // 
            this.VersionQR_button.Location = new System.Drawing.Point(644, 83);
            this.VersionQR_button.Name = "VersionQR_button";
            this.VersionQR_button.Size = new System.Drawing.Size(112, 23);
            this.VersionQR_button.TabIndex = 33;
            this.VersionQR_button.Text = "Copy to clipboard";
            this.VersionQR_button.UseVisualStyleBackColor = true;
            this.VersionQR_button.Click += new System.EventHandler(this.VersionQR_button_Click);
            // 
            // CheckSum
            // 
            this.CheckSum.Location = new System.Drawing.Point(149, 449);
            this.CheckSum.Name = "CheckSum";
            this.CheckSum.Size = new System.Drawing.Size(489, 20);
            this.CheckSum.TabIndex = 29;
            // 
            // Ref3
            // 
            this.Ref3.Location = new System.Drawing.Point(149, 416);
            this.Ref3.Name = "Ref3";
            this.Ref3.Size = new System.Drawing.Size(489, 20);
            this.Ref3.TabIndex = 28;
            // 
            // MerchantName
            // 
            this.MerchantName.Location = new System.Drawing.Point(149, 383);
            this.MerchantName.Name = "MerchantName";
            this.MerchantName.Size = new System.Drawing.Size(489, 20);
            this.MerchantName.TabIndex = 27;
            // 
            // CountryCode
            // 
            this.CountryCode.Location = new System.Drawing.Point(149, 350);
            this.CountryCode.Name = "CountryCode";
            this.CountryCode.Size = new System.Drawing.Size(489, 20);
            this.CountryCode.TabIndex = 26;
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(149, 317);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(489, 20);
            this.Amount.TabIndex = 25;
            // 
            // CurrencyID
            // 
            this.CurrencyID.Location = new System.Drawing.Point(149, 284);
            this.CurrencyID.Name = "CurrencyID";
            this.CurrencyID.Size = new System.Drawing.Size(489, 20);
            this.CurrencyID.TabIndex = 24;
            // 
            // Ref2
            // 
            this.Ref2.Location = new System.Drawing.Point(149, 251);
            this.Ref2.Name = "Ref2";
            this.Ref2.Size = new System.Drawing.Size(489, 20);
            this.Ref2.TabIndex = 23;
            // 
            // Ref1
            // 
            this.Ref1.Location = new System.Drawing.Point(149, 218);
            this.Ref1.Name = "Ref1";
            this.Ref1.Size = new System.Drawing.Size(489, 20);
            this.Ref1.TabIndex = 22;
            // 
            // BillerID
            // 
            this.BillerID.Location = new System.Drawing.Point(149, 185);
            this.BillerID.Name = "BillerID";
            this.BillerID.Size = new System.Drawing.Size(489, 20);
            this.BillerID.TabIndex = 21;
            // 
            // ApplicationID
            // 
            this.ApplicationID.Location = new System.Drawing.Point(149, 152);
            this.ApplicationID.Name = "ApplicationID";
            this.ApplicationID.Size = new System.Drawing.Size(489, 20);
            this.ApplicationID.TabIndex = 20;
            // 
            // QRType
            // 
            this.QRType.Location = new System.Drawing.Point(149, 119);
            this.QRType.Name = "QRType";
            this.QRType.Size = new System.Drawing.Size(489, 20);
            this.QRType.TabIndex = 19;
            // 
            // QRVersion
            // 
            this.QRVersion.Location = new System.Drawing.Point(149, 86);
            this.QRVersion.Name = "QRVersion";
            this.QRVersion.Size = new System.Drawing.Size(489, 20);
            this.QRVersion.TabIndex = 18;
            // 
            // copyClipboard_button
            // 
            this.copyClipboard_button.Location = new System.Drawing.Point(644, 18);
            this.copyClipboard_button.Name = "copyClipboard_button";
            this.copyClipboard_button.Size = new System.Drawing.Size(112, 23);
            this.copyClipboard_button.TabIndex = 17;
            this.copyClipboard_button.Text = "Copy to clipboard";
            this.copyClipboard_button.UseVisualStyleBackColor = true;
            this.copyClipboard_button.Click += new System.EventHandler(this.CopyClipboard_button_Click);
            // 
            // QRString
            // 
            this.QRString.Location = new System.Drawing.Point(94, 20);
            this.QRString.Name = "QRString";
            this.QRString.Size = new System.Drawing.Size(544, 20);
            this.QRString.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 33);
            this.label16.TabIndex = 15;
            this.label16.Text = "QR String";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 33);
            this.label15.TabIndex = 14;
            this.label15.Text = "รูปแบบของ QR";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 177);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 33);
            this.label14.TabIndex = 13;
            this.label14.Text = "Biller ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 210);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 33);
            this.label13.TabIndex = 12;
            this.label13.Text = "Reference 1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 309);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 33);
            this.label12.TabIndex = 11;
            this.label12.Text = "Amount";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 342);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 33);
            this.label11.TabIndex = 10;
            this.label11.Text = "Country Code";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 375);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 33);
            this.label10.TabIndex = 9;
            this.label10.Text = "Merchant Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 33);
            this.label9.TabIndex = 8;
            this.label9.Text = "Application ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 33);
            this.label8.TabIndex = 7;
            this.label8.Text = "Reference 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 33);
            this.label7.TabIndex = 6;
            this.label7.Text = "Currency ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "Reference 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Checksum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Version ของ QR";
            // 
            // GenerateQR
            // 
            this.GenerateQR.Location = new System.Drawing.Point(12, 492);
            this.GenerateQR.Name = "GenerateQR";
            this.GenerateQR.Size = new System.Drawing.Size(400, 47);
            this.GenerateQR.TabIndex = 8;
            this.GenerateQR.Text = "Decode QR Code";
            this.GenerateQR.UseVisualStyleBackColor = true;
            this.GenerateQR.Click += new System.EventHandler(this.GenerateQR_Click);
            // 
            // Bill_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 615);
            this.Controls.Add(this.GenerateQR);
            this.Controls.Add(this.SelectQRImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Bill_Form";
            this.Text = "Bill_Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectQRImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CRC_button;
        private System.Windows.Forms.Button Ref3_button;
        private System.Windows.Forms.Button MerchantName_button;
        private System.Windows.Forms.Button CountryCode_button;
        private System.Windows.Forms.Button Amount_button;
        private System.Windows.Forms.Button CurrencyID_button;
        private System.Windows.Forms.Button Ref2_button;
        private System.Windows.Forms.Button Ref1_button;
        private System.Windows.Forms.Button BillerID_button;
        private System.Windows.Forms.Button AppID_button;
        private System.Windows.Forms.Button QRFormat_button;
        private System.Windows.Forms.Button VersionQR_button;
        private System.Windows.Forms.TextBox CheckSum;
        private System.Windows.Forms.TextBox Ref3;
        private System.Windows.Forms.TextBox MerchantName;
        private System.Windows.Forms.TextBox CountryCode;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.TextBox CurrencyID;
        private System.Windows.Forms.TextBox Ref2;
        private System.Windows.Forms.TextBox Ref1;
        private System.Windows.Forms.TextBox BillerID;
        private System.Windows.Forms.TextBox ApplicationID;
        private System.Windows.Forms.TextBox QRType;
        private System.Windows.Forms.TextBox QRVersion;
        private System.Windows.Forms.Button copyClipboard_button;
        private System.Windows.Forms.TextBox QRString;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GenerateQR;
    }
}