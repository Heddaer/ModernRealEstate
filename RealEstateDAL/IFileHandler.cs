using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateDAL
{
    interface IFileHandler<T>
    {
        bool BinarySerialize(string filePat, List<T> m_list);
        T BinaryDeSerialize<T>(string filePath, out string errorMsg);
        bool XMLSerialize(string filePath, List<T> m_list);

        T XMLDeserialize<T>(string filePath);
    }
}
