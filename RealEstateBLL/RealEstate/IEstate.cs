// Author: Hedda Eriksson
// Date: 2023-10-09 
// Malmö University, Bachelor of Engineering - Computer Science & Telecommunications
// info: Interface
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateBLL.RealEstate
{
    public interface IEstate
    {

        string EstateID { get; set; }

        int Area { get; set; }

        ContractType ContractType { get; set; }

        string ImageLocation { get; set; }

    }
}
