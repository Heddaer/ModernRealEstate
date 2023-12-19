using RealEstateDTO;


namespace RealEstateSL
{
    public partial class EstateService
    {
        public bool SaveFile(FileDTO fileDTO, out string errorMsg)
        {
            bool ok = false;
            errorMsg = string.Empty;

            if (estateManager.SaveDataToFile(fileDTO.FileName, fileDTO.FileType, out errorMsg))
            {
                ok = true;
            }

            return ok;
        }
        public bool readFile(FileDTO fileDTO, out string errorMsg)
        {
            bool ok = false;
            errorMsg = string.Empty;

            if (estateManager.ReadDataFromFile(fileDTO.FileName, fileDTO.FileType, out errorMsg))
            {
                ok = true;
            }

            return ok;
        }
    }
}
