namespace SCSCalcClassLibrary
{
    internal class NotAnArbitraryNumberOfPorts : IAnArbitraryNumberOfPorts
    {
        public (decimal Min, decimal Max) NumberOfPortsDiapason
        {
            get
            {
                return (2M, 100M);
            }
        }
    }
}
