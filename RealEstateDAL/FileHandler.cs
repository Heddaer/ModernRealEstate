// Author: Hedda Eriksson
// Date: 2023-10-05 
// Malmö University, Bachelor of Engineering - Computer Science & Telecommunications
// info: This class, named FileHandler<T>, is responsible for handling the serialization
// and deserialization of objects of type T to and from binary and XML files. 
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;


namespace RealEstateDAL
{
    public class FileHandler<T> : IFileHandler<T>
    {
        public FileHandler () 
        {
        }

        public T BinaryDeSerialize<T>(string filePath, out string errorMsg)
        {
            FileStream fileStream = null;
            object? obj = null;
            errorMsg = string.Empty;

            try
            {
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException("The file is not found. ", filePath);
                }
                fileStream = new FileStream(filePath, FileMode.Open);

                BinaryFormatter b = new BinaryFormatter();
                obj = b.Deserialize(fileStream);


            }
            catch (FileNotFoundException e)
            {
                errorMsg = e.Message;
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }
            return (T)obj;
        }


        public bool BinarySerialize(string filePath, List<T> m_list)
        {
            FileStream? fileStream = null;
            bool ok = true;
            try
            {
                fileStream = new FileStream(filePath, FileMode.Create);
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(fileStream, m_list);
            }
            catch (Exception e)
            {
                string errorMsg = e.Message;

            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }
            return ok;
        }

        public bool XMLSerialize(string filePath, List<T> m_list)
        {
            bool ok = true;

            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            TextWriter writer = new StreamWriter(filePath);
            try
            {
                serializer.Serialize(writer, m_list);
            }
            catch (Exception)
            {
                ok = false;
                throw;
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }

            return ok;
        }

        public T XMLDeserialize<T>(string filePath)
        {
            object? obj = null;
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            TextReader? reader = null;

            try
            {
                reader = new StreamReader(filePath);
                obj = (T)serializer.Deserialize(reader);
            }
            catch
            {

            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return (T)obj;
        }
    }
}