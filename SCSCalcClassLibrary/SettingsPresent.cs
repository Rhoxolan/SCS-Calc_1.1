using System.Text.Json;

namespace SCSCalcClassLibrary
{
    //Класс, предоставляющий для других классов приложения доступ к настраиваемым параметрам вводимых значений конфигураций СКС.
    public class SettingsPresent
    {
        private SettingsLocator settingsLocator;

        public SettingsPresent()
        {
            settingsLocator = new();
        }

        public static void SettingsJSONSerializer(SettingsPresent settingsPresent, string settingsDocPath)
        {
            (bool IsStrictСomplianceWithTheStandart, bool IsAnArbitraryNumberOfPorts, bool IsTechnologicalReserveAvailability,
                double TechnologicalReserve) settingsParameters = new();

            settingsParameters.IsStrictСomplianceWithTheStandart = true ? settingsPresent.IsStrictСomplianceWithTheStandart
                : settingsParameters.IsStrictСomplianceWithTheStandart = false;

            settingsParameters.IsAnArbitraryNumberOfPorts = true ? settingsPresent.IsAnArbitraryNumberOfPorts
                : settingsParameters.IsAnArbitraryNumberOfPorts = false;

            settingsParameters.IsTechnologicalReserveAvailability = true ? settingsPresent.IsTechnologicalReserveAvailability
                : settingsParameters.IsTechnologicalReserveAvailability = false;

            settingsParameters.TechnologicalReserve = settingsPresent.TechnologicalReserve;

            using FileStream fs = new(settingsDocPath, FileMode.Create);
            JsonSerializerOptions options = new()
            {
                IncludeFields = true
            };
            JsonSerializer.Serialize(fs, settingsParameters, options);
        }

        public static SettingsPresent SettingsJSONDeserializer(string settingsDocPath)
        {
            (bool IsStrictСomplianceWithTheStandart, bool IsAnArbitraryNumberOfPorts, bool IsTechnologicalReserveAvailability,
                double TechnologicalReserve) settingsParameters;
            SettingsPresent settingsPresent = new();

            using FileStream fs = new(settingsDocPath, FileMode.Open);
            JsonSerializerOptions options = new()
            {
                IncludeFields = true
            };
            settingsParameters = JsonSerializer.Deserialize<(bool, bool, bool, double)>(fs, options);

            if(settingsParameters.IsStrictСomplianceWithTheStandart)
            {
                settingsPresent.SetStrictСomplianceWithTheStandart();
            }
            else
            {
                settingsPresent.SetNonStrictСomplianceWithTheStandart();
            }

            if(settingsParameters.IsAnArbitraryNumberOfPorts)
            {
                settingsPresent.SetAnArbitraryNumberOfPorts();
            }
            else
            {
                settingsPresent.SetNotAnArbitraryNumberOfPorts();
            }

            if(settingsParameters.IsTechnologicalReserveAvailability)
            {
                settingsPresent.SetTechnologicalReserveAvailability();
                settingsPresent.TechnologicalReserve = settingsParameters.TechnologicalReserve;
            }
            else
            {
                settingsPresent.SetNonTechnologicalReserve();
            }

            return settingsPresent;
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
