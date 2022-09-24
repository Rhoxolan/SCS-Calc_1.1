namespace SCSCalc.Settings
{
    //Класс для работы с вводимыми параметрами расчёта без строгого соответствия стандарту ISO/IEC 11801. В первую очередь
    //предназначен для определения допустимых рамок значений ввода. Инкапсулирован в класс SettingsLocator.
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
