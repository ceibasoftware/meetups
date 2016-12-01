namespace Ceiba.OrleansStart.Comms
{
    using System.Runtime.Serialization;

    [DataContract]
    public class StockQuota
    {
        [DataMember( Name = "Name" )]
        public string Company { get; set; }

        [DataMember]
        public string Symbol { get; set; }

        public string Exchange { get; set; }

        [DataMember( Name = "LastPrice" )]
        public decimal Price { get; set; }

        [DataMember]
        public decimal Change { get; set; }
    }
}
