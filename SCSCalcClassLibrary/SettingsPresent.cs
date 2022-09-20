namespace SCSCalcClassLibrary
{

    public class SettingsPresent
    {
        private SettingsLocator settingsLocator;

        public SettingsPresent()
        {
            settingsLocator = new();
        }

        public ((decimal Min, decimal Max) MinPermanentLinkDiapason, (decimal Min, decimal Max) MaxPermanentLinkDiapason, (decimal Min, decimal Max) NumberOfPortsDiapason,
            (decimal Min, decimal Max) NumberOfWorkplacesDiapason, (decimal Min, decimal Max) CableHankMeterageDiapason, (decimal Min, decimal Max) TechnologicalReserveDiapason ) Diapasons
        {
            get
            {
                return (settingsLocator.MinPermanentLinkDiapason, settingsLocator.MaxPermanentLinkDiapason, settingsLocator.NumberOfPortsDiapason,
                    settingsLocator.NumberOfWorkplacesDiapason, settingsLocator.CableHankMeterageDiapason, settingsLocator.TechnologicalReserveDiapason);
            }
        }

        public double TechnologicalReserve
        {
            get => settingsLocator.TechnologicalReserve;
            set => settingsLocator.TechnologicalReserve = value;
        }

        public void SetStrictСomplianceWithTheStandart() => settingsLocator.SetStrictСomplianceWithTheStandart();

        public void SetNonStrictСomplianceWithTheStandart() => settingsLocator.SetNonStrictСomplianceWithTheStandart();

        public void SetNotAnArbitraryNumberOfPorts() => settingsLocator.SetNotAnArbitraryNumberOfPorts();

        public void SetAnArbitraryNumberOfPorts() => settingsLocator.SetAnArbitraryNumberOfPorts();

        public void SetTechnologicalReserveAvailability() => settingsLocator.SetTechnologicalReserveAvailability();

        public void SetNonTechnologicalReserve() => settingsLocator.SetNonTechnologicalReserve();

        public bool IsStrictСomplianceWithTheStandart
        {
            get => settingsLocator.IsStrictСomplianceWithTheStandart;
        }

        public bool IsAnArbitraryNumberOfPorts
        {
            get => settingsLocator.IsAnArbitraryNumberOfPorts;
        }

        public bool IsTechnologicalReserveAvailability
        {
            get => settingsLocator.IsTechnologicalReserveAvailability;
        }

    }
}
