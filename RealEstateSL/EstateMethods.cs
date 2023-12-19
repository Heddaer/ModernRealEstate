// Author: Hedda Eriksson
// Date: 2023-10-05 
// Malmö University, Bachelor of Engineering - Computer Science & Telecommunications
// info: Partial class containing methods responsible for Estate objects within EstateService. 
using RealEstateBLL.Persons;
using RealEstateBLL.RealEstate;
using RealEstateBLL.RealEstate.Commercials;
using RealEstateBLL.RealEstate.Insititutionals;
using RealEstateBLL.RealEstate.Residentials;
using RealEstateDTO;
using UtilitiesLibrary;


namespace RealEstateSL
{
    public partial class EstateService
    {
        /// <summary>
        /// Retrives a list of estate IDs and counts the number of estates.
        /// </summary>
        /// <returns>A string array of estate IDs.</returns>
        public string[] EstateList()
        {
            return estateManager.ToIDStringArray();
        }

        public Estate GetEstateAt(int index)
        {
            return estateManager.GetAt(index);
        }

        public EstateDTO GetEstateDTOAt(int index)
        {
            return EstateObjectToDTO(estateManager.GetAt(index));
        }

        public int CountEstates()
        {
            return estateManager.Count;
        }
        public bool AddEstate(EstateDTO estateDTO, AddressDTO addressDTO, PersonDTO personDTO, AddressDTO personalAddressDTO, out string errorMsg)
        {
            errorMsg = string.Empty;
            string errorMsg2 = string.Empty;
            bool ok = false;
            estateId = estateDTO.EstateType.ToString() + random.Next(1, 100);

            if (ValidateEstateInput(estateDTO, addressDTO, out errorMsg))
            {
                Person person = AddPerson(personalAddressDTO, personDTO, estateId, out errorMsg2);
                DTOToEstateObject(estateDTO, addressDTO, person);
                ok = true;
            }
            return ok;
        }

        public bool DeleteEstateObject(string id, int index, out string errorMsg)
        {
            bool ok = false;
            errorMsg = string.Empty;
            if ((id != null) && (estateManager.CheckIndex(index)))
            {
                bool estateOk = estateManager.DeleteAt(index);
                bool clientOk = clientManager.DeleteAt(id, out errorMsg);
                if (errorMsg == "!key")
                {
                    clientOk = true;
                }
                if (estateOk && clientOk)
                {
                    ok = true;
                }
                else { errorMsg = "Could not delete object"; }
            }
            else { errorMsg = "Choose an object to delete."; }
            return ok;
        }

        public bool ChangeEstateObject(int index, EstateDTO estateDTO, AddressDTO addressDTO, out string errorMsg)
        {
            bool ok = false;
            errorMsg = string.Empty;

            Estate obj = estateManager.GetAt(index);

            if (obj != null)
            {
                if (obj.GetType().Name == estateDTO.EstateType.ToString())
                {

                    obj.Area = StringConverter.StringToInteger(estateDTO.EstateArea, out errorMsg);
                    obj.ContractType = estateDTO.ContractType;
                    obj.EstateAddress = DTOToAddressObject(addressDTO, out errorMsg);

                    switch (obj.GetType().Name)
                    {
                        case "Villa":
                            Villa villa = (Villa)obj;
                            villa.NbrOfRooms = StringConverter.StringToInteger(estateDTO.NbrOfRooms, out errorMsg);
                            villa.Pool = estateDTO.Pool;
                            villa.Garage = estateDTO.Garage;
                            break;
                        case "Cabin":
                            Cabin cabin = (Cabin)obj;
                            cabin.NbrOfRooms = StringConverter.StringToInteger(estateDTO.NbrOfRooms, out errorMsg);
                            cabin.Pool = estateDTO.Pool;
                            cabin.Garage = estateDTO.Garage;
                            cabin.CloseLake = estateDTO.CloseLake;
                            break;
                        case "Apartment":
                            Apartment aprt = (Apartment)obj;
                            aprt.NbrOfRooms = StringConverter.StringToInteger(estateDTO.NbrOfRooms, out errorMsg);
                            aprt.Balcony = estateDTO.Balcony;
                            break;
                        case "Studio":
                            Studio studio = (Studio)obj;
                            studio.NbrOfRooms = StringConverter.StringToInteger(estateDTO.NbrOfRooms, out errorMsg);
                            studio.Balcony = estateDTO.Balcony;
                            studio.Kitchentte = estateDTO.Kitchentte;
                            break;
                        case "Warehouse":
                            Warehouse warehouse = (Warehouse)obj;
                            warehouse.ColdStorageRoom = estateDTO.ColdStorageRoom;
                            warehouse.WType = estateDTO.WarehouseType;
                            break;
                        case "School":
                            School school = (School)obj;
                            school.Purpose = estateDTO.Purpose;
                            school.NbrOfClassrooms = StringConverter.StringToInteger(estateDTO.NbrOfClassrooms, out errorMsg);
                            school.Cafeteria = estateDTO.Cafeteria;
                            school.SportsCenter = estateDTO.SportsCenter;
                            break;
                    }
                    ok = true;
                }
                else { errorMsg = "You are not allowed to change type of object"; }
            }
            else { errorMsg = "Object doesnt exist..."; }

            return ok;
        }
    }
}
