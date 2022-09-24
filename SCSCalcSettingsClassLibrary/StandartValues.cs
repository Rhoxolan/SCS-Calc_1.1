namespace SCSCalc.Settings
{
    //Класс, предназначенный для работы с вводимыми параметрами конфигураций СКС. В первую очередь предназначен для определения допустимых рамок вводимых значений.
    //Инкапсулирован в класс SettingsLocator.
    internal class StandartValues : IStandartValues
    {
        public (decimal Min, decimal Max) NumberOfWorkplacesDiapason
        {
            get
            {
                return (1M, 10000M);
            }
        }

        public (decimal Min, decimal Max) CableHankMeterageDiapason
        {
            get
            {
                return (0.01M, 10000M);
            }
        }

        public (decimal Min, decimal Max) TechnologicalReserveDiapason
        {
            get
            {
                return (1M, 2M);
            }
        }
    }
}
