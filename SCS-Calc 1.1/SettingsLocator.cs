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
        public double GetTechnologicalReserve(double technologicalReserve);
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
            if (maxPermanentLink > 10000)
            {
                throw new Exception("Значение наибольшей длины постоянного линка выше допустимого");
            }
            if (maxPermanentLink < 0.01)
            {
                throw new Exception("Значение наибольшей длины постоянного линка ниже допустимого");
            }
            return maxPermanentLink;
        }

        public double GetMinPermanentLink(double minPermanentLink)
        {
            if (minPermanentLink > 10000)
            {
                throw new Exception("Значение наибольшей длины постоянного линка выше допустимого");
            }
            if (minPermanentLink < 0.01)
            {
                throw new Exception("Значение наибольшей длины постоянного линка ниже допустимого");
            }
            return minPermanentLink;
        }
    }

    public class NotAnArbitraryNumberOfPorts : IAnArbitraryNumberOfPorts
    {
        public int GetNumberOfPorts(int numberOfPorts)
        {
            if(numberOfPorts > 100)
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
            if (numberOfPorts > 10000)
            {
                throw new Exception("Превышено допустимое значение количества портов на 1 рабочее место.");
            }
            if (numberOfPorts < 1)
            {
                throw new Exception("Значение количества портов на 1 рабочее место ниже допустимого.");
            }
            return numberOfPorts;
        }
    }

    public class SettingsLocator
    {
    }
}
