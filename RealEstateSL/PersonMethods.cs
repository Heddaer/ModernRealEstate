// Author: Hedda Eriksson
// Date: 2023-10-05 
// Malmö University, Bachelor of Engineering - Computer Science & Telecommunications
// info: Partial class containing methods responsible for Person objects within EstateService. 
using RealEstateBLL.Persons;
using RealEstateDTO;


namespace RealEstateSL
{
    public partial class EstateService
    {
        public Person GetPersonAt(string id)
        {
            return clientManager.GetAt(id);
        }

        public Person AddPerson(AddressDTO addressDTO, PersonDTO personDTO, string id, out string errorMsg)
        {
            errorMsg = string.Empty;
            Person person = null;
            if (ValidatePersonInput(addressDTO, personDTO, out errorMsg))
            {
                person = DTOToPersonObject(personDTO, addressDTO, id);
            }
            return person;
        }

    }
}
