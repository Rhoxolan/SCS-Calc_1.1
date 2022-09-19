namespace SCSCalcClassLibrary
{
    //Класс для взаимодействия с настраиваемыми параметрами расчета конфигурации СКС
    public class SettingsPresent
    {
        private SettingsLocator settingsLocator;

        public SettingsPresent()
        {
            settingsLocator = new();
        }

        public double GetTechnologicalReserve() => settingsLocator.GetTechnologicalReserve();

        public double GetMinPermanentLink(double minPermanentLink) => settingsLocator.GetMinPermanentLink(minPermanentLink);

        public double GetMaxPermanentLink(double maxPermanentLink) => settingsLocator.GetMaxPermanentLink(maxPermanentLink);

        public int GetNumberOfPorts(int numberOfPorts) => settingsLocator.GetNumberOfPorts(numberOfPorts);

        public void SetStrictСomplianceWithTheStandart() => settingsLocator.SetStrictСomplianceWithTheStandart();

        public void SetNonStrictСomplianceWithTheStandart() => settingsLocator.SetNonStrictСomplianceWithTheStandart();

        public void SetNotAnArbitraryNumberOfPorts() => settingsLocator.SetNotAnArbitraryNumberOfPorts();

        public void SetAnArbitraryNumberOfPorts() => settingsLocator.SetAnArbitraryNumberOfPorts();

        public void SetTechnologicalReserveAvailability() => settingsLocator.SetTechnologicalReserveAvailability();

        public void SetNonTechnologicalReserve() => settingsLocator.SetNonTechnologicalReserve();

        public void SetTechnologicalReserve(double value) => settingsLocator.SetTechnologicalReserve(value);

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
