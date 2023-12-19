// Author: Hedda Eriksson
// Date: 2023-10-04 
// Malmö University, Bachelor of Engineering - Computer Science & Telecommunications
// info: interface, user interface.
using RealEstateBLL.RealEstate;
using RealEstateBLL;
using RealEstateBLL.RealEstate.Insititutionals;
using RealEstateBLL.RealEstate.Commercials;
using RealEstateDTO;
using RealEstateSL;

namespace ModernRealEstate
{
    public partial class MainForm : Form
    {
        private EstateService estateService = new EstateService();
        private PersonInfoForm pInfoForm;
        private string m_fileName;
        private FileTypes m_fileExt = FileTypes.dat;
        private int selectedIteminList = -1;
        private int estateListbefore = 0;

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        //----------------METHODS-----------------
        private void InitializeGUI()
        {
            cmbContractType.DataSource = Enum.GetValues(typeof(ContractType));
            cmbCountryCategory.DataSource = Enum.GetValues(typeof(Countries));
            cmbWarehouseType.DataSource = Enum.GetValues(typeof(WarehouseType));
            cmbPurposeType.DataSource = Enum.GetValues(typeof(PurposeType));
            cmbEstateType.DataSource = Enum.GetValues(typeof(EstateType));

            cmbContractor.Items.Add("Seller");
            cmbContractor.Items.Add("Lessor");

            m_fileName = "Untitled";

            UpdateGUI();
        }

        private void UpdateGUI()
        {
            ResetGUI();
            lstPublishedObjects.Items.Clear();
            lstPublishedObjects.Items.AddRange(estateService.EstateList());
        }

        private void ResetGUI()
        {

            textBoxstreet.Text = "Lilla vägen 2";
            textBoxCity.Text = "Malmö";
            textBoxZip.Text = "12221";
            textBoxArea.Text = string.Empty;
            textBoxNbrOfRooms.Text = string.Empty;
            textBoxImageInfo.Text = string.Empty;
            textBoxClassrooms.Text = string.Empty;

            infoAboutEstLabel.Text = string.Empty;

            pictureBox.Image = pictureBox.InitialImage;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            cmbEstateType.Text = EstateType.Other.ToString();
            cmbContractType.Text = ContractType.Tenement.ToString();
            cmbContractor.Text = "Seller";

            checkBoxBalcony.Enabled = true;
            checkBoxGarage.Enabled = true;
            checkBoxPool.Enabled = true;
            checkBoxKitchenette.Enabled = true;
            checkBoxLake.Enabled = true;
            checkBoxBalcony.Checked = false;
            checkBoxGarage.Checked = false;
            checkBoxPool.Checked = false;
            checkBoxKitchenette.Checked = false;
            checkBoxLake.Checked = false;
            checkBoxColdRoom.Checked = false;
            checkBoxCafeteria.Checked = false;
            checkBoxSportsCenter.Checked = false;
        }

        /// <summary>
        /// Settings for GUI - depending on type of estate. 
        /// </summary>
        private void SettingsGUI(EstateType e_type)
        {
            //Settings Apartment -> Studio
            if ((e_type == EstateType.Apartment) || (e_type == EstateType.Studio))
            {
                // INVOKE LATER
                residentalBox.Enabled = true;
                commercialBox.Enabled = false;
                institutionalBox.Enabled = false;

                checkBoxBalcony.Enabled = true;
                checkBoxGarage.Enabled = false;
                checkBoxPool.Enabled = false;
                checkBoxLake.Enabled = false;
                checkBoxKitchenette.Enabled = false;
                if (e_type == EstateType.Studio)
                {
                    checkBoxKitchenette.Enabled = true;
                }
            }
            //Settings Villa -> Cabin
            else if ((e_type == EstateType.Villa) || (e_type == EstateType.Cabin))
            {
                // INVOKE LATER
                residentalBox.Enabled = true;
                commercialBox.Enabled = false;
                institutionalBox.Enabled = false;

                checkBoxPool.Enabled = true;
                checkBoxGarage.Enabled = true;
                checkBoxBalcony.Enabled = false;
                checkBoxLake.Enabled = false;
                checkBoxKitchenette.Enabled = false;
                if (e_type == EstateType.Cabin)
                {
                    checkBoxLake.Enabled = true;
                }
            }
            else if (e_type == EstateType.Warehouse)
            {
                residentalBox.Enabled = false;
                commercialBox.Enabled = true;
                institutionalBox.Enabled = false;
            }
            else if (e_type == EstateType.School)
            {
                residentalBox.Enabled = false;
                commercialBox.Enabled = false;
                institutionalBox.Enabled = true;
            }
            else
            {
                residentalBox.Enabled = true;
                commercialBox.Enabled = true;
                institutionalBox.Enabled = true;
            }
        }
        
        /// <summary>
        /// Save File
        /// Open file dialog with specified settings and save file as .xml or .dat
        /// </summary>
        private bool OpenFileToSaveData()
        {
            bool ok = true;
            int filterIndex = 1;

            saveFileDia1.Title = "Save file as... ";
            saveFileDia1.Filter = SetFileExtension(out filterIndex);
            saveFileDia1.FilterIndex = filterIndex;
            saveFileDia1.AddExtension = true;
            saveFileDia1.InitialDirectory = "\\\\Mac\\Home\\Documents\\VSProjects\\ModernRealEstate\\RealEstateDAL\\Files\\";

            if (saveFileDia1.ShowDialog() == DialogResult.OK)
            {
                string errorMsg = string.Empty;
                SetFileType(saveFileDia1.FilterIndex, out errorMsg);
                MessageBox.Show(saveFileDia1.FileName, "filename");
                FileDTO fileDTO = new FileDTO
                {
                    FileName = saveFileDia1.FileName,
                    FileType = m_fileExt
                };
                if (estateService.SaveFile(fileDTO, out errorMsg))
                {
                    estateListbefore = estateService.CountEstates();
                    UpdateGUI();
                    MessageBox.Show("File is saved", "Info");
                }
                else { MessageBox.Show(errorMsg, "Error"); }
            }
            else
            {
                ok = false;
            }

            return ok;
        }

        /// <summary>
        /// Open Saved File
        /// Open file dialog with specified settings and download selected file. 
        /// </summary>
        private bool OpenFileToReadData()
        {
            bool ok = true;
            int filterIndex = 0;
            //set up file dialog
            openFileDia1.Title = "Open file as " + m_fileExt.ToString();
            openFileDia1.Filter = SetFileExtension(out filterIndex);
            openFileDia1.FilterIndex = filterIndex;
            openFileDia1.InitialDirectory = "\\\\Mac\\Home\\Documents\\VSProjects\\ModernRealEstate\\RealEstateDAL\\Files\\";

            if (openFileDia1.ShowDialog() == DialogResult.OK)
            {
                string errorMsg = string.Empty;
                SetFileType(openFileDia1.FilterIndex, out errorMsg);
                FileDTO fileDTO = new FileDTO
                {
                    FileName = openFileDia1.FileName,
                    FileType = m_fileExt
                };
                if (estateService.readFile(fileDTO, out errorMsg))
                {
                    estateListbefore = estateService.CountEstates();
                    UpdateGUI();
                }
                else
                {
                    MessageBox.Show(errorMsg, "Errorrrr");
                }
            }
            else
            {
                ok = false;
            }
            return ok;
        }

        /// <summary>
        /// Determining the file extension and setting the corresponding index for a file filter string.
        /// </summary>
        /// <returns>The complete filter string, which includes all the defined filter options for 
        /// different file types.</returns>
        private string SetFileExtension(out int index)
        {
            const string filter = "dat files (*.dat) |*.dat|xml files (*.xml)|*.xml|all files (*.*) |*.*";

            switch (m_fileExt)
            {
                case FileTypes.dat:
                    index = 1;
                    break;
                case FileTypes.xml:
                    index = 2;
                    break;
                default:
                    index = 3;
                    break;
            }
            return filter;
        }

        /// <summary>
        /// Set file type by checking which index was selected.
        /// </summary>
        /// <param name="index">A index from file dialog.</param>
        private void SetFileType(int index, out string errorMsg)
        {
            errorMsg = string.Empty;
            switch (index)
            {
                case 1:
                    m_fileExt = FileTypes.dat;
                    break;
                case 2:
                    m_fileExt = FileTypes.xml;
                    break;
                default:
                    errorMsg = "default";
                    break;
            }
        }

        //-------------------EVENT LISTENERS-------------------------

        /// <summary>
        /// Add an estate object to m_list.
        /// </summary>
        private void btnAddEstate_Click(object sender, EventArgs e)
        {
            EstateDTO estateDTO = new EstateDTO
            {
                EstateType = (EstateType)cmbEstateType.SelectedIndex,
                ContractType = (ContractType)cmbContractType.SelectedIndex,
                Purpose = (PurposeType)cmbPurposeType.SelectedIndex,
                WarehouseType = (WarehouseType)cmbWarehouseType.SelectedIndex,
                ImageLocation = textBoxImageInfo.Text,
                EstateArea = textBoxArea.Text,
                NbrOfRooms = textBoxNbrOfRooms.Text,
                NbrOfClassrooms = textBoxClassrooms.Text,
                Garage = checkBoxBalcony.Checked,
                Pool = checkBoxPool.Checked,
                Balcony = checkBoxBalcony.Checked,
                CloseLake = checkBoxLake.Checked,
                Kitchentte = checkBoxKitchenette.Checked,
                Cafeteria = checkBoxCafeteria.Checked,
                SportsCenter = checkBoxSportsCenter.Checked,
                ColdStorageRoom = checkBoxColdRoom.Checked       
            };
            AddressDTO addressDTO = new AddressDTO
            {
                City = textBoxCity.Text,
                Street = textBoxstreet.Text,
                ZipCode = textBoxZip.Text,
                Country = (Countries) cmbCountryCategory.SelectedIndex
            };

            string errorMsg;
            
            if(estateService.AddEstate(estateDTO, addressDTO, pInfoForm.PersonDTO, pInfoForm.PersonalAddressDTO, out errorMsg))
            {
                UpdateGUI();    
            }
            else
            {
                MessageBox.Show(errorMsg, "Error");
            }
        }


        /// <summary>
        /// Change an estate object.
        /// </summary>
        private void changeButton_Click(object sender, EventArgs e)
        {
            string estateID = lstPublishedObjects.Text;
            string errorMsg = string.Empty;
            int index = lstPublishedObjects.SelectedIndex;
            
            EstateDTO estateDTO = new EstateDTO
            {
                EstateType = (EstateType)cmbEstateType.SelectedIndex,
                ContractType = (ContractType)cmbContractType.SelectedIndex,
                Purpose = (PurposeType)cmbPurposeType.SelectedIndex,
                WarehouseType = (WarehouseType)cmbWarehouseType.SelectedIndex,
                ImageLocation = textBoxImageInfo.Text,
                EstateArea = textBoxArea.Text,
                NbrOfRooms = textBoxNbrOfRooms.Text,
                NbrOfClassrooms = textBoxClassrooms.Text,
                Garage = checkBoxBalcony.Checked,
                Pool = checkBoxPool.Checked,
                Balcony = checkBoxBalcony.Checked,
                CloseLake = checkBoxLake.Checked,
                Kitchentte = checkBoxKitchenette.Checked,
                Cafeteria = checkBoxCafeteria.Checked,
                SportsCenter = checkBoxSportsCenter.Checked,
                ColdStorageRoom = checkBoxColdRoom.Checked
            };
            AddressDTO addressDTO = new AddressDTO
            {
                City = textBoxCity.Text,
                Street = textBoxstreet.Text,
                ZipCode = textBoxZip.Text,
                Country = (Countries)cmbCountryCategory.SelectedIndex
            };

            bool ok = estateService.ChangeEstateObject(index, estateDTO, addressDTO, out errorMsg);

            if (ok)
            {
                MessageBox.Show(string.Format("Success! {0} is changed.", estateID, "Info"));
                UpdateGUI();
            }
            else { MessageBox.Show(errorMsg, "Error"); }
        }

        /// <summary>
        /// Delete an estate object.
        /// </summary>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            string estateID = lstPublishedObjects.Text;
            int index = lstPublishedObjects.SelectedIndex;
            string errorMsg = string.Empty;

            bool ok = estateService.DeleteEstateObject(estateID, index, out errorMsg);

            if (ok)
            {
                MessageBox.Show(string.Format("{0} has been deleted.", estateID, "Info"));
                UpdateGUI();
            }
            else
            {
                MessageBox.Show(errorMsg, "Error");
            }
        }

        /// <summary>
        /// If object in "Published obecjts list" has been marked, show all info about object
        /// </summary>
        private void lstPublishedObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPublishedObjects.SelectedIndex != selectedIteminList)
            {
                selectedIteminList = lstPublishedObjects.SelectedIndex;
                int index = lstPublishedObjects.SelectedIndex;
                string id = lstPublishedObjects.Text;
                if (id != null)
                {
                    ResetGUI();
                    SettingsGUI((EstateType)cmbEstateType.SelectedIndex);

                    //Retrieve DTO from BLL
                    EstateDTO estateDTO = estateService.GetEstateDTOAt(index);
                    AddressDTO addressDTO = estateService.GetAddressDTOAt(index);

                    textBoxstreet.Text = addressDTO.Street;
                    textBoxZip.Text = addressDTO.ZipCode;
                    textBoxCity.Text = addressDTO.City;
                    cmbCountryCategory.Text = Enum.GetName(addressDTO.Country);

                    textBoxArea.Text = estateDTO.EstateArea;
                    cmbContractType.Text = Enum.GetName(estateDTO.ContractType);
                    cmbEstateType.Text = estateDTO.EstateType.ToString();
                    pictureBox.ImageLocation = estateDTO.ImageLocation;

                    infoAboutEstLabel.Text = estateDTO.InfoString;

                    switch (estateDTO.EstateType)
                    {

                        case EstateType.Villa:
                            textBoxNbrOfRooms.Text = estateDTO.NbrOfRooms;
                            checkBoxGarage.Checked = estateDTO.Garage;
                            checkBoxPool.Checked = estateDTO.Pool;
                            break;
                        case EstateType.Apartment:
                            textBoxNbrOfRooms.Text = estateDTO.NbrOfRooms;
                            checkBoxBalcony.Checked = estateDTO.Balcony;
                            break;
                        case EstateType.Cabin:
                            textBoxNbrOfRooms.Text = estateDTO.NbrOfRooms;
                            checkBoxGarage.Checked = estateDTO.Garage;
                            checkBoxPool.Checked = estateDTO.Pool;
                            checkBoxLake.Checked = estateDTO.CloseLake;
                            break;
                        case EstateType.Studio:
                            textBoxNbrOfRooms.Text = estateDTO.NbrOfRooms;
                            checkBoxBalcony.Checked = estateDTO.Balcony;
                            checkBoxKitchenette.Checked = estateDTO.Kitchentte;
                            break;
                        case EstateType.Warehouse:
                            cmbWarehouseType.Text = estateDTO.WarehouseType.ToString();
                            checkBoxColdRoom.Checked = estateDTO.ColdStorageRoom;
                            break;
                        case EstateType.School:
                            cmbPurposeType.Text = estateDTO.Purpose.ToString();
                            textBoxClassrooms.Text = estateDTO.NbrOfClassrooms;
                            checkBoxCafeteria.Checked = estateDTO.Cafeteria;
                            checkBoxSportsCenter.Checked = estateDTO.SportsCenter;
                            break;
                    }
                }
            }
            else
            {
                selectedIteminList = -1;
                UpdateGUI();
            }
        }

        /// <summary>
        /// Image handler 
        /// </summary>
        private void addImageButton_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = "\\\\Mac\\Home\\Documents\\VSProjects\\ModernRealEstate\\ModernRealEstate\\Images\\";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = openFileDialog.FileName;

                    pictureBox.ImageLocation = imageLocation;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    textBoxImageInfo.Text = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured...", "Error");
                //throw;
            }
        }

        /// <summary>
        /// For GUI settings 
        /// </summary>
        private void cmbEstateType_SelectedIndexChanged(object sender, EventArgs e)
        {
            EstateType e_type = (EstateType)cmbEstateType.SelectedIndex;
            SettingsGUI(e_type);
        }

        private void cmbContractType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string.Equals(cmbContractType.Text, "Rental")) ||
                (string.Equals(cmbContractType.Text, "Lease")))
            {
                cmbContractor.Text = "Lessor";
            }
            else { cmbContractor.Text = "Seller"; }
        }

        /// <summary>
        /// Add Seller/Lessor and open PersonInfoForm
        /// </summary>
        private void AddSellerLessorButton_Click(object sender, EventArgs e)
        {
            string typeOfPerson = cmbContractor.Text;
            pInfoForm = new PersonInfoForm(estateService, typeOfPerson, "");
            pInfoForm.ShowDialog();
        }

        private void sellerLessorInfobutton_Click(object sender, EventArgs e)
        {
            int index = lstPublishedObjects.SelectedIndex;
            //Estate obj = e_Manager.GetAt(index);
            Estate obj = estateService.GetEstateAt(index);

            if ((obj != null) && (obj.EstatePerson != null))
            {
                MessageBox.Show(obj.EstatePerson.ToString());
            }
        }

        /// <summary>
        /// Add buyer/tenant and open PersonInfoFrom
        /// </summary>
        private void buttonBuyerOrTenant_Click(object sender, EventArgs e)
        {
            //int index = lstPublishedObjects.SelectedIndex;
            //Estate obj = estateService.GetEstateAt(index);
            string typeOfPerson = cmbContractor.Text;
            string id = lstPublishedObjects.Text;

            if (typeOfPerson == "Seller")
            {
                typeOfPerson = "Buyer";
            }
            else
            {
                typeOfPerson = "Tenant";
            }

            if (id != null)
            {
                pInfoForm = new PersonInfoForm(estateService, typeOfPerson, id);
                pInfoForm.ShowDialog();
            }
        }

        private void buyerInfoButton_Click(object sender, EventArgs e)
        {
            string estateID = lstPublishedObjects.Text;
            Object client = estateService.GetPersonAt(estateID);
            if (client != null)
            {
                MessageBox.Show(client.ToString());
            }
            else
            {
                MessageBox.Show("No buyer exist.", "Info");
            }

        }

        /// <summary>
        /// Open new file -> if current file isnt saved ask to continue
        /// </summary>
        private void mnuFileNew_Click(object sender, EventArgs e)
        {
           int estateListNow = estateService.CountEstates();

            if ((m_fileName == string.Empty) || (estateListbefore != estateListNow))
            {
                if (MessageBox.Show("File is not saved, do you want to continue?", Application.ProductName, MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                    estateService.DeleteAllData();
                    estateListbefore = 0;
                    InitializeGUI();
            }
            else
            {
                estateService.DeleteAllData();
                InitializeGUI();
            }

        }

        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(m_fileName)) || ((m_fileName == "Untitled")))
            {
                OpenFileToSaveData();
            }
            else
            {
                string errorMsg = string.Empty;
                FileDTO fileDTO = new FileDTO
                {
                    FileName = m_fileName,
                    FileType = m_fileExt
                };
                // if (!e_Manager.SaveDataToFile(m_fileName, m_fileExt, out errorMsg))
                if (!estateService.SaveFile(fileDTO, out errorMsg)) ;
                    MessageBox.Show(errorMsg, "Error");
            }
        }

        private void mnuOpenDeserialize_Click(object sender, EventArgs e)
        {
            OpenFileToReadData();
        }

        private void mnuFileSaveAs_Click(object sender, EventArgs e)
        {
            OpenFileToSaveData();
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuXMLImport_Click(object sender, EventArgs e)
        {
            OpenFileToReadData();
        }

        private void mnuXMLExport_Click(object sender, EventArgs e)
        {
            OpenFileToSaveData();
        }

    }
}