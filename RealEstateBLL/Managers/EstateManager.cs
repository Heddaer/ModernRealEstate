// Author: Hedda Eriksson
// Date: 2023-09-28 
// Malmö University, Bachelor of Engineering - Computer Science & Telecommunications
// info: EstateManager is a list manager for estate objects
using RealEstateBLL.RealEstate;
using RealEstateDAL;

namespace RealEstateBLL.Managers
{
    public class EstateManager : ListManager<Estate>
    {
        private FileHandler<Estate> fileHandler = new FileHandler<Estate>();
        
        public EstateManager() {}

        public string[] ToIDStringArray()
        {
            string[] strOut = new string[Count];
            Estate obj = null;
            for (int i = 0; i < strOut.Length; i++)
            {
                obj = GetAt(i);
                strOut[i] += obj.EstateID;
            }
            return strOut; 
        }

        public bool SaveDataToFile(string fileName, FileTypes fileExt, out string errorMsg)
        {
            bool ok = true;
            errorMsg = string.Empty;

            switch (fileExt)
            {
                case FileTypes.dat:
                    ok = fileHandler.BinarySerialize(fileName, List);
                    break;
                case FileTypes.xml:
                    ok = fileHandler.XMLSerialize(fileName, List);
                    break;
                default:
                    errorMsg = "Unknown file type!";
                    ok = false;
                    break;
            }
            return ok;
        }

        public bool ReadDataFromFile(string filePath, FileTypes fileExt, out string errorMsg)
        {
            bool ok = true;
            errorMsg = string.Empty;

            switch (fileExt)
            {
                case FileTypes.xml:
                    List = fileHandler.XMLDeserialize<List<Estate>>(filePath);
                    break;
                case FileTypes.dat:
                   List = fileHandler.BinaryDeSerialize<List<Estate>>(filePath, out errorMsg);
                    if (errorMsg != string.Empty)
                        ok = false;
                    break;
                default:
                    errorMsg = "Unknown file type!";
                    ok = false;
                    break;
            }
            return ok;
        }
    }

}
