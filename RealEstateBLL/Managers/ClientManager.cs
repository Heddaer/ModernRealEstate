// Author: Hedda Eriksson
// Date: 2023-28-09 
// Malmö University, Bachelor of Engineering - Computer Science & Telecommunications
// info: ClientManager inherit DictionaryManager
using RealEstateBLL.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateBLL.Managers
{
    public class ClientManager : DictionaryManager <string, Person>
    {
        public ClientManager() { }
    }
}
