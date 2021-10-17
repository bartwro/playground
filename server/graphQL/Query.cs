using System;

namespace server.graphQL
{
    public class Query
    {
        public Portfolio GetPortfolio() =>
            new Portfolio {
                Id = Guid.NewGuid(),
                Name = "BS-long",
                Positions = new[] {
                    new Position
                    {
                        StockSymbol = "MSFT",
                        Units = 10
                    } 
                }
            };
    }
}
