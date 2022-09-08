namespace SKS_Calc_1._1
{
    public interface IStrictСomplianceWithTheStandart
    {
        public double GetMinPermanentLink(double minPermanentLink);
        public double GetMaxPermanentLink(double maxPermanentLink);
    }

    public interface IAnArbitraryNumberOfPorts
    {
        public int GetNumberOfPorts(int numberOfPorts);
    }

    public interface ITechnologicalReserve
    {
        public double GetTechnologicalReserve();
        public void SetTechnologicalReserve(double value);
    }

    public class StrictСomplianceWithTheStandart : IStrictСomplianceWithTheStandart
    {
        public double GetMaxPermanentLink(double maxPermanentLink)
        {
            if (maxPermanentLink > 90)
            {
                throw new Exception("Превышено значение наибольшей длины постоянного линка. " +
                    "Согласно стандарту ISO/IEC 11801 значение постоянного линка не должно превышать 90 м.");
            }
            if (maxPermanentLink < 1)
            {
                throw new Exception("Значение наибольшей длины постоянного линка ниже допустимого");
            }
            return maxPermanentLink;
        }

        public double GetMinPermanentLink(double minPermanentLink)
        {
            if (minPermanentLink > 90)
            {
                throw new Exception("Превышено значение наименьшей длины постоянного линка. " +
                    "Согласно стандарту ISO/IEC 11801 значение постоянного линка не должно превышать 90 м.");
            }
            if (minPermanentLink < 1)
            {
                throw new Exception("Значение наименьшей длины постоянного линка ниже допустимого");
            }
            return minPermanentLink;
        }
    }

    public class NonStrictСomplianceWithTheStandart : IStrictСomplianceWithTheStandart
    {
        public double GetMaxPermanentLink(double maxPermanentLink)
        {
            return maxPermanentLink;
        }

        public double GetMinPermanentLink(double minPermanentLink)
        {
            return minPermanentLink;
        }
    }

    public class NotAnArbitraryNumberOfPorts : IAnArbitraryNumberOfPorts
    {
        public int GetNumberOfPorts(int numberOfPorts)
        {
            if (numberOfPorts > 100)
            {
                throw new Exception("Превышено допустимое значение количества портов на 1 рабочее место.");
            }
            if (numberOfPorts < 2)
            {
                throw new Exception("Значение количества портов на 1 рабочее место ниже допустимого. " +
                    "Согласно стандарту ISO/IEC 11801 на 1 рабочее место должно быть выделено не менее 2-х портов.");
            }
            return numberOfPorts;
        }
    }

    public class AnArbitraryNumberOfPorts : IAnArbitraryNumberOfPorts
    {
        public int GetNumberOfPorts(int numberOfPorts)
        {
            return numberOfPorts;
        }
    }

    public class TechnologicalReserveAvailability : ITechnologicalReserve
    {
        private double? technologicalReserve;

        public TechnologicalReserveAvailability()
        {
            technologicalReserve = null;
        }

        public void SetTechnologicalReserve(double value)
        {
            if (value > 2)
            {
                throw new Exception("Превышено допустимое значение технологического запаса (2.00).");
            }
            if (value < 1)
            {
                throw new Exception("Значение технологического запаса ниже допустимого (1.00)");
            }
            technologicalReserve = value;
        }

        public double GetTechnologicalReserve()
        {
            if (technologicalReserve != null)
            {
                return (double)technologicalReserve;
            }
            else
            {
                throw new Exception("Значение технологического запаса не инициализировано.");
            }
        }
    }

    public class NonTechnologicalReserve : ITechnologicalReserve
    {
        public void SetTechnologicalReserve(double value)
        {
            throw new Exception("Учёт технологичегского запаса отключён. Пожалуйста, проверьте настройки.");
        }

        public double GetTechnologicalReserve()
        {
            return 1.00;
        }
    }

    public class SettingsLocator
    {
        private IStrictСomplianceWithTheStandart complianceWithTheStandart;
        private IAnArbitraryNumberOfPorts numberOfPorts;
        private ITechnologicalReserve technologicalReserve;

        public SettingsLocator()
        {
            complianceWithTheStandart = null;
            numberOfPorts = null;
            technologicalReserve = null;
        }

        public IStrictСomplianceWithTheStandart ComplianceWithTheStandart
        {
            get
            {
                return complianceWithTheStandart;
            }
        }

        public IAnArbitraryNumberOfPorts NumberOfPorts
        {
            get
            {
                return numberOfPorts;
            }
        }

        public ITechnologicalReserve TechnologicalReserve
        {
            get
            {
                return technologicalReserve;
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
    }
}
