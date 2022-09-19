namespace SCSCalcClassLibrary
{
    //Класс, применяемый для работы с определенными параметрами без строгого соответствия стандарту ISO/IEC 11801
    internal class NonStrictСomplianceWithTheStandart : IStrictСomplianceWithTheStandart
    {
        public double GetMaxPermanentLink(double maxPermanentLink)
        {
            return maxPermanentLink;
        }

        public double GetMinPermanentLink(double minPermanentLink)
        {
            return minPermanentLink;
        }
    }
}
