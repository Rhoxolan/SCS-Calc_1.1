namespace SCSCalcClassLibrary
{
    //Класс, предназначенный для работы с параметрами конфигураций СКС
    public class ConfigurationValues
    {
        private double technologicalReserve;
        private (decimal Min, decimal Max) minPermanentLinkDiapason;
        private (decimal Min, decimal Max) maxPermanentLinkDiapason;
        private (decimal Min, decimal Max) numberOfWorkplacesDiapason;
        private (decimal Min, decimal Max) numberOfPortsDiapason;
        private (decimal Min, decimal Max) cableHankMeterageDiapason;
        private (decimal Min, decimal Max) technologicalReserveDiapason;
        private bool isStrictСomplianceWithTheStandart;
        private bool isAnArbitraryNumberOfPorts;
        private bool isTechnologicalReserveAvailability;

        public ConfigurationValues()
        {
            technologicalReserve = 1.10;
            minPermanentLinkDiapason.Min = 0.01M;
            minPermanentLinkDiapason.Max = 1000M;
            maxPermanentLinkDiapason.Min = 0.01M;
            maxPermanentLinkDiapason.Max = 1000M;
            numberOfWorkplacesDiapason.Min = 1M;
            numberOfWorkplacesDiapason.Max = 10000M;
            numberOfPortsDiapason.Min = 1M;
            numberOfPortsDiapason.Max = 100M;
            cableHankMeterageDiapason.Min = 0.01M;
            cableHankMeterageDiapason.Max = 10000M;
            technologicalReserveDiapason.Min = 1M;
            technologicalReserveDiapason.Max = 2M;
            isStrictСomplianceWithTheStandart = true;
            isAnArbitraryNumberOfPorts = true;
            isTechnologicalReserveAvailability = true;
        }

        public double TechnologicalReserve
        {
            get
            {
                return technologicalReserve;
            }
        }

        public (decimal Min, decimal Max) MinPermanentLinkDiapason
        {
            get
            {
                return minPermanentLinkDiapason;
            }
        }

        public (decimal Min, decimal Max) MaxPermanentLinkDiapason
        {
            get
            {
                return maxPermanentLinkDiapason;
            }
        }

        public (decimal Min, decimal Max) NumberOfWorkplacesDiapason
        {
            get
            {
                return numberOfWorkplacesDiapason;
            }
        }

        public (decimal Min, decimal Max) NumberOfPortsDiapason
        {
            get
            {
                return numberOfPortsDiapason;
            }
        }

        public (decimal Min, decimal Max) CableHankMeterageDiapason
        {
            get
            {
                return cableHankMeterageDiapason;
            }
        }

        public (decimal Min, decimal Max) TechnologicalReserveDiapason
        {
            get
            {
                return technologicalReserveDiapason;
            }
        }

        public bool IsStrictСomplianceWithTheStandart
        {
            get
            {
                return isStrictСomplianceWithTheStandart;
            }
        }

        public bool IsAnArbitraryNumberOfPorts
        {
            get
            {
                return isAnArbitraryNumberOfPorts;
            }
        }

        public bool IsTechnologicalReserveAvailability
        {
            get
            {
                return isTechnologicalReserveAvailability;
            }
        }

        public void SetStrictСomplianceWithTheStandart()
        {
            isStrictСomplianceWithTheStandart = true;
            minPermanentLinkDiapason.Min = 1M;
            minPermanentLinkDiapason.Max = 90M;
            maxPermanentLinkDiapason.Min = 1M;
            maxPermanentLinkDiapason.Max = 90M;
        }

        public void SetNonStrictСomplianceWithTheStandart()
        {
            isStrictСomplianceWithTheStandart = false;
            minPermanentLinkDiapason.Min = 0.01M;
            minPermanentLinkDiapason.Max = 1000M;
            maxPermanentLinkDiapason.Min = 0.01M;
            maxPermanentLinkDiapason.Max = 1000M;
        }

        public void SetAnArbitraryNumberOfPorts()
        {
            isAnArbitraryNumberOfPorts = true;
            numberOfPortsDiapason.Min = 1M;
        }

        public void SetNotAnArbitraryNumberOfPorts()
        {
            isAnArbitraryNumberOfPorts = false;
            numberOfPortsDiapason.Min = 2M;
        }

        public void SetTechnologicalReserveAvailability()
        {
            isTechnologicalReserveAvailability = true;
        }

        public void SetNonTechnologicalReserve()
        {
            isTechnologicalReserveAvailability = false;
            technologicalReserve = 1;
        }

        public void SetTechnologicalReserve(double value)
        {
            if (!isTechnologicalReserveAvailability)
            {
                throw new SCSCalcException("Учёт технологичегского запаса отключён. Пожалуйста, проверьте настройки.");
            }
            technologicalReserve = value;
        }
    }





    internal interface IStrictСomplianceWithTheStandart
    {
        public (decimal Min, decimal Max) MinPermanentLinkDiapason { get; }
        public (decimal Min, decimal Max) MaxPermanentLinkDiapason { get; }
    }

    internal class StrictСomplianceWithTheStandart : IStrictСomplianceWithTheStandart
    {
        public (decimal Min, decimal Max) MinPermanentLinkDiapason
        {
            get
            {
                return (1M, 90M);
            }
        }

        public (decimal Min, decimal Max) MaxPermanentLinkDiapason
        {
            get
            {
                return (1M, 90M);
            }
        }
    }

    internal class NonStrictСomplianceWithTheStandart : IStrictСomplianceWithTheStandart
    {
        public (decimal Min, decimal Max) MinPermanentLinkDiapason
        {
            get
            {
                return (0.01M, 1000M);
            }
        }

        public (decimal Min, decimal Max) MaxPermanentLinkDiapason
        {
            get
            {
                return (0.01M, 1000M);
            }
        }
    }

    internal interface IAnArbitraryNumberOfPorts
    {
        public (decimal Min, decimal Max) NumberOfPortsDiapason { get; }
    }


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

    internal interface ITechnologicalReserve
    {
        public double TechnologicalReserve { get; set; }
    }

    internal class TechnologicalReserveAvailability : ITechnologicalReserve
    {
        private double? technologicalReserve;

        public TechnologicalReserveAvailability()
        {
            technologicalReserve = null;
        }

        public double TechnologicalReserve
        {
            get
            {
                if (technologicalReserve != null)
                {
                    return (double)technologicalReserve;
                }
                else
                {
                    throw new SCSCalcException("Значение технологического запаса не инициализировано.");
                }
            }
            set
            {
                technologicalReserve = value;
            }
        }
    }

    internal class NonTechnologicalReserve : ITechnologicalReserve
    {
        public double TechnologicalReserve
        {
            get
            {
                return 1.00;
            }
            set
            {
                throw new SCSCalcException("Учёт технологичегского запаса отключён. Пожалуйста, проверьте настройки.");
            }
        }
    }

    internal interface IStandartValues
    {
        public (decimal Min, decimal Max) NumberOfWorkplacesDiapason { get; }

        public (decimal Min, decimal Max) CableHankMeterageDiapason { get; }

        public (decimal Min, decimal Max) TechnologicalReserveDiapason { get; }
    }

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

    internal class SettingsLocator
    {
        private IStrictСomplianceWithTheStandart? complianceWithTheStandart;
        private IAnArbitraryNumberOfPorts? numberOfPorts;
        private ITechnologicalReserve? technologicalReserve;
        private IStandartValues? standartValues;

        public SettingsLocator()
        {
            complianceWithTheStandart = null;
            numberOfPorts = null;
            technologicalReserve = null;
            standartValues = new StandartValues();
        }

        public (decimal Min, decimal Max) MinPermanentLinkDiapason
        {
            get
            {
                if (complianceWithTheStandart != null)
                {
                    return complianceWithTheStandart.MinPermanentLinkDiapason;
                }
                else
                {
                    throw new SCSCalcException("Значение соответствия стандарту ISO/IEC 11801 не инициализировано. Пожалуйста, проверьте настройки.");
                }
            }
        }

        public (decimal Min, decimal Max) MaxPermanentLinkDiapason
        {
            get
            {
                if (complianceWithTheStandart != null)
                {
                    return complianceWithTheStandart.MaxPermanentLinkDiapason;
                }
                else
                {
                    throw new SCSCalcException("Значение соответствия стандарту ISO/IEC 11801 не инициализировано. Пожалуйста, проверьте настройки.");
                }
            }
        }

        public (decimal Min, decimal Max) NumberOfPortsDiapason
        {
            get
            {
                if (numberOfPorts != null)
                {
                    return numberOfPorts.NumberOfPortsDiapason;
                }
                else
                {
                    throw new SCSCalcException("Значение соответствия стандарту ISO/IEC 11801 не инициализировано. Пожалуйста, проверьте настройки.");
                }

            }
        }

        public (decimal Min, decimal Max) NumberOfWorkplacesDiapason
        {
            get
            {
                if(standartValues != null)
                {
                    return standartValues.NumberOfWorkplacesDiapason;
                }
                throw new SCSCalcException("Ошибка инициализации параметров значений конфигураций");
            }
        }

        public (decimal Min, decimal Max) CableHankMeterageDiapason
        {
            get
            {
                if (standartValues != null)
                {
                    return standartValues.CableHankMeterageDiapason;
                }
                throw new SCSCalcException("Ошибка инициализации параметров значений конфигураций");
            }
        }

        public (decimal Min, decimal Max) TechnologicalReserveDiapason
        {
            get
            {
                if (standartValues != null)
                {
                    return standartValues.TechnologicalReserveDiapason;
                }
                throw new SCSCalcException("Ошибка инициализации параметров значений конфигураций");
            }
        }

        public double TechnologicalReserve
        {
            get
            {
                if (technologicalReserve != null)
                {
                    return technologicalReserve.TechnologicalReserve;
                }
                throw new SCSCalcException("Значение необходимости учёта технологического запаса не инициализировано. Пожалуйста, проверьте настройки.");
            }
            set
            {
                if (technologicalReserve != null)
                {
                    technologicalReserve.TechnologicalReserve = value;
                }
                else
                {
                    throw new SCSCalcException("Значение необходимости учёта технологического запаса не инициализировано. Пожалуйста, проверьте настройки.");
                }
            }
        }

        public void SetStrictСomplianceWithTheStandart()
        {
            complianceWithTheStandart = new StrictСomplianceWithTheStandart();
        }

        public void SetNonStrictСomplianceWithTheStandart()
        {
            complianceWithTheStandart = new NonStrictСomplianceWithTheStandart();
        }

        public void SetNotAnArbitraryNumberOfPorts()
        {
            numberOfPorts = new NotAnArbitraryNumberOfPorts();
        }

        public void SetAnArbitraryNumberOfPorts()
        {
            numberOfPorts = new AnArbitraryNumberOfPorts();
        }

        public void SetTechnologicalReserveAvailability()
        {
            technologicalReserve = new TechnologicalReserveAvailability();
        }

        public void SetNonTechnologicalReserve()
        {
            technologicalReserve = new NonTechnologicalReserve();
        }

        public bool IsStrictСomplianceWithTheStandart
        {
            get
            {
                if (complianceWithTheStandart is StrictСomplianceWithTheStandart)
                {
                    return true;
                }
                if (complianceWithTheStandart is NonStrictСomplianceWithTheStandart)
                {
                    return false;
                }
                throw new SCSCalcException("Значение соответствия стандарту ISO/IEC 11801 не инициализировано. Пожалуйста, проверьте настройки.");
            }
        }

        public bool IsAnArbitraryNumberOfPorts
        {
            get
            {
                if (numberOfPorts is AnArbitraryNumberOfPorts)
                {
                    return true;
                }
                if (numberOfPorts is NotAnArbitraryNumberOfPorts)
                {
                    return false;
                }
                throw new SCSCalcException("Значение соответствия стандарту ISO/IEC 11801 не инициализировано. Пожалуйста, проверьте настройки.");
            }
        }

        public bool IsTechnologicalReserveAvailability
        {
            get
            {
                if (technologicalReserve is TechnologicalReserveAvailability)
                {
                    return true;
                }
                if (technologicalReserve is NonTechnologicalReserve)
                {
                    return false;
                }
                throw new SCSCalcException("Значение необходимости учёта технологического запаса не инициализировано. Пожалуйста, проверьте настройки.");
            }
        }
    }

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
