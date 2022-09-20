namespace SCSCalcClassLibrary
{
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
}
