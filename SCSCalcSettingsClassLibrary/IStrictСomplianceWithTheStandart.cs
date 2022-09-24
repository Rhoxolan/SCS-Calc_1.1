namespace SCSCalc.Settings
{
    //Интерфейс для работы с вводимыми параметрами расчёта в соответствии стандарту ISO/IEC 11801.
    //В первую очередь определяет допустимые рамки значений ввода. Инкапсулирован в класс SettingsLocator.
    internal interface IStrictСomplianceWithTheStandart
    {
        public (decimal Min, decimal Max) MinPermanentLinkDiapason { get; }
        public (decimal Min, decimal Max) MaxPermanentLinkDiapason { get; }
    }
}
