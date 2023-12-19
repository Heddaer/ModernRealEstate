using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstateBLL.RealEstate;
using RealEstateBLL.RealEstate.Commercials;
using RealEstateBLL.RealEstate.Insititutionals;
using RealEstateBLL.RealEstate.Residentials;

namespace UtilitiesLibrary
{
    public  class CustomTypes
    {
        public static EstateType TryGetEstateType(Estate estate, out bool ok)
        {
            EstateType type = EstateType.Other;
            ok = false;

            if (estate is Apartment)
            {
               type = EstateType.Apartment;
                ok = true;
                if (estate is Studio)
                {
                    type = EstateType.Studio;
                    ok = true;
                }
            }
            else if (estate is Villa)
            {
                type = EstateType.Villa;
                ok = true;
                if (estate is Cabin)
                {
                    type = EstateType.Cabin;
                    ok = true;
                }
            }
            else if (estate is School)
            {
                type = EstateType.School;
                ok = true;
            }
            else if (estate is Warehouse)
            {
                type = EstateType.Warehouse;
                ok = true;
            }
            return type;
        }
    }
}
