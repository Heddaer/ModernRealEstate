// Author: Hedda Eriksson
// Date: 2023-10-09 
// Malmö University, Bachelor of Engineering - Computer Science & Telecommunications
// info: base class Person, contains information about a person

using RealEstateBLL.RealEstate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateBLL.Persons
{
    [Serializable]
    public class Person
    {
        private string firstName;
        private string lastName;
        private string phoneNbr;
        private string email;
        private string bank;
        private Address address;


        //default constructor
        public Person()
        {
            firstName = "Jane";
            lastName = "doe";
            phoneNbr = "";
            email = "";
            address = new Address();
            bank = "";
        }
        //First constructor
        public Person (string firstName, string lastName, string phoneNbr, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNbr = phoneNbr;
            this.email = email;
        }
        
        //Second constructor
        public Person (string firstName, string lastName, string phoneNbr, string email, Address address, string bank)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNbr = phoneNbr;
            this.email = email;
            this.address = address;
            this.bank = bank;
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1} {2}Phone: {3} {4}Email: {5} {6}Address: {7} {8}Bank: {9} ", 
                firstName, lastName, Environment.NewLine, phoneNbr, Environment.NewLine, email, Environment.NewLine, 
                address.ToString(), Environment.NewLine, bank);
        }


        //GETTERS & SETTERS
        public string FirstName
        { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string PhoneNbr { get => phoneNbr; set => phoneNbr = value; }
        public string Email { get => email; set => email = value; }
        public Address Address { get => address; set => address = value; }
        public string Bank { get => bank; set => bank = value; }
    }
}
