namespace SCSCalcClassLibrary
{
    //Интерфейс для работы с параметром количества портов на 1 рабочее место. В первую очередь предназначен для определения допустимых рамок вводимого значения.
    //Инкапсулирован в класс SettingsLocator.
    internal interface IAnArbitraryNumberOfPorts
    {
        public (decimal Min, decimal Max) NumberOfPortsDiapason { get; }
    }
}
