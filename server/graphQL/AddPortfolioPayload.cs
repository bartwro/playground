namespace server.graphQL
{
    public class AddPortfolioPayload
    {
        public Portfolio Portfolio { get; }

        public AddPortfolioPayload(Portfolio portfolio)
        {
            this.Portfolio = portfolio;
        }
    }
}
