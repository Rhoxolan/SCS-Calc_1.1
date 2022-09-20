namespace SCSCalcClassLibrary
{
    internal interface IStandartValues
    {
        public (decimal Min, decimal Max) NumberOfWorkplacesDiapason { get; }

        public (decimal Min, decimal Max) CableHankMeterageDiapason { get; }

        public (decimal Min, decimal Max) TechnologicalReserveDiapason { get; }
    }
}
