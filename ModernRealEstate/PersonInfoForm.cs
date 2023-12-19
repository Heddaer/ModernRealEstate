// Author: Hedda Eriksson
// Date: 2023-10-055
// Malmö University, Bachelor of Engineering - Computer Science & Telecommunications
// info: PersonInfoForm is a class for the user interface that shows a form of personal information. 
using System.Diagnostics.Eventing.Reader;
using RealEstateDTO;
using RealEstateSL;
namespace ModernRealEstate
{
    public partial class PersonInfoForm : Form
    {
        PersonDTO personDTO;
        AddressDTO personalAddressDTO;
        private EstateService estateService;
        private string typeOfPerson, id;

        public PersonInfoForm(EstateService estateService, string typeOfPerson, string id)
        {
            this.estateService = estateService;
            this.typeOfPerson = typeOfPerson;
            this.id = id;
            InitializeComponent();
            InitializeGUI();
        }

        //----------------METHODS-----------------
        private void InitializeGUI()
        {
            DefaultValues();
            cmbCountry.DataSource = Enum.GetValues(typeof(Countries));
            cmbCountry.DataSource = Enum.GetValues(typeof(Countries));
            cmbPersonType.Items.Add("Seller");
            cmbPersonType.Items.Add("Buyer");
            cmbPersonType.Items.Add("Tenant");
            cmbPersonType.Items.Add("Lessor");
            cmbPersonType.Text = typeOfPerson;
         
        }

        private void DefaultValues()
        {

            textBoxFirstName.Text = "Jane";
            textBoxLastName.Text = "Doe";
            textBoxEmail.Text = "jane@gmail.com";
            textBoxPhoneNbr.Text = "0769954364";
            textBoxBank.Text = "Danske Bank";
            textBoxStreet.Text = "Gatan 2";
            textBoxCity.Text = "Malmö";
            textBoxZip.Text = "12345";
        }

        // ------------ EVENT LISTENERS ---------------
        private void AddPerson_Click(object sender, EventArgs e)
        {
            personDTO = new PersonDTO
            {
                PersonType = cmbPersonType.Text,
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                PhoneNbr = textBoxPhoneNbr.Text,
                Email = textBoxEmail.Text,
                Bank = textBoxBank.Text,
                CompanyName = textBoxCompanyName.Text,
                MovingOutDate = dtpMovingOut.Text,
                LoanPromise = checkBoxLoanPromise.Checked,
                ApprovedIncome = checkBoxIncome.Checked
            };

            personalAddressDTO = new AddressDTO
            {
                City = textBoxCity.Text,
                Street = textBoxStreet.Text,
                ZipCode = textBoxZip.Text,
                Country = (Countries)cmbCountry.SelectedIndex
            };
            string errorMsg = string.Empty;
            estateService.AddPerson(personalAddressDTO, personDTO, id , out errorMsg);
            this.Close();
        }



        // ------------ GETTERS & SETTERS -------------
        public PersonDTO PersonDTO { get => personDTO; set => personDTO = value; }
        public AddressDTO PersonalAddressDTO { get => personalAddressDTO; set => personalAddressDTO = value; }
    }
}
