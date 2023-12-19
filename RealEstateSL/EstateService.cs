// Author: Hedda Eriksson
// Date: 2023-10-05 
// Malmö University, Bachelor of Engineering - Computer Science & Telecommunications
// info: EstateService is responsible for coordinating actions related to real estate
// and clients, handling data validation and performing necessary operations.

using RealEstateDTO;
using RealEstateBLL.RealEstate;
using RealEstateBLL.RealEstate.Commercials;
using RealEstateBLL.RealEstate.Insititutionals;
using RealEstateBLL.RealEstate.Residentials;
using RealEstateBLL.Persons;
using RealEstateBLL.Managers;
using System;

namespace RealEstateSL
{
    public partial class EstateService
    {
        private Random random = new Random();
        private EstateManager estateManager = new EstateManager();
        private ClientManager clientManager = new ClientManager();
        private string estateId;

        public EstateService() {}


        
        public AddressDTO GetAddressDTOAt(int index)
        {
            return AddressObjectToDTO(estateManager.GetAt(index));
        }

        /// <summary>
        /// Deletes all data related to estates and clients
        /// </summary>
        public void DeleteAllData()
        {
            estateManager.DeleteAll();
            clientManager.DeleteAll();
        }

    }

}