// Author: Hedda Eriksson
// Date: 2023-10-05 
// Malmö University, Bachelor of Engineering - Computer Science & Telecommunications
// info: This partial class within the EstateService is responsible for handling conversions
// between Data Transfer Objects (DTOs) and Estate objects, as well as converting between
// address objects and DTOs. It also includes methods for creating new real estate objects
// based on DTOs.
using RealEstateBLL.Persons;
using RealEstateBLL.RealEstate.Commercials;
using RealEstateBLL.RealEstate.Insititutionals;
using RealEstateBLL.RealEstate.Residentials;
using RealEstateBLL.RealEstate;
using RealEstateDTO;
using UtilitiesLibrary;

namespace RealEstateSL
{
    public partial class EstateService
    {

        private Estate DTOToEstateObject(EstateDTO estateDTO, AddressDTO addressDTO, Person person)
        {
            string errorMsg = string.Empty;
            Estate estate;
            Address address = DTOToAddressObject(addressDTO, out errorMsg);
            switch (estateDTO.EstateType)
            {
                case EstateType.Apartment:
                    estate = new Apartment
                    {
                        EstateID = estateId,
                        ContractType = estateDTO.ContractType,
                        Area = StringConverter.StringToInteger(estateDTO.EstateArea, out errorMsg),
                        ImageLocation = estateDTO.ImageLocation,
                        EstatePerson = person,
                        EstateAddress = address,
                        NbrOfRooms = StringConverter.StringToInteger(estateDTO.NbrOfRooms, out errorMsg),
                        Balcony = estateDTO.Balcony
                    };
                    estate.EstimatedRent(estate.ContractType, estate.Area);
                    break;
                case EstateType.Studio:
                    estate = new Studio
                    {
                        EstateID = estateId,
                        ContractType = estateDTO.ContractType,
                        Area = StringConverter.StringToInteger(estateDTO.EstateArea, out errorMsg),
                        ImageLocation = estateDTO.ImageLocation,
                        EstatePerson = person,
                        EstateAddress = address,
                        NbrOfRooms = StringConverter.StringToInteger(estateDTO.NbrOfRooms, out errorMsg),
                        Balcony = estateDTO.Balcony,
                        Kitchentte = estateDTO.Kitchentte
                    };
                    estate.EstimatedRent(estate.ContractType, estate.Area);
                    break;
                case EstateType.Villa:
                    estate = new Villa
                    {
                        EstateID = estateId,
                        ContractType = estateDTO.ContractType,
                        Area = StringConverter.StringToInteger(estateDTO.EstateArea, out errorMsg),
                        ImageLocation = estateDTO.ImageLocation,
                        EstatePerson = person,
                        EstateAddress = address,
                        NbrOfRooms = StringConverter.StringToInteger(estateDTO.NbrOfRooms, out errorMsg),
                        Garage = estateDTO.Garage,
                        Pool = estateDTO.Pool
                    };
                    estate.EstimatedRent(estate.ContractType, estate.Area);
                    break;
                case EstateType.Cabin:
                    estate = new Cabin
                    {
                        EstateID = estateId,
                        ContractType = estateDTO.ContractType,
                        Area = StringConverter.StringToInteger(estateDTO.EstateArea, out errorMsg),
                        ImageLocation = estateDTO.ImageLocation,
                        EstatePerson = person,
                        EstateAddress = address,
                        NbrOfRooms = StringConverter.StringToInteger(estateDTO.NbrOfRooms, out errorMsg),
                        Garage = estateDTO.Garage,
                        Pool = estateDTO.Pool,
                        CloseLake = estateDTO.CloseLake
                    };
                    estate.EstimatedRent(estate.ContractType, estate.Area);
                    break;
                case EstateType.Warehouse:
                    estate = new Warehouse
                    {
                        EstateID = estateId,
                        ContractType = estateDTO.ContractType,
                        Area = StringConverter.StringToInteger(estateDTO.EstateArea, out errorMsg),
                        ImageLocation = estateDTO.ImageLocation,
                        EstatePerson = person,
                        EstateAddress = address,
                        ColdStorageRoom = estateDTO.ColdStorageRoom,
                        WType = estateDTO.WarehouseType
                    };
                    estate.EstimatedRent(estate.ContractType, estate.Area);
                    break;
                case EstateType.School:
                    estate = new School
                    {
                        EstateID = estateId,
                        ContractType = estateDTO.ContractType,
                        Area = StringConverter.StringToInteger(estateDTO.EstateArea, out errorMsg),
                        ImageLocation = estateDTO.ImageLocation,
                        EstatePerson = person,
                        EstateAddress = address,
                        Purpose = estateDTO.Purpose,
                        NbrOfClassrooms = StringConverter.StringToInteger(estateDTO.NbrOfClassrooms, out errorMsg),
                        Cafeteria = estateDTO.Cafeteria,
                        SportsCenter = estateDTO.SportsCenter
                    };
                    estate.EstimatedRent(estate.ContractType, estate.Area);
                    break;
                default:
                    estate = null;
                    break;
            }
            estateManager.Add(estate);
            return estate;
        }
        private Address DTOToAddressObject(AddressDTO addressDTO, out string errorMsg)
        {
            Address address = new Address
            {
                Street = addressDTO.Street,
                ZipCode = StringConverter.StringToInteger(addressDTO.ZipCode, out errorMsg),
                City = addressDTO.City,
                Country = addressDTO.Country
            };
            return address;
        }
        private Person DTOToPersonObject(PersonDTO personDTO, AddressDTO addressDTO, string id)
        {
            string errorMsg = String.Empty;
            Person? person = null;
            Address address = DTOToAddressObject(addressDTO, out errorMsg);
            switch (personDTO.PersonType)
            {
                case "Seller":
                    person = new Seller
                    {
                        FirstName = personDTO.FirstName,
                        LastName = personDTO.LastName,
                        PhoneNbr = personDTO.PhoneNbr,
                        Email = personDTO.Email,
                        Bank = personDTO.Bank,
                        Address = address,
                        MovingOutDate = personDTO.MovingOutDate,
                        CompanyName = personDTO.CompanyName
                    };
                    break;
                case "Lessor":
                    person = new Lessor
                    {
                        FirstName = personDTO.FirstName,
                        LastName = personDTO.LastName,
                        PhoneNbr = personDTO.PhoneNbr,
                        Email = personDTO.Email,
                        Bank = personDTO.Bank,
                        Address = address,
                        CompanyName = personDTO.CompanyName,
                    };
                    break;
                case "Buyer":
                    person = new Buyer
                    {
                        FirstName = personDTO.FirstName,
                        LastName = personDTO.LastName,
                        PhoneNbr = personDTO.PhoneNbr,
                        Email = personDTO.Email,
                        Bank = personDTO.Bank,
                        Address = address,
                        LoanPromise = personDTO.LoanPromise,
                    };
                    clientManager.Add(id, person);
                    break;
                case "Tenant":
                    person = new Tenant
                    {
                        FirstName = personDTO.FirstName,
                        LastName = personDTO.LastName,
                        PhoneNbr = personDTO.PhoneNbr,
                        Email = personDTO.Email,
                        Bank = personDTO.Bank,
                        Address = address,
                        ApprovedIncome = personDTO.ApprovedIncome
                    };
                    clientManager.Add(id, person);
                    break;
            }

            return person;
        }

        private EstateDTO EstateObjectToDTO(Estate estate)
        {
            bool ok = false;
            EstateDTO estateDTO = new EstateDTO
            {
                ContractType = estate.ContractType,
                EstateArea = estate.Area.ToString(),
                ImageLocation = estate.ImageLocation,
                EstateType = CustomTypes.TryGetEstateType(estate, out ok)
            };

            if ((estate is Villa) || (estate is Cabin))
            {
                Villa villa = (Villa)estate;
                estateDTO.NbrOfRooms = villa.NbrOfRooms.ToString();
                estateDTO.Garage = villa.Garage;
                estateDTO.Pool = villa.Pool;
                estateDTO.InfoString = villa.ToString();

                if (estate is Cabin)
                {
                    Cabin cabin = (Cabin)estate;
                    estateDTO.CloseLake = cabin.CloseLake;
                    estateDTO.InfoString = cabin.ToString();
                }
            }
            else if ((estate is Apartment) || (estate is Studio))
            {
                Apartment apartment = (Apartment)estate;
                estateDTO.NbrOfRooms = apartment.NbrOfRooms.ToString();
                estateDTO.Balcony = apartment.Balcony;
                estateDTO.InfoString = apartment.ToString();

                if (estate is Studio)
                {
                    Studio studio = (Studio)estate;
                    estateDTO.Kitchentte = studio.Kitchentte;
                    estateDTO.InfoString = studio.ToString();
                }
            }
            else if (estate is Warehouse)
            {
                Warehouse warehouse = (Warehouse)estate;
                estateDTO.WarehouseType = warehouse.WType;
                estateDTO.ColdStorageRoom = warehouse.ColdStorageRoom;
                estateDTO.InfoString = warehouse.ToString();
            }
            else if (estate is School)
            {
                School school = (School)estate;
                estateDTO.Cafeteria = school.Cafeteria;
                estateDTO.SportsCenter = school.SportsCenter;
                estateDTO.NbrOfClassrooms = school.NbrOfClassrooms.ToString();
                estateDTO.InfoString = school.ToString();
            }
            return estateDTO;
        }

        private AddressDTO AddressObjectToDTO(Estate estate)
        {
            AddressDTO addressDTO = new AddressDTO
            {
                Street = estate.EstateAddress.Street,
                ZipCode = estate.EstateAddress.ZipCode.ToString(),
                City = estate.EstateAddress.City,
                Country = estate.EstateAddress.Country,
            };

            return addressDTO;
        }
    }
}
