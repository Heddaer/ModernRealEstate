// Author: Hedda Eriksson
// Date: 2023-10-09 
// Malmö University, Bachelor of Engineering - Computer Science & Telecommunications
// info: This class contains information about an address


namespace RealEstateBLL.RealEstate
{
    [Serializable]
    public class Address
    {
        private string street;
        private int zipCode;
        private string city;
        private Countries country;


        // Default constructor

        public Address() 
        {
            this.street = "default";
            this.zipCode = 0;
            this.city = "default";
            this.country = Countries.Sverige;
        }

        //First constructor
        public Address(string street, int zipcode, string city, Countries country )
        {
            this.street = street;
            this.zipCode = zipcode;
            this.city = city;
            this.country = country;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}{2} {3} {4}{5}", street, Environment.NewLine, zipCode, city, Environment.NewLine, country);
        }

        // GETTERS & SETTERS
        public string Street { get => street; set => street = value; }
        public int ZipCode { get => zipCode; set => zipCode = value; }
        public string City { get => city; set => city = value; }
        public Countries Country { get => country; set => country = value; }
    }
}
