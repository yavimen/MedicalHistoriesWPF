using System.IO;
using System.Runtime.Serialization;
using MedicalHistories.DataModels;

namespace MedicalHistories.Serializer
{
    public class MedicalHistoryDataSerializer
    {
        static public void Serialize(string fileName, DataModel data) 
        {
            var formatter = new DataContractSerializer(typeof(DataModel));
            var s = new FileStream(fileName, FileMode.Create);
            formatter.WriteObject(s, data);
            s.Close(); 
        }

        static public DataModel DeserializeItem(string fileName) 
        {
            var formatter = new DataContractSerializer(typeof(DataModel));
            var s = new FileStream(fileName, FileMode.Open);

            return (DataModel)formatter.ReadObject(s);
        }
    }
}
