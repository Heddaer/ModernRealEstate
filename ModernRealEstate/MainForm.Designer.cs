namespace ModernRealEstate
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            estateInfoBox = new GroupBox();
            lblEstateType = new Label();
            cmbEstateType = new ComboBox();
            cmbContractor = new ComboBox();
            AddSellerLessorButton = new Button();
            textBoxImageInfo = new TextBox();
            cmbCountryCategory = new ComboBox();
            addImageButton = new Button();
            textBoxArea = new TextBox();
            textBoxCity = new TextBox();
            textBoxZip = new TextBox();
            textBoxstreet = new TextBox();
            cmbContractType = new ComboBox();
            areaLabel = new Label();
            contractLabel = new Label();
            Country = new Label();
            cityLabel = new Label();
            zipCodeLabel = new Label();
            streetLabel = new Label();
            residentalBox = new GroupBox();
            checkBoxKitchenette = new CheckBox();
            checkBoxLake = new CheckBox();
            checkBoxBalcony = new CheckBox();
            checkBoxPool = new CheckBox();
            checkBoxGarage = new CheckBox();
            textBoxNbrOfRooms = new TextBox();
            roomslabel = new Label();
            changeButton = new Button();
            commercialBox = new GroupBox();
            cmbWarehouseType = new ComboBox();
            checkBoxColdRoom = new CheckBox();
            institutionalBox = new GroupBox();
            labelClassrooms = new Label();
            textBoxClassrooms = new TextBox();
            checkBoxSportsCenter = new CheckBox();
            checkBoxCafeteria = new CheckBox();
            cmbPurposeType = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lstPublishedObjects = new ListBox();
            publishedObjectsBox = new GroupBox();
            deleteButton = new Button();
            pictureBox = new PictureBox();
            showInfoBox = new GroupBox();
            infoAboutEstLabel = new Label();
            sellerLessorInfobutton = new Button();
            buyerInfoButton = new Button();
            buttonBuyerOrTenant = new Button();
            btnAddEstate = new Button();
            mnuFile = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            mnuFileNew = new ToolStripMenuItem();
            mnuFileOpen = new ToolStripMenuItem();
            mnuOpenDeserialize = new ToolStripMenuItem();
            mnuFileSave = new ToolStripMenuItem();
            mnuFileSaveAs = new ToolStripMenuItem();
            mnuFileXML = new ToolStripMenuItem();
            mnuXMLImport = new ToolStripMenuItem();
            mnuXMLExport = new ToolStripMenuItem();
            mnuFileExit = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            openFileDia1 = new OpenFileDialog();
            saveFileDia1 = new SaveFileDialog();
            estateInfoBox.SuspendLayout();
            residentalBox.SuspendLayout();
            commercialBox.SuspendLayout();
            institutionalBox.SuspendLayout();
            publishedObjectsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            showInfoBox.SuspendLayout();
            mnuFile.SuspendLayout();
            SuspendLayout();
            // 
            // estateInfoBox
            // 
            estateInfoBox.Controls.Add(lblEstateType);
            estateInfoBox.Controls.Add(cmbEstateType);
            estateInfoBox.Controls.Add(cmbContractor);
            estateInfoBox.Controls.Add(AddSellerLessorButton);
            estateInfoBox.Controls.Add(textBoxImageInfo);
            estateInfoBox.Controls.Add(cmbCountryCategory);
            estateInfoBox.Controls.Add(addImageButton);
            estateInfoBox.Controls.Add(textBoxArea);
            estateInfoBox.Controls.Add(textBoxCity);
            estateInfoBox.Controls.Add(textBoxZip);
            estateInfoBox.Controls.Add(textBoxstreet);
            estateInfoBox.Controls.Add(cmbContractType);
            estateInfoBox.Controls.Add(areaLabel);
            estateInfoBox.Controls.Add(contractLabel);
            estateInfoBox.Controls.Add(Country);
            estateInfoBox.Controls.Add(cityLabel);
            estateInfoBox.Controls.Add(zipCodeLabel);
            estateInfoBox.Controls.Add(streetLabel);
            estateInfoBox.Location = new Point(31, 56);
            estateInfoBox.Margin = new Padding(3, 2, 3, 2);
            estateInfoBox.Name = "estateInfoBox";
            estateInfoBox.Padding = new Padding(3, 2, 3, 2);
            estateInfoBox.Size = new Size(423, 425);
            estateInfoBox.TabIndex = 0;
            estateInfoBox.TabStop = false;
            estateInfoBox.Text = "Estate info";
            // 
            // lblEstateType
            // 
            lblEstateType.AutoSize = true;
            lblEstateType.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstateType.Location = new Point(15, 283);
            lblEstateType.Name = "lblEstateType";
            lblEstateType.Size = new Size(151, 27);
            lblEstateType.TabIndex = 19;
            lblEstateType.Text = " Type of estate";
            // 
            // cmbEstateType
            // 
            cmbEstateType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstateType.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbEstateType.FormattingEnabled = true;
            cmbEstateType.Location = new Point(234, 280);
            cmbEstateType.Name = "cmbEstateType";
            cmbEstateType.Size = new Size(183, 34);
            cmbEstateType.TabIndex = 18;
            cmbEstateType.SelectedIndexChanged += cmbEstateType_SelectedIndexChanged;
            // 
            // cmbContractor
            // 
            cmbContractor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbContractor.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbContractor.FormattingEnabled = true;
            cmbContractor.Location = new Point(15, 240);
            cmbContractor.Name = "cmbContractor";
            cmbContractor.Size = new Size(183, 34);
            cmbContractor.TabIndex = 17;
            // 
            // AddSellerLessorButton
            // 
            AddSellerLessorButton.Font = new Font("Constantia", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            AddSellerLessorButton.Location = new Point(234, 237);
            AddSellerLessorButton.Name = "AddSellerLessorButton";
            AddSellerLessorButton.Size = new Size(183, 37);
            AddSellerLessorButton.TabIndex = 16;
            AddSellerLessorButton.Text = "Add ";
            AddSellerLessorButton.UseVisualStyleBackColor = true;
            AddSellerLessorButton.Click += AddSellerLessorButton_Click;
            // 
            // textBoxImageInfo
            // 
            textBoxImageInfo.AcceptsReturn = true;
            textBoxImageInfo.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxImageInfo.Location = new Point(15, 384);
            textBoxImageInfo.Name = "textBoxImageInfo";
            textBoxImageInfo.Size = new Size(183, 34);
            textBoxImageInfo.TabIndex = 13;
            // 
            // cmbCountryCategory
            // 
            cmbCountryCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCountryCategory.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCountryCategory.FormattingEnabled = true;
            cmbCountryCategory.Location = new Point(234, 164);
            cmbCountryCategory.Name = "cmbCountryCategory";
            cmbCountryCategory.Size = new Size(183, 34);
            cmbCountryCategory.TabIndex = 12;
            // 
            // addImageButton
            // 
            addImageButton.Font = new Font("Constantia", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            addImageButton.Location = new Point(234, 377);
            addImageButton.Name = "addImageButton";
            addImageButton.Size = new Size(183, 43);
            addImageButton.TabIndex = 7;
            addImageButton.Text = "Add Image";
            addImageButton.UseVisualStyleBackColor = true;
            addImageButton.Click += addImageButton_Click;
            // 
            // textBoxArea
            // 
            textBoxArea.AcceptsReturn = true;
            textBoxArea.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxArea.Location = new Point(234, 325);
            textBoxArea.Name = "textBoxArea";
            textBoxArea.Size = new Size(183, 34);
            textBoxArea.TabIndex = 11;
            // 
            // textBoxCity
            // 
            textBoxCity.AcceptsReturn = true;
            textBoxCity.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCity.Location = new Point(234, 124);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(183, 34);
            textBoxCity.TabIndex = 9;
            // 
            // textBoxZip
            // 
            textBoxZip.AcceptsReturn = true;
            textBoxZip.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxZip.Location = new Point(234, 86);
            textBoxZip.Name = "textBoxZip";
            textBoxZip.Size = new Size(183, 34);
            textBoxZip.TabIndex = 8;
            // 
            // textBoxstreet
            // 
            textBoxstreet.AcceptsReturn = true;
            textBoxstreet.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxstreet.Location = new Point(234, 46);
            textBoxstreet.Name = "textBoxstreet";
            textBoxstreet.Size = new Size(183, 34);
            textBoxstreet.TabIndex = 7;
            // 
            // cmbContractType
            // 
            cmbContractType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbContractType.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbContractType.FormattingEnabled = true;
            cmbContractType.Location = new Point(234, 201);
            cmbContractType.Name = "cmbContractType";
            cmbContractType.Size = new Size(183, 34);
            cmbContractType.TabIndex = 6;
            cmbContractType.SelectedIndexChanged += cmbContractType_SelectedIndexChanged;
            // 
            // areaLabel
            // 
            areaLabel.AutoSize = true;
            areaLabel.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            areaLabel.Location = new Point(15, 328);
            areaLabel.Name = "areaLabel";
            areaLabel.Size = new Size(57, 27);
            areaLabel.TabIndex = 5;
            areaLabel.Text = "Area";
            // 
            // contractLabel
            // 
            contractLabel.AutoSize = true;
            contractLabel.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            contractLabel.Location = new Point(15, 204);
            contractLabel.Name = "contractLabel";
            contractLabel.Size = new Size(148, 27);
            contractLabel.TabIndex = 4;
            contractLabel.Text = "Contract type ";
            // 
            // Country
            // 
            Country.AutoSize = true;
            Country.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Country.Location = new Point(15, 167);
            Country.Name = "Country";
            Country.Size = new Size(91, 27);
            Country.TabIndex = 3;
            Country.Text = "Country";
            Country.UseMnemonic = false;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            cityLabel.Location = new Point(15, 127);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(51, 27);
            cityLabel.TabIndex = 2;
            cityLabel.Text = "City";
            cityLabel.UseMnemonic = false;
            // 
            // zipCodeLabel
            // 
            zipCodeLabel.AutoSize = true;
            zipCodeLabel.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            zipCodeLabel.Location = new Point(15, 89);
            zipCodeLabel.Name = "zipCodeLabel";
            zipCodeLabel.Size = new Size(97, 27);
            zipCodeLabel.TabIndex = 1;
            zipCodeLabel.Text = "Zip Code";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            streetLabel.Location = new Point(15, 49);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new Size(69, 27);
            streetLabel.TabIndex = 0;
            streetLabel.Text = "Street";
            // 
            // residentalBox
            // 
            residentalBox.Controls.Add(checkBoxKitchenette);
            residentalBox.Controls.Add(checkBoxLake);
            residentalBox.Controls.Add(checkBoxBalcony);
            residentalBox.Controls.Add(checkBoxPool);
            residentalBox.Controls.Add(checkBoxGarage);
            residentalBox.Controls.Add(textBoxNbrOfRooms);
            residentalBox.Controls.Add(roomslabel);
            residentalBox.Location = new Point(480, 73);
            residentalBox.Margin = new Padding(3, 2, 3, 2);
            residentalBox.Name = "residentalBox";
            residentalBox.Padding = new Padding(3, 2, 3, 2);
            residentalBox.Size = new Size(229, 408);
            residentalBox.TabIndex = 1;
            residentalBox.TabStop = false;
            residentalBox.Text = "Residental estate";
            // 
            // checkBoxKitchenette
            // 
            checkBoxKitchenette.AutoSize = true;
            checkBoxKitchenette.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxKitchenette.Location = new Point(6, 294);
            checkBoxKitchenette.Name = "checkBoxKitchenette";
            checkBoxKitchenette.Size = new Size(218, 31);
            checkBoxKitchenette.TabIndex = 16;
            checkBoxKitchenette.Text = "          Kitchenette";
            checkBoxKitchenette.UseVisualStyleBackColor = true;
            // 
            // checkBoxLake
            // 
            checkBoxLake.AutoSize = true;
            checkBoxLake.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxLake.Location = new Point(6, 257);
            checkBoxLake.Name = "checkBoxLake";
            checkBoxLake.Size = new Size(221, 31);
            checkBoxLake.TabIndex = 15;
            checkBoxLake.Text = "          Lake nearby";
            checkBoxLake.UseVisualStyleBackColor = true;
            // 
            // checkBoxBalcony
            // 
            checkBoxBalcony.AutoSize = true;
            checkBoxBalcony.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxBalcony.Location = new Point(6, 220);
            checkBoxBalcony.Name = "checkBoxBalcony";
            checkBoxBalcony.Size = new Size(180, 31);
            checkBoxBalcony.TabIndex = 11;
            checkBoxBalcony.Text = "          Balcony";
            checkBoxBalcony.UseVisualStyleBackColor = true;
            // 
            // checkBoxPool
            // 
            checkBoxPool.AutoSize = true;
            checkBoxPool.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxPool.Location = new Point(6, 183);
            checkBoxPool.Name = "checkBoxPool";
            checkBoxPool.Size = new Size(146, 31);
            checkBoxPool.TabIndex = 10;
            checkBoxPool.Text = "          Pool";
            checkBoxPool.UseVisualStyleBackColor = true;
            // 
            // checkBoxGarage
            // 
            checkBoxGarage.AutoSize = true;
            checkBoxGarage.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxGarage.Location = new Point(6, 146);
            checkBoxGarage.Name = "checkBoxGarage";
            checkBoxGarage.Size = new Size(170, 31);
            checkBoxGarage.TabIndex = 9;
            checkBoxGarage.Text = "          Garage";
            checkBoxGarage.UseVisualStyleBackColor = true;
            // 
            // textBoxNbrOfRooms
            // 
            textBoxNbrOfRooms.AcceptsReturn = true;
            textBoxNbrOfRooms.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNbrOfRooms.Location = new Point(6, 99);
            textBoxNbrOfRooms.Name = "textBoxNbrOfRooms";
            textBoxNbrOfRooms.Size = new Size(63, 34);
            textBoxNbrOfRooms.TabIndex = 8;
            // 
            // roomslabel
            // 
            roomslabel.AutoSize = true;
            roomslabel.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            roomslabel.Location = new Point(92, 106);
            roomslabel.Name = "roomslabel";
            roomslabel.Size = new Size(78, 27);
            roomslabel.TabIndex = 1;
            roomslabel.Text = "Rooms";
            // 
            // changeButton
            // 
            changeButton.BackColor = SystemColors.ButtonHighlight;
            changeButton.Font = new Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point);
            changeButton.Location = new Point(64, 427);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(117, 35);
            changeButton.TabIndex = 14;
            changeButton.Text = "Change";
            changeButton.UseVisualStyleBackColor = false;
            changeButton.Click += changeButton_Click;
            // 
            // commercialBox
            // 
            commercialBox.Controls.Add(cmbWarehouseType);
            commercialBox.Controls.Add(checkBoxColdRoom);
            commercialBox.Location = new Point(715, 73);
            commercialBox.Margin = new Padding(3, 2, 3, 2);
            commercialBox.Name = "commercialBox";
            commercialBox.Padding = new Padding(3, 2, 3, 2);
            commercialBox.Size = new Size(271, 408);
            commercialBox.TabIndex = 2;
            commercialBox.TabStop = false;
            commercialBox.Text = "Commercial estate";
            // 
            // cmbWarehouseType
            // 
            cmbWarehouseType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWarehouseType.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbWarehouseType.ForeColor = SystemColors.InfoText;
            cmbWarehouseType.FormattingEnabled = true;
            cmbWarehouseType.Location = new Point(18, 137);
            cmbWarehouseType.Name = "cmbWarehouseType";
            cmbWarehouseType.Size = new Size(234, 34);
            cmbWarehouseType.TabIndex = 18;
            // 
            // checkBoxColdRoom
            // 
            checkBoxColdRoom.AutoSize = true;
            checkBoxColdRoom.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxColdRoom.Location = new Point(18, 189);
            checkBoxColdRoom.Name = "checkBoxColdRoom";
            checkBoxColdRoom.Size = new Size(239, 31);
            checkBoxColdRoom.TabIndex = 17;
            checkBoxColdRoom.Text = "  Cold Storage Room";
            checkBoxColdRoom.UseVisualStyleBackColor = true;
            // 
            // institutionalBox
            // 
            institutionalBox.Controls.Add(labelClassrooms);
            institutionalBox.Controls.Add(textBoxClassrooms);
            institutionalBox.Controls.Add(checkBoxSportsCenter);
            institutionalBox.Controls.Add(checkBoxCafeteria);
            institutionalBox.Controls.Add(cmbPurposeType);
            institutionalBox.Location = new Point(992, 73);
            institutionalBox.Margin = new Padding(3, 2, 3, 2);
            institutionalBox.Name = "institutionalBox";
            institutionalBox.Padding = new Padding(3, 2, 3, 2);
            institutionalBox.Size = new Size(258, 408);
            institutionalBox.TabIndex = 3;
            institutionalBox.TabStop = false;
            institutionalBox.Text = "Institutional estate";
            // 
            // labelClassrooms
            // 
            labelClassrooms.AutoSize = true;
            labelClassrooms.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelClassrooms.Location = new Point(98, 266);
            labelClassrooms.Name = "labelClassrooms";
            labelClassrooms.Size = new Size(121, 27);
            labelClassrooms.TabIndex = 22;
            labelClassrooms.Text = "Classrooms";
            // 
            // textBoxClassrooms
            // 
            textBoxClassrooms.AcceptsReturn = true;
            textBoxClassrooms.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxClassrooms.Location = new Point(10, 263);
            textBoxClassrooms.Name = "textBoxClassrooms";
            textBoxClassrooms.Size = new Size(63, 34);
            textBoxClassrooms.TabIndex = 21;
            // 
            // checkBoxSportsCenter
            // 
            checkBoxSportsCenter.AutoSize = true;
            checkBoxSportsCenter.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSportsCenter.Location = new Point(10, 226);
            checkBoxSportsCenter.Name = "checkBoxSportsCenter";
            checkBoxSportsCenter.Size = new Size(235, 31);
            checkBoxSportsCenter.TabIndex = 20;
            checkBoxSportsCenter.Text = "          Sports Center";
            checkBoxSportsCenter.UseVisualStyleBackColor = true;
            // 
            // checkBoxCafeteria
            // 
            checkBoxCafeteria.AutoSize = true;
            checkBoxCafeteria.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxCafeteria.Location = new Point(10, 189);
            checkBoxCafeteria.Name = "checkBoxCafeteria";
            checkBoxCafeteria.Size = new Size(191, 31);
            checkBoxCafeteria.TabIndex = 19;
            checkBoxCafeteria.Text = "          Cafeteria";
            checkBoxCafeteria.UseVisualStyleBackColor = true;
            // 
            // cmbPurposeType
            // 
            cmbPurposeType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPurposeType.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbPurposeType.ForeColor = SystemColors.InfoText;
            cmbPurposeType.FormattingEnabled = true;
            cmbPurposeType.Location = new Point(6, 137);
            cmbPurposeType.Name = "cmbPurposeType";
            cmbPurposeType.Size = new Size(234, 34);
            cmbPurposeType.TabIndex = 18;
            // 
            // lstPublishedObjects
            // 
            lstPublishedObjects.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lstPublishedObjects.FormattingEnabled = true;
            lstPublishedObjects.ItemHeight = 33;
            lstPublishedObjects.Location = new Point(3, 43);
            lstPublishedObjects.Name = "lstPublishedObjects";
            lstPublishedObjects.Size = new Size(297, 367);
            lstPublishedObjects.TabIndex = 4;
            lstPublishedObjects.SelectedIndexChanged += lstPublishedObjects_SelectedIndexChanged;
            // 
            // publishedObjectsBox
            // 
            publishedObjectsBox.Controls.Add(deleteButton);
            publishedObjectsBox.Controls.Add(lstPublishedObjects);
            publishedObjectsBox.Controls.Add(changeButton);
            publishedObjectsBox.Location = new Point(28, 512);
            publishedObjectsBox.Name = "publishedObjectsBox";
            publishedObjectsBox.Size = new Size(307, 480);
            publishedObjectsBox.TabIndex = 5;
            publishedObjectsBox.TabStop = false;
            publishedObjectsBox.Text = "Published Objects";
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point);
            deleteButton.Location = new Point(196, 427);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(105, 35);
            deleteButton.TabIndex = 6;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
            pictureBox.ErrorImage = (Image)resources.GetObject("pictureBox.ErrorImage");
            pictureBox.InitialImage = (Image)resources.GetObject("pictureBox.InitialImage");
            pictureBox.Location = new Point(69, 43);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(327, 309);
            pictureBox.TabIndex = 6;
            pictureBox.TabStop = false;
            // 
            // showInfoBox
            // 
            showInfoBox.Controls.Add(infoAboutEstLabel);
            showInfoBox.Controls.Add(pictureBox);
            showInfoBox.Location = new Point(389, 512);
            showInfoBox.Name = "showInfoBox";
            showInfoBox.Size = new Size(470, 480);
            showInfoBox.TabIndex = 7;
            showInfoBox.TabStop = false;
            showInfoBox.Text = "Info";
            // 
            // infoAboutEstLabel
            // 
            infoAboutEstLabel.AutoSize = true;
            infoAboutEstLabel.Font = new Font("Constantia", 7F, FontStyle.Regular, GraphicsUnit.Point);
            infoAboutEstLabel.Location = new Point(6, 365);
            infoAboutEstLabel.Name = "infoAboutEstLabel";
            infoAboutEstLabel.Size = new Size(165, 23);
            infoAboutEstLabel.TabIndex = 7;
            infoAboutEstLabel.Text = "Info about estate...";
            // 
            // sellerLessorInfobutton
            // 
            sellerLessorInfobutton.BackColor = SystemColors.ButtonHighlight;
            sellerLessorInfobutton.Font = new Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point);
            sellerLessorInfobutton.Location = new Point(865, 648);
            sellerLessorInfobutton.Name = "sellerLessorInfobutton";
            sellerLessorInfobutton.Size = new Size(283, 43);
            sellerLessorInfobutton.TabIndex = 8;
            sellerLessorInfobutton.Text = "Info Seller/ Lessor";
            sellerLessorInfobutton.UseVisualStyleBackColor = false;
            sellerLessorInfobutton.Click += sellerLessorInfobutton_Click;
            // 
            // buyerInfoButton
            // 
            buyerInfoButton.BackColor = SystemColors.ButtonHighlight;
            buyerInfoButton.Font = new Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buyerInfoButton.Location = new Point(865, 697);
            buyerInfoButton.Name = "buyerInfoButton";
            buyerInfoButton.Size = new Size(283, 43);
            buyerInfoButton.TabIndex = 9;
            buyerInfoButton.Text = "Info Buyer/ Tenant";
            buyerInfoButton.UseVisualStyleBackColor = false;
            buyerInfoButton.Click += buyerInfoButton_Click;
            // 
            // buttonBuyerOrTenant
            // 
            buttonBuyerOrTenant.Font = new Font("Constantia", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonBuyerOrTenant.Location = new Point(865, 886);
            buttonBuyerOrTenant.Name = "buttonBuyerOrTenant";
            buttonBuyerOrTenant.Size = new Size(283, 37);
            buttonBuyerOrTenant.TabIndex = 18;
            buttonBuyerOrTenant.Text = "Add Buyer/ Tenant";
            buttonBuyerOrTenant.UseVisualStyleBackColor = true;
            buttonBuyerOrTenant.Click += buttonBuyerOrTenant_Click;
            // 
            // btnAddEstate
            // 
            btnAddEstate.BackColor = SystemColors.ButtonHighlight;
            btnAddEstate.Font = new Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddEstate.Location = new Point(1094, 486);
            btnAddEstate.Name = "btnAddEstate";
            btnAddEstate.Size = new Size(156, 54);
            btnAddEstate.TabIndex = 19;
            btnAddEstate.Text = "Add Estate";
            btnAddEstate.UseVisualStyleBackColor = false;
            btnAddEstate.Click += btnAddEstate_Click;
            // 
            // mnuFile
            // 
            mnuFile.ImageScalingSize = new Size(32, 32);
            mnuFile.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            mnuFile.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            mnuFile.Location = new Point(0, 0);
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(1299, 40);
            mnuFile.TabIndex = 20;
            mnuFile.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuFileNew, mnuFileOpen, mnuFileSave, mnuFileSaveAs, mnuFileXML, mnuFileExit });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(71, 36);
            fileToolStripMenuItem.Text = "&File";
            // 
            // mnuFileNew
            // 
            mnuFileNew.Name = "mnuFileNew";
            mnuFileNew.Size = new Size(236, 44);
            mnuFileNew.Text = "&New";
            mnuFileNew.Click += mnuFileNew_Click;
            // 
            // mnuFileOpen
            // 
            mnuFileOpen.DropDownItems.AddRange(new ToolStripItem[] { mnuOpenDeserialize });
            mnuFileOpen.Name = "mnuFileOpen";
            mnuFileOpen.Size = new Size(236, 44);
            mnuFileOpen.Text = "&Open";
            // 
            // mnuOpenDeserialize
            // 
            mnuOpenDeserialize.Name = "mnuOpenDeserialize";
            mnuOpenDeserialize.Size = new Size(277, 44);
            mnuOpenDeserialize.Text = "Deserialize...";
            mnuOpenDeserialize.Click += mnuOpenDeserialize_Click;
            // 
            // mnuFileSave
            // 
            mnuFileSave.Name = "mnuFileSave";
            mnuFileSave.Size = new Size(236, 44);
            mnuFileSave.Text = "&Save";
            mnuFileSave.Click += mnuFileSave_Click;
            // 
            // mnuFileSaveAs
            // 
            mnuFileSaveAs.Name = "mnuFileSaveAs";
            mnuFileSaveAs.Size = new Size(236, 44);
            mnuFileSaveAs.Text = "Save &as..";
            mnuFileSaveAs.Click += mnuFileSaveAs_Click;
            // 
            // mnuFileXML
            // 
            mnuFileXML.DropDownItems.AddRange(new ToolStripItem[] { mnuXMLImport, mnuXMLExport });
            mnuFileXML.Name = "mnuFileXML";
            mnuFileXML.Size = new Size(236, 44);
            mnuFileXML.Text = "XML";
            // 
            // mnuXMLImport
            // 
            mnuXMLImport.Name = "mnuXMLImport";
            mnuXMLImport.Size = new Size(374, 44);
            mnuXMLImport.Text = "Import From XML file";
            mnuXMLImport.Click += mnuXMLImport_Click;
            // 
            // mnuXMLExport
            // 
            mnuXMLExport.Name = "mnuXMLExport";
            mnuXMLExport.Size = new Size(374, 44);
            mnuXMLExport.Text = "Export to XML file";
            mnuXMLExport.Click += mnuXMLExport_Click;
            // 
            // mnuFileExit
            // 
            mnuFileExit.Name = "mnuFileExit";
            mnuFileExit.Size = new Size(236, 44);
            mnuFileExit.Text = "E&xit";
            mnuFileExit.Click += mnuFileExit_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(84, 36);
            helpToolStripMenuItem.Text = "Help";
            // 
            // openFileDia1
            // 
            openFileDia1.FileName = "openFileDia1";
            // 
            // saveFileDia1
            // 
            saveFileDia1.FileName = "saveFileDia1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(18F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 1064);
            Controls.Add(btnAddEstate);
            Controls.Add(buttonBuyerOrTenant);
            Controls.Add(buyerInfoButton);
            Controls.Add(sellerLessorInfobutton);
            Controls.Add(showInfoBox);
            Controls.Add(publishedObjectsBox);
            Controls.Add(institutionalBox);
            Controls.Add(commercialBox);
            Controls.Add(residentalBox);
            Controls.Add(estateInfoBox);
            Controls.Add(mnuFile);
            Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = mnuFile;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "Modern Real Estate by Hedda Eriksson";
            estateInfoBox.ResumeLayout(false);
            estateInfoBox.PerformLayout();
            residentalBox.ResumeLayout(false);
            residentalBox.PerformLayout();
            commercialBox.ResumeLayout(false);
            commercialBox.PerformLayout();
            institutionalBox.ResumeLayout(false);
            institutionalBox.PerformLayout();
            publishedObjectsBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            showInfoBox.ResumeLayout(false);
            showInfoBox.PerformLayout();
            mnuFile.ResumeLayout(false);
            mnuFile.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private GroupBox estateInfoBox;
        private GroupBox residentalBox;
        private GroupBox commercialBox;
        private GroupBox institutionalBox;
        private Label zipCodeLabel;
        private Label streetLabel;
        private Label areaLabel;
        private Label contractLabel;
        private Label Country;
        private Label cityLabel;
        private TextBox textBoxCity;
        private TextBox textBoxZip;
        private TextBox textBoxstreet;
        private ComboBox cmbContractType;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox textBoxArea;
        private ComboBox cmbCountryCategory;
        private Label roomslabel;
        private CheckBox checkBoxGarage;
        private TextBox textBoxNbrOfRooms;
        private CheckBox checkBoxBalcony;
        private CheckBox checkBoxPool;
        private ListBox lstPublishedObjects;
        private GroupBox publishedObjectsBox;
        private Button changeButton;
        private Button deleteButton;
        private PictureBox pictureBox;
        private Button addImageButton;
        private GroupBox showInfoBox;
        private Label infoAboutEstLabel;
        private TextBox textBoxImageInfo;
        private CheckBox checkBoxKitchenette;
        private CheckBox checkBoxLake;
        private CheckBox checkBoxColdRoom;
        private ComboBox cmbWarehouseType;
        private CheckBox checkBoxCafeteria;
        private ComboBox cmbPurposeType;
        private TextBox textBoxClassrooms;
        private CheckBox checkBoxSportsCenter;
        private Label labelClassrooms;
        private Label labelSellerBuyer;
        private Button sellerLessorInfobutton;
        private Button buyerInfoButton;
        private Button AddSellerLessorButton;
        private Button buttonBuyerOrTenant;
        private ComboBox cmbContractor;
        private Label lblEstateType;
        private ComboBox cmbEstateType;
        private Button btnAddEstate;
        private MenuStrip mnuFile;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem mnuFileNew;
        private ToolStripMenuItem mnuFileOpen;
        private ToolStripMenuItem mnuFileSave;
        private ToolStripMenuItem mnuFileSaveAs;
        private ToolStripMenuItem mnuFileXML;
        private ToolStripMenuItem mnuXMLImport;
        private ToolStripMenuItem mnuXMLExport;
        private ToolStripMenuItem mnuFileExit;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem mnuOpenDeserialize;
        private OpenFileDialog openFileDia1;
        private SaveFileDialog saveFileDia1;
    }
}