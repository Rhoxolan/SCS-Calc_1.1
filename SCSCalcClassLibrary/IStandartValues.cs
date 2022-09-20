namespace SCSCalcClassLibrary
{
    //Интерфейс, предназначенный для работы с вводимыми параметрами конфигураций СКС. В первую очередь предназначен для определения допустимых рамок вводимых значений.
    //Инкапсулирован в класс SettingsLocator.
    internal interface IStandartValues
    {
        public (decimal Min, decimal Max) NumberOfWorkplacesDiapason { get; }

        public (decimal Min, decimal Max) CableHankMeterageDiapason { get; }

        public (decimal Min, decimal Max) TechnologicalReserveDiapason { get; }
    }
}
