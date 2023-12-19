// Author: Hedda Eriksson
// Date: 2023-28-09 
// Malmö University, Bachelor of Engineering - Computer Science & Telecommunications
// info: Base class for dictionary<t> collections
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateBLL.Managers
{
    public class DictionaryManager<Tkey, Tvalue> : IDictionaryManager<Tkey, Tvalue>
    {
        private Dictionary<Tkey, Tvalue> m_dict;
        public DictionaryManager() 
        {
            m_dict = new Dictionary<Tkey, Tvalue>();
        }
        public int Count 
        {
            get { return m_dict.Count(); }
        }

        public bool Add(Tkey key, Tvalue value)
        {
            return m_dict.TryAdd(key, value);
        }

        public bool CheckKey(Tkey key)
        {
            return m_dict.ContainsKey(key);
        }

        public void DeleteAll()
        {
            m_dict.Clear();
        }

        public bool DeleteAt(Tkey key, out string errorMsg)
        {
            bool ok = false;
            errorMsg = string.Empty;
            if (m_dict.ContainsKey(key))
            { 
                ok = m_dict.Remove(key);

            }
            else
            {
                errorMsg = "!key";
                ok = false;
            }
            return ok;
        }

        public Tvalue GetAt(Tkey key)
        {
            //object obj = null;
            if (CheckKey(key))
            {
                return m_dict[key];
            }
            return default(Tvalue);
        }
    }
}
