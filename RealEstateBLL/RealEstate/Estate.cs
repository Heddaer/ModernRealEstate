// Author: Hedda Eriksson
// Date: 2023-10-09 
// Malmö University, Bachelor of Engineering - Computer Science & Telecommunications
// info: Abstract class, has a interface, IEstate. This class is a base class.
using RealEstateBLL.Persons;
using System.Xml.Serialization;
using RealEstateBLL.RealEstate.Commercials;
using RealEstateBLL.RealEstate.Residentials;
using RealEstateBLL.RealEstate.Insititutionals;

namespace RealEstateBLL.RealEstate
{
    [Serializable]
    [XmlInclude(typeof(Villa))]
    [XmlInclude(typeof(Apartment))]
    [XmlInclude(typeof(Cabin))]
    [XmlInclude(typeof(Studio))]
    [XmlInclude(typeof(Warehouse))]
    [XmlInclude(typeof(School))]
    [XmlInclude(typeof(Seller))]
    [XmlInclude(typeof(Lessor))]
    [XmlInclude(typeof(Address))]
    public abstract class Estate : IEstate
    {
        private string estateID;
        private ContractType contractType;
        private int estateArea;
        private Address estateAddress;
        private string imageLocation;
        private Person estatePerson;


        //default constructor
        public Estate() 
        {
            estateID = "default";
            estateArea = 0;
            estateAddress = new Address();
            estatePerson = new Person();
        } 

        //first constructor
        public Estate(string id, ContractType contractType, int area, string imageLocation, Address address) { 
            estateID = id;
            this.contractType = contractType;
            estateArea = area;
            this.imageLocation = imageLocation;
            estateAddress = address;
        }

        //second constructor
        public Estate(string id, ContractType contractType, int area, string imageLocation, Address address, Person person)
        {
            estateID = id;
            this.contractType = contractType;
            estateArea = area;
            this.imageLocation = imageLocation;
            estateAddress = address;
            estatePerson = person;
        }

        //third constructor
        public Estate(string id, ContractType contractType, int area, string imageLocation, string street, int zipCode, string city, Countries country)
        {
            estateID = id;
            this.contractType = contractType;
            estateArea = area;
            this.imageLocation = imageLocation;
            estateAddress = new Address(street, zipCode, city, country);
        }

        // Abstract method that needs to be implemented and defined by the derived classes.
        public abstract double EstimatedRent(ContractType contract, int area);

        public override string ToString()
        {
            return string.Format("Estate ID: {0} with a {1}-contract ", estateID, ContractType);

        }

        // GETTERS & SETTERS
        public string EstateID
        {
            get { return estateID; }
            set { estateID = value; }
        }

        public ContractType ContractType
        {
            get { return contractType; }
            set { contractType = value; }   
        }

        public int Area 
        { 
            get { return estateArea; } 
            set { estateArea = value; } 
        }

        public string ImageLocation 
        { 
            get { return imageLocation; } 
            set {  imageLocation = value; } 
        }

        public Person EstatePerson { get => estatePerson; set => estatePerson = value; }
        public Address EstateAddress { get => estateAddress; set => estateAddress = value; }

        public void SetAddress(string street, string city, int zipCode, Countries country)
        {
            estateAddress.Street = street;
            estateAddress.City = city;
            estateAddress.ZipCode = zipCode; 
            estateAddress.Country = country;
        }

        public Address GetAddress()
        {
            return estateAddress;
        }
    }
}
