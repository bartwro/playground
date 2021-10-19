using System;
namespace server.graphQL
{
    public record AddPortfolioInput(
        string Name,
        Position[] Positions);
}
