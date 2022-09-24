namespace SCSCalc.Settings
{
    //Класс для работы с вводимыми параметрами расчёта в строгом соответствии стандарту ISO/IEC 11801. В первую очередь
    //предназначен для определения допустимых рамок значений ввода. Инкапсулирован в класс SettingsLocator.
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
