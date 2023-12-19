namespace ModernRealEstate
{
    partial class PersonInfoForm
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
            PersonalInfoBox = new GroupBox();
            lblCountry = new Label();
            groupBox2 = new GroupBox();
            checkBoxIncome = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            SellerGBox = new GroupBox();
            lblCompanyNameInfo = new Label();
            lblCompanyName = new Label();
            textBoxCompanyName = new TextBox();
            lblMovingOut = new Label();
            dtpMovingOut = new DateTimePicker();
            cmbCountry = new ComboBox();
            groupBox1 = new GroupBox();
            label5 = new Label();
            labelCompanyLessor = new Label();
            textBoxLessorCompany = new TextBox();
            lblStreet = new Label();
            textBoxCity = new TextBox();
            lblRequiredFields = new Label();
            lblZip = new Label();
            AddPerson = new Button();
            textBoxZip = new TextBox();
            textBoxBank = new TextBox();
            lblCity = new Label();
            lblBank = new Label();
            textBoxStreet = new TextBox();
            textBoxEmail = new TextBox();
            lblBuyerCountry = new Label();
            lblFirstName = new Label();
            textBoxPhoneNbr = new TextBox();
            lblLastName = new Label();
            textBoxLastName = new TextBox();
            lblPhoneNbr = new Label();
            textBoxFirstName = new TextBox();
            lblEmail = new Label();
            BuyerGBox = new GroupBox();
            checkBoxLoanPromise = new CheckBox();
            cmbPersonType = new ComboBox();
            lblSellerBuyer = new Label();
            PersonalInfoBox.SuspendLayout();
            groupBox2.SuspendLayout();
            SellerGBox.SuspendLayout();
            groupBox1.SuspendLayout();
            BuyerGBox.SuspendLayout();
            SuspendLayout();
            // 
            // PersonalInfoBox
            // 
            PersonalInfoBox.Controls.Add(lblCountry);
            PersonalInfoBox.Controls.Add(groupBox2);
            PersonalInfoBox.Controls.Add(label2);
            PersonalInfoBox.Controls.Add(label1);
            PersonalInfoBox.Controls.Add(SellerGBox);
            PersonalInfoBox.Controls.Add(cmbCountry);
            PersonalInfoBox.Controls.Add(groupBox1);
            PersonalInfoBox.Controls.Add(lblStreet);
            PersonalInfoBox.Controls.Add(textBoxCity);
            PersonalInfoBox.Controls.Add(lblRequiredFields);
            PersonalInfoBox.Controls.Add(lblZip);
            PersonalInfoBox.Controls.Add(AddPerson);
            PersonalInfoBox.Controls.Add(textBoxZip);
            PersonalInfoBox.Controls.Add(textBoxBank);
            PersonalInfoBox.Controls.Add(lblCity);
            PersonalInfoBox.Controls.Add(lblBank);
            PersonalInfoBox.Controls.Add(textBoxStreet);
            PersonalInfoBox.Controls.Add(textBoxEmail);
            PersonalInfoBox.Controls.Add(lblBuyerCountry);
            PersonalInfoBox.Controls.Add(lblFirstName);
            PersonalInfoBox.Controls.Add(textBoxPhoneNbr);
            PersonalInfoBox.Controls.Add(lblLastName);
            PersonalInfoBox.Controls.Add(textBoxLastName);
            PersonalInfoBox.Controls.Add(lblPhoneNbr);
            PersonalInfoBox.Controls.Add(textBoxFirstName);
            PersonalInfoBox.Controls.Add(lblEmail);
            PersonalInfoBox.Controls.Add(BuyerGBox);
            PersonalInfoBox.Controls.Add(cmbPersonType);
            PersonalInfoBox.Controls.Add(lblSellerBuyer);
            PersonalInfoBox.Location = new Point(12, 11);
            PersonalInfoBox.Margin = new Padding(3, 2, 3, 2);
            PersonalInfoBox.Name = "PersonalInfoBox";
            PersonalInfoBox.Padding = new Padding(3, 2, 3, 2);
            PersonalInfoBox.Size = new Size(844, 639);
            PersonalInfoBox.TabIndex = 1;
            PersonalInfoBox.TabStop = false;
            PersonalInfoBox.Text = "Personal info";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblCountry.Location = new Point(7, 510);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(91, 27);
            lblCountry.TabIndex = 29;
            lblCountry.Text = "Country";
            lblCountry.UseMnemonic = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBoxIncome);
            groupBox2.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(449, 467);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(375, 84);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tenant";
            // 
            // checkBoxIncome
            // 
            checkBoxIncome.AutoSize = true;
            checkBoxIncome.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxIncome.Location = new Point(6, 43);
            checkBoxIncome.Name = "checkBoxIncome";
            checkBoxIncome.Size = new Size(223, 31);
            checkBoxIncome.TabIndex = 13;
            checkBoxIncome.Text = "Approved income*";
            checkBoxIncome.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(92, 354);
            label2.Name = "label2";
            label2.Size = new Size(298, 27);
            label2.TabIndex = 27;
            label2.Text = "- for buyer or lessor or tenant*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 8.5F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(6, 352);
            label1.Name = "label1";
            label1.Size = new Size(95, 28);
            label1.TabIndex = 26;
            label1.Text = "Address";
            // 
            // SellerGBox
            // 
            SellerGBox.Controls.Add(lblCompanyNameInfo);
            SellerGBox.Controls.Add(lblCompanyName);
            SellerGBox.Controls.Add(textBoxCompanyName);
            SellerGBox.Controls.Add(lblMovingOut);
            SellerGBox.Controls.Add(dtpMovingOut);
            SellerGBox.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SellerGBox.Location = new Point(449, 45);
            SellerGBox.Name = "SellerGBox";
            SellerGBox.Size = new Size(375, 207);
            SellerGBox.TabIndex = 24;
            SellerGBox.TabStop = false;
            SellerGBox.Text = "Seller";
            // 
            // lblCompanyNameInfo
            // 
            lblCompanyNameInfo.AutoSize = true;
            lblCompanyNameInfo.Font = new Font("Constantia", 7.875F, FontStyle.Italic, GraphicsUnit.Point);
            lblCompanyNameInfo.Location = new Point(13, 148);
            lblCompanyNameInfo.Name = "lblCompanyNameInfo";
            lblCompanyNameInfo.Size = new Size(179, 26);
            lblCompanyNameInfo.TabIndex = 19;
            lblCompanyNameInfo.Text = "(For legal person*)";
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblCompanyName.Location = new Point(14, 124);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(163, 27);
            lblCompanyName.TabIndex = 17;
            lblCompanyName.Text = "Company name";
            // 
            // textBoxCompanyName
            // 
            textBoxCompanyName.AcceptsReturn = true;
            textBoxCompanyName.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCompanyName.Location = new Point(198, 121);
            textBoxCompanyName.Name = "textBoxCompanyName";
            textBoxCompanyName.Size = new Size(157, 34);
            textBoxCompanyName.TabIndex = 18;
            // 
            // lblMovingOut
            // 
            lblMovingOut.AutoSize = true;
            lblMovingOut.Font = new Font("Constantia", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblMovingOut.Location = new Point(14, 44);
            lblMovingOut.Name = "lblMovingOut";
            lblMovingOut.Size = new Size(198, 26);
            lblMovingOut.TabIndex = 16;
            lblMovingOut.Text = "Date of moving out*:";
            // 
            // dtpMovingOut
            // 
            dtpMovingOut.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpMovingOut.Location = new Point(14, 73);
            dtpMovingOut.Name = "dtpMovingOut";
            dtpMovingOut.Size = new Size(341, 34);
            dtpMovingOut.TabIndex = 14;
            // 
            // cmbCountry
            // 
            cmbCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCountry.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Location = new Point(234, 507);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(183, 34);
            cmbCountry.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(labelCompanyLessor);
            groupBox1.Controls.Add(textBoxLessorCompany);
            groupBox1.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(449, 258);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(375, 84);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lessor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Constantia", 7.875F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(0, 228);
            label5.Name = "label5";
            label5.Size = new Size(0, 26);
            label5.TabIndex = 22;
            // 
            // labelCompanyLessor
            // 
            labelCompanyLessor.AutoSize = true;
            labelCompanyLessor.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelCompanyLessor.Location = new Point(14, 46);
            labelCompanyLessor.Name = "labelCompanyLessor";
            labelCompanyLessor.Size = new Size(173, 27);
            labelCompanyLessor.TabIndex = 20;
            labelCompanyLessor.Text = "Company name*";
            // 
            // textBoxLessorCompany
            // 
            textBoxLessorCompany.AcceptsReturn = true;
            textBoxLessorCompany.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLessorCompany.Location = new Point(195, 43);
            textBoxLessorCompany.Name = "textBoxLessorCompany";
            textBoxLessorCompany.Size = new Size(166, 34);
            textBoxLessorCompany.TabIndex = 21;
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblStreet.Location = new Point(8, 392);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(69, 27);
            lblStreet.TabIndex = 0;
            lblStreet.Text = "Street";
            // 
            // textBoxCity
            // 
            textBoxCity.AcceptsReturn = true;
            textBoxCity.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCity.Location = new Point(234, 467);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(183, 34);
            textBoxCity.TabIndex = 9;
            // 
            // lblRequiredFields
            // 
            lblRequiredFields.AutoSize = true;
            lblRequiredFields.Font = new Font("Constantia", 7.875F, FontStyle.Italic, GraphicsUnit.Point);
            lblRequiredFields.Location = new Point(7, 605);
            lblRequiredFields.Name = "lblRequiredFields";
            lblRequiredFields.Size = new Size(152, 26);
            lblRequiredFields.TabIndex = 24;
            lblRequiredFields.Text = "Required fields*";
            // 
            // lblZip
            // 
            lblZip.AutoSize = true;
            lblZip.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblZip.Location = new Point(7, 432);
            lblZip.Name = "lblZip";
            lblZip.Size = new Size(97, 27);
            lblZip.TabIndex = 1;
            lblZip.Text = "Zip Code";
            // 
            // AddPerson
            // 
            AddPerson.Font = new Font("Constantia", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            AddPerson.Location = new Point(705, 597);
            AddPerson.Name = "AddPerson";
            AddPerson.Size = new Size(119, 37);
            AddPerson.TabIndex = 17;
            AddPerson.Text = "Add";
            AddPerson.UseVisualStyleBackColor = true;
            AddPerson.Click += AddPerson_Click;
            // 
            // textBoxZip
            // 
            textBoxZip.AcceptsReturn = true;
            textBoxZip.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxZip.Location = new Point(234, 429);
            textBoxZip.Name = "textBoxZip";
            textBoxZip.Size = new Size(183, 34);
            textBoxZip.TabIndex = 8;
            // 
            // textBoxBank
            // 
            textBoxBank.AcceptsReturn = true;
            textBoxBank.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBank.Location = new Point(234, 287);
            textBoxBank.Name = "textBoxBank";
            textBoxBank.Size = new Size(183, 34);
            textBoxBank.TabIndex = 23;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblCity.Location = new Point(7, 470);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(51, 27);
            lblCity.TabIndex = 2;
            lblCity.Text = "City";
            lblCity.UseMnemonic = false;
            // 
            // lblBank
            // 
            lblBank.AutoSize = true;
            lblBank.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblBank.Location = new Point(7, 290);
            lblBank.Name = "lblBank";
            lblBank.Size = new Size(71, 27);
            lblBank.TabIndex = 22;
            lblBank.Text = "Bank*";
            lblBank.UseMnemonic = false;
            // 
            // textBoxStreet
            // 
            textBoxStreet.AcceptsReturn = true;
            textBoxStreet.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxStreet.Location = new Point(234, 389);
            textBoxStreet.Name = "textBoxStreet";
            textBoxStreet.Size = new Size(183, 34);
            textBoxStreet.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            textBoxEmail.AcceptsReturn = true;
            textBoxEmail.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(234, 222);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(183, 34);
            textBoxEmail.TabIndex = 21;
            // 
            // lblBuyerCountry
            // 
            lblBuyerCountry.AutoSize = true;
            lblBuyerCountry.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblBuyerCountry.Location = new Point(7, 510);
            lblBuyerCountry.Name = "lblBuyerCountry";
            lblBuyerCountry.Size = new Size(0, 27);
            lblBuyerCountry.TabIndex = 3;
            lblBuyerCountry.UseMnemonic = false;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstName.Location = new Point(7, 107);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(124, 27);
            lblFirstName.TabIndex = 14;
            lblFirstName.Text = "First name*";
            // 
            // textBoxPhoneNbr
            // 
            textBoxPhoneNbr.AcceptsReturn = true;
            textBoxPhoneNbr.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPhoneNbr.Location = new Point(234, 182);
            textBoxPhoneNbr.Name = "textBoxPhoneNbr";
            textBoxPhoneNbr.Size = new Size(183, 34);
            textBoxPhoneNbr.TabIndex = 20;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastName.Location = new Point(6, 147);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(121, 27);
            lblLastName.TabIndex = 15;
            lblLastName.Text = "Last name*";
            // 
            // textBoxLastName
            // 
            textBoxLastName.AcceptsReturn = true;
            textBoxLastName.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLastName.Location = new Point(234, 144);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(183, 34);
            textBoxLastName.TabIndex = 19;
            // 
            // lblPhoneNbr
            // 
            lblPhoneNbr.AutoSize = true;
            lblPhoneNbr.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhoneNbr.Location = new Point(6, 185);
            lblPhoneNbr.Name = "lblPhoneNbr";
            lblPhoneNbr.Size = new Size(165, 27);
            lblPhoneNbr.TabIndex = 16;
            lblPhoneNbr.Text = "Phone number*";
            lblPhoneNbr.UseMnemonic = false;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.AcceptsReturn = true;
            textBoxFirstName.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFirstName.Location = new Point(234, 104);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(183, 34);
            textBoxFirstName.TabIndex = 18;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(6, 225);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(154, 27);
            lblEmail.TabIndex = 17;
            lblEmail.Text = "Email address*";
            lblEmail.UseMnemonic = false;
            // 
            // BuyerGBox
            // 
            BuyerGBox.Controls.Add(checkBoxLoanPromise);
            BuyerGBox.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BuyerGBox.Location = new Point(449, 366);
            BuyerGBox.Name = "BuyerGBox";
            BuyerGBox.Size = new Size(375, 84);
            BuyerGBox.TabIndex = 13;
            BuyerGBox.TabStop = false;
            BuyerGBox.Text = "Buyer";
            // 
            // checkBoxLoanPromise
            // 
            checkBoxLoanPromise.AutoSize = true;
            checkBoxLoanPromise.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxLoanPromise.Location = new Point(6, 43);
            checkBoxLoanPromise.Name = "checkBoxLoanPromise";
            checkBoxLoanPromise.Size = new Size(185, 31);
            checkBoxLoanPromise.TabIndex = 13;
            checkBoxLoanPromise.Text = "Loan promise*";
            checkBoxLoanPromise.UseVisualStyleBackColor = true;
            // 
            // cmbPersonType
            // 
            cmbPersonType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPersonType.Enabled = false;
            cmbPersonType.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbPersonType.FormattingEnabled = true;
            cmbPersonType.Location = new Point(234, 45);
            cmbPersonType.Name = "cmbPersonType";
            cmbPersonType.Size = new Size(183, 34);
            cmbPersonType.TabIndex = 6;
            // 
            // lblSellerBuyer
            // 
            lblSellerBuyer.AutoSize = true;
            lblSellerBuyer.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblSellerBuyer.Location = new Point(6, 48);
            lblSellerBuyer.Name = "lblSellerBuyer";
            lblSellerBuyer.Size = new Size(163, 27);
            lblSellerBuyer.TabIndex = 4;
            lblSellerBuyer.Text = "Type of person*";
            // 
            // PersonInfoForm
            // 
            AutoScaleDimensions = new SizeF(18F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 661);
            Controls.Add(PersonalInfoBox);
            Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "PersonInfoForm";
            Text = "PersonInfoForm";
            PersonalInfoBox.ResumeLayout(false);
            PersonalInfoBox.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            SellerGBox.ResumeLayout(false);
            SellerGBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            BuyerGBox.ResumeLayout(false);
            BuyerGBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox PersonalInfoBox;
        private ComboBox cmbCountry;
        private TextBox textBoxCity;
        private TextBox textBoxZip;
        private TextBox textBoxStreet;
        private ComboBox cmbPersonType;
        private Label lblSellerBuyer;
        private Label lblBuyerCountry;
        private Label lblCity;
        private Label lblZip;
        private Label lblStreet;
        private GroupBox BuyerGBox;
        private CheckBox checkBoxLoanPromise;
        private Label lblFirstName;
        private TextBox textBoxPhoneNbr;
        private Label lblLastName;
        private TextBox textBoxLastName;
        private Label lblPhoneNbr;
        private TextBox textBoxFirstName;
        private Label lblEmail;
        private TextBox textBoxEmail;
        private GroupBox SellerGBox;
        private DateTimePicker dtpMovingOut;
        private TextBox textBoxBank;
        private Label lblBank;
        private Label lblMovingOut;
        private Button AddPerson;
        private Label lblCompanyName;
        private TextBox textBoxCompanyName;
        private Label lblRequiredFields;
        private Label lblCompanyNameInfo;
        private GroupBox groupBox1;
        private Label label5;
        private Label labelCompanyLessor;
        private TextBox textBoxLessorCompany;
        private Label label1;
        private GroupBox groupBox2;
        private CheckBox checkBoxIncome;
        private Label label2;
        private Label lblCountry;
    }
}