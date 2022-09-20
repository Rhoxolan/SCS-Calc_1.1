namespace SCSCalcClassLibrary
{
    //Класс для работы с параметром количества портов на 1 рабочее место с учетом требований стандарта ISO/IEC 11801.
    //В первую очередь предназначен для определения допустимых рамок вводимого значения. Инкапсулирован в класс SettingsLocator.
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
