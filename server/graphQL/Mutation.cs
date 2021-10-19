using System;
using System.Threading.Tasks;

namespace server.graphQL
{
    public class Mutation
    {
        public AddPortfolioPayload AddMutation(AddPortfolioInput input)
        {
            return new AddPortfolioPayload
            (
                new Portfolio
                {
                    Id = Guid.NewGuid(),
                    Name = input.Name,
                    Positions = input.Positions
                }
            );
        }
    }
}
