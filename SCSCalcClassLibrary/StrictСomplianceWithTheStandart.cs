namespace SCSCalcClassLibrary
{
    internal class StrictСomplianceWithTheStandart : IStrictСomplianceWithTheStandart
    {
        public (decimal Min, decimal Max) MinPermanentLinkDiapason
        {
            get
            {
                return (1M, 90M);
            }
        }

        public (decimal Min, decimal Max) MaxPermanentLinkDiapason
        {
            get
            {
                return (1M, 90M);
            }
        }
    }
}
