using RealEstateBLL.Persons;
using RealEstateBLL.RealEstate;
using RealEstateBLL.RealEstate.Commercials;
using RealEstateBLL.RealEstate.Insititutionals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateDTO
{
    public class EstateDTO
    {
        public ContractType ContractType { get; set; }
        public string? EstateArea { get; set; }
        public string? ImageLocation { get; set; }
        public EstateType EstateType { get; set; }

        public string InfoString { get; set; }

        //Residential
        public string? NbrOfRooms { get; set; }
        public bool Garage { get; set; }
        public bool Pool { get; set; }
        public bool Balcony { get; set; }
        public bool CloseLake { get; set; }
        public bool Kitchentte { get; set; }

        //Institutional
        public PurposeType Purpose { get; set; }
        public string? NbrOfClassrooms { get; set; }
        public bool Cafeteria { get; set; }
        public bool SportsCenter { get; set; }

        //Commericals
        public bool ColdStorageRoom { get; set; }
        public WarehouseType WarehouseType { get; set; }


    }
}
