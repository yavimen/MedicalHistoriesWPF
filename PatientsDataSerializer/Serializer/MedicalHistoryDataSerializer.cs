using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using PatientsDataSerializer.DataModels;

namespace PatientsDataSerializer.Serializer
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
