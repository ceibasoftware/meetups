namespace Ceiba.OrleansStart.Comms
{
    using System.Runtime.Serialization;

    [DataContract]
    public class Company
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Symbol { get; set; }
    }
}
