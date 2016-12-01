namespace Ceiba.OrleansStart.Comms
{
    using System;

    [Serializable]
    public class Stock
    {
        public string Symbol { get; set; }

        public string Provider { get; set; }

        public StockQuota Quota { get; set; }
    }
}
