namespace SCSCalc.Settings
{
    //Класс для работы с параметром количества портов на 1 рабочее место при допустимом произвольном количестве.
    //В первую очередь предназначен для определения допустимых рамок вводимого значения. Инкапсулирован в класс SettingsLocator.
    internal class AnArbitraryNumberOfPorts : IAnArbitraryNumberOfPorts
    {
        public (decimal Min, decimal Max) NumberOfPortsDiapason
        {
            get
            {
                return (1M, 100M);
            }
        }
    }
}
