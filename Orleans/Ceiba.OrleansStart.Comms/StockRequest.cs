namespace Ceiba.OrleansStart.Comms
{
    using System;
    using System.Collections.Generic;
    using Orleans.Concurrency;

    [Immutable]
    public class StockRequest
    {
        public StockRequest()
        {
            this.Stocks = new HashSet<Stock>();
        }

        public Guid TraderId { get; set; }

        public HashSet<Stock> Stocks { get; private set; }
    }
}
