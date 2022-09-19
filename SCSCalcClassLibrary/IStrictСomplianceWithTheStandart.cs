namespace SCSCalcClassLibrary
{
    //Интерфейс для определения соответствия стандарту ISO/IEC 11801 в настройках
    internal interface IStrictСomplianceWithTheStandart
    {
        public double GetMinPermanentLink(double minPermanentLink);
        public double GetMaxPermanentLink(double maxPermanentLink);
    }
}
