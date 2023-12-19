// Author: Hedda Eriksson
// Date: 2023-10-05 
// Malmö University, Bachelor of Engineering - Computer Science & Telecommunications
// info: Partial class containing methods responsible for input validation tasks within EstateService.

using RealEstateBLL.RealEstate;
using RealEstateDTO;

namespace RealEstateSL
{
    public partial class EstateService
    {
        private bool ValidatePersonInput(AddressDTO addressDTO, PersonDTO personDTO, out string errorMsg)
        {
            bool inputOk = false;
            errorMsg = string.Empty;
            if ((!string.IsNullOrEmpty(personDTO.FirstName)) && (!string.IsNullOrEmpty(personDTO.LastName)) &&
                (!string.IsNullOrEmpty(personDTO.PhoneNbr)) && (!string.IsNullOrEmpty(personDTO.Email)) &&
                (!string.IsNullOrEmpty(personDTO.Bank)) && (!string.IsNullOrEmpty(addressDTO.Street)) &&
                (!string.IsNullOrEmpty(addressDTO.ZipCode)) && (!string.IsNullOrEmpty(addressDTO.City)))
            {

                inputOk = true;

                if (personDTO.PersonType == "Lessor")
                {
                    inputOk = (personDTO.CompanyName != string.Empty);

                    if (!inputOk)
                    {
                        errorMsg = "Missing input";
                    }
                }
            }
            else
            {
                errorMsg = "Missing input";
            }
            return inputOk;
        }
        private bool ValidateEstateInput(EstateDTO estateDTO, AddressDTO addressDTO, out string errorMsg)
        {
            bool inputOk = false;
            errorMsg = string.Empty;
            if ((!string.IsNullOrEmpty(estateDTO.EstateArea)) && (!string.IsNullOrEmpty(addressDTO.Street)) &&
                    (!string.IsNullOrEmpty(addressDTO.ZipCode)) && (!string.IsNullOrEmpty(addressDTO.City)) &&
                    (estateDTO.EstateType != EstateType.Other))
            {
                inputOk = true;
                if (estateDTO.EstateType == EstateType.School)
                {
                    if ((string.IsNullOrEmpty(estateDTO.NbrOfClassrooms)) || (estateDTO.ContractType == ContractType.Rental))
                    {
                        errorMsg = "classrooms or type of contract";
                        inputOk = false;
                    }
                }
                else if (estateDTO.EstateType == EstateType.Warehouse)
                {
                    if (estateDTO.ContractType == ContractType.Rental)
                    {
                        errorMsg = "type of contract";
                        inputOk = false;
                    }
                }
                else if (estateDTO.EstateType == EstateType.Apartment || estateDTO.EstateType == EstateType.Cabin || estateDTO.EstateType == EstateType.Studio || estateDTO.EstateType == EstateType.Villa)
                {
                    if ((string.IsNullOrEmpty(estateDTO.NbrOfRooms)) || (estateDTO.ContractType == ContractType.Lease))
                    {
                        errorMsg = "number of rooms or type of contract";
                        inputOk = false;
                    }
                }
            }
            else
            {
                errorMsg = "check Estate info";
            }
            return inputOk;
        }

    }
}
