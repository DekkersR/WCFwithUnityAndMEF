using System.Runtime.Serialization;

namespace DEMO.Service
{
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class TodoDto
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public bool Finished { get; set; }
    }
}
