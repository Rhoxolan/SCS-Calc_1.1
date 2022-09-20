namespace SCSCalcClassLibrary
{
    internal class NonStrictСomplianceWithTheStandart : IStrictСomplianceWithTheStandart
    {
        public (decimal Min, decimal Max) MinPermanentLinkDiapason
        {
            get
            {
                return (0.01M, 1000M);
            }
        }

        public (decimal Min, decimal Max) MaxPermanentLinkDiapason
        {
            get
            {
                return (0.01M, 1000M);
            }
        }
    }
}
