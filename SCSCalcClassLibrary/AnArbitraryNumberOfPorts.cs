namespace SCSCalcClassLibrary
{
    internal class AnArbitraryNumberOfPorts : IAnArbitraryNumberOfPorts
    {
        public (decimal Min, decimal Max) NumberOfPortsDiapason
        {
            get
            {
                return (1M, 100M);
            }
        }
    }
}
