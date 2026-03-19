namespace ServisniProtokolCv
{
    partial class ProtocolForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            basicInfo = new GroupBox();
            editBasicInfoBtn = new Button();
            measureDateValue = new Label();
            protocolNumberValue = new Label();
            measureDateLabel = new Label();
            protocolNumberLabel = new Label();
            groupBoxCustomer = new GroupBox();
            groupBoxDevice = new GroupBox();
            labelCustomerName = new Label();
            labelCustomerNameValue = new Label();
            labelAddress = new Label();
            labelAddressValue = new Label();
            labelPostalCode = new Label();
            labelPostalCodeValue = new Label();
            labelICO = new Label();
            labelIcValue = new Label();
            editCustomerBtn = new Button();
            basicInfo.SuspendLayout();
            groupBoxCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // basicInfo
            // 
            basicInfo.Controls.Add(editBasicInfoBtn);
            basicInfo.Controls.Add(measureDateValue);
            basicInfo.Controls.Add(protocolNumberValue);
            basicInfo.Controls.Add(measureDateLabel);
            basicInfo.Controls.Add(protocolNumberLabel);
            basicInfo.Location = new Point(12, 12);
            basicInfo.Name = "basicInfo";
            basicInfo.Size = new Size(642, 94);
            basicInfo.TabIndex = 0;
            basicInfo.TabStop = false;
            basicInfo.Text = "Základní informace";
            // 
            // editBasicInfoBtn
            // 
            editBasicInfoBtn.Location = new Point(553, 22);
            editBasicInfoBtn.Name = "editBasicInfoBtn";
            editBasicInfoBtn.Size = new Size(83, 66);
            editBasicInfoBtn.TabIndex = 4;
            editBasicInfoBtn.Text = "Upravit";
            editBasicInfoBtn.UseVisualStyleBackColor = true;
            editBasicInfoBtn.Click += editBasicInfoBtn_Click;
            // 
            // measureDateValue
            // 
            measureDateValue.AutoSize = true;
            measureDateValue.Location = new Point(114, 59);
            measureDateValue.Name = "measureDateValue";
            measureDateValue.Size = new Size(12, 15);
            measureDateValue.TabIndex = 3;
            measureDateValue.Text = "?";
            // 
            // protocolNumberValue
            // 
            protocolNumberValue.AutoSize = true;
            protocolNumberValue.Location = new Point(114, 30);
            protocolNumberValue.Name = "protocolNumberValue";
            protocolNumberValue.Size = new Size(12, 15);
            protocolNumberValue.TabIndex = 2;
            protocolNumberValue.Text = "?";
            // 
            // measureDateLabel
            // 
            measureDateLabel.AutoSize = true;
            measureDateLabel.Location = new Point(17, 59);
            measureDateLabel.Name = "measureDateLabel";
            measureDateLabel.Size = new Size(86, 15);
            measureDateLabel.TabIndex = 1;
            measureDateLabel.Text = "Datum měření:";
            // 
            // protocolNumberLabel
            // 
            protocolNumberLabel.AutoSize = true;
            protocolNumberLabel.Location = new Point(17, 30);
            protocolNumberLabel.Name = "protocolNumberLabel";
            protocolNumberLabel.Size = new Size(91, 15);
            protocolNumberLabel.TabIndex = 0;
            protocolNumberLabel.Text = "Číslo protokolu:";
            // 
            // groupBoxCustomer
            // 
            groupBoxCustomer.Controls.Add(editCustomerBtn);
            groupBoxCustomer.Controls.Add(labelIcValue);
            groupBoxCustomer.Controls.Add(labelICO);
            groupBoxCustomer.Controls.Add(labelPostalCodeValue);
            groupBoxCustomer.Controls.Add(labelPostalCode);
            groupBoxCustomer.Controls.Add(labelAddressValue);
            groupBoxCustomer.Controls.Add(labelAddress);
            groupBoxCustomer.Controls.Add(labelCustomerNameValue);
            groupBoxCustomer.Controls.Add(labelCustomerName);
            groupBoxCustomer.Location = new Point(12, 122);
            groupBoxCustomer.Name = "groupBoxCustomer";
            groupBoxCustomer.Size = new Size(295, 161);
            groupBoxCustomer.TabIndex = 1;
            groupBoxCustomer.TabStop = false;
            groupBoxCustomer.Text = "Zákazník";
            // 
            // groupBoxDevice
            // 
            groupBoxDevice.Location = new Point(359, 122);
            groupBoxDevice.Name = "groupBoxDevice";
            groupBoxDevice.Size = new Size(295, 161);
            groupBoxDevice.TabIndex = 1;
            groupBoxDevice.TabStop = false;
            groupBoxDevice.Text = "Zařízení";
            // 
            // labelCustomerName
            // 
            labelCustomerName.AutoSize = true;
            labelCustomerName.Location = new Point(17, 29);
            labelCustomerName.Name = "labelCustomerName";
            labelCustomerName.Size = new Size(42, 15);
            labelCustomerName.TabIndex = 0;
            labelCustomerName.Text = "Název:";
            // 
            // labelCustomerNameValue
            // 
            labelCustomerNameValue.AutoSize = true;
            labelCustomerNameValue.Location = new Point(70, 29);
            labelCustomerNameValue.Name = "labelCustomerNameValue";
            labelCustomerNameValue.Size = new Size(12, 15);
            labelCustomerNameValue.TabIndex = 0;
            labelCustomerNameValue.Text = "?";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(17, 56);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(46, 15);
            labelAddress.TabIndex = 0;
            labelAddress.Text = "Adresa:";
            // 
            // labelAddressValue
            // 
            labelAddressValue.AutoSize = true;
            labelAddressValue.Location = new Point(70, 56);
            labelAddressValue.Name = "labelAddressValue";
            labelAddressValue.Size = new Size(12, 15);
            labelAddressValue.TabIndex = 0;
            labelAddressValue.Text = "?";
            // 
            // labelPostalCode
            // 
            labelPostalCode.AutoSize = true;
            labelPostalCode.Location = new Point(17, 82);
            labelPostalCode.Name = "labelPostalCode";
            labelPostalCode.Size = new Size(31, 15);
            labelPostalCode.TabIndex = 0;
            labelPostalCode.Text = "PSČ:";
            // 
            // labelPostalCodeValue
            // 
            labelPostalCodeValue.AutoSize = true;
            labelPostalCodeValue.Location = new Point(70, 82);
            labelPostalCodeValue.Name = "labelPostalCodeValue";
            labelPostalCodeValue.Size = new Size(12, 15);
            labelPostalCodeValue.TabIndex = 0;
            labelPostalCodeValue.Text = "?";
            // 
            // labelICO
            // 
            labelICO.AutoSize = true;
            labelICO.Location = new Point(17, 110);
            labelICO.Name = "labelICO";
            labelICO.Size = new Size(21, 15);
            labelICO.TabIndex = 0;
            labelICO.Text = "IČ:";
            // 
            // labelIcValue
            // 
            labelIcValue.AutoSize = true;
            labelIcValue.Location = new Point(70, 110);
            labelIcValue.Name = "labelIcValue";
            labelIcValue.Size = new Size(12, 15);
            labelIcValue.TabIndex = 0;
            labelIcValue.Text = "?";
            // 
            // editCustomerBtn
            // 
            editCustomerBtn.Location = new Point(214, 132);
            editCustomerBtn.Name = "editCustomerBtn";
            editCustomerBtn.Size = new Size(75, 23);
            editCustomerBtn.TabIndex = 1;
            editCustomerBtn.Text = "Upravit";
            editCustomerBtn.UseVisualStyleBackColor = true;
            editCustomerBtn.Click += editCustomerBtn_Click;
            // 
            // ProtocolForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 790);
            Controls.Add(groupBoxDevice);
            Controls.Add(groupBoxCustomer);
            Controls.Add(basicInfo);
            Name = "ProtocolForm";
            Text = "Servisní protokol";
            basicInfo.ResumeLayout(false);
            basicInfo.PerformLayout();
            groupBoxCustomer.ResumeLayout(false);
            groupBoxCustomer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox basicInfo;
        private Button editBasicInfoBtn;
        private Label measureDateValue;
        private Label protocolNumberValue;
        private Label measureDateLabel;
        private Label protocolNumberLabel;
        private GroupBox groupBoxCustomer;
        private Button editCustomerBtn;
        private Label labelIcValue;
        private Label labelICO;
        private Label labelPostalCodeValue;
        private Label labelPostalCode;
        private Label labelAddressValue;
        private Label labelAddress;
        private Label labelCustomerNameValue;
        private Label labelCustomerName;
        private GroupBox groupBoxDevice;
    }
}
