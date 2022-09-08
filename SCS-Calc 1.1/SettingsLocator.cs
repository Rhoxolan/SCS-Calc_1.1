namespace SKS_Calc_1._1
{
    public interface IStrictСomplianceWithTheStandart
    {
        public double GetMinPermanentLink(double minPermanentLink);
        public double GetMaxPermanentLink(double maxPermanentLink);
        public double GetTechnologicalReserve(double technologicalReserve);
    }

    public interface IAnArbitraryNumberOfPorts
    {
        public int GetNumberOfPorts(int numberOfPorts);
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

        public double GetTechnologicalReserve(double technologicalReserve)
        {
            if (technologicalReserve > 2)
            {
                throw new Exception("Превышено допустимое значение технологического запаса (2.00).");
            }
            if (technologicalReserve < 1)
            {
                throw new Exception("Значение технологического запаса ниже допустимого (1.00)");
            }
            return technologicalReserve;
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

        public double GetTechnologicalReserve(double technologicalReserve)
        {
            if (technologicalReserve > 10)
            {
                throw new Exception("Превышено допустимое значение технологического запаса (10.00).");
            }
            if (technologicalReserve < 1)
            {
                throw new Exception("Значение технологического запаса ниже допустимого (1.0)");
            }
            return technologicalReserve;
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
        private IStrictСomplianceWithTheStandart? complianceWithTheStandart;
        private IAnArbitraryNumberOfPorts? numberOfPorts;
        private double technologicalReserve;

        public SettingsLocator()
        {
            complianceWithTheStandart = null;
            numberOfPorts = null;
            technologicalReserve = 1;
        }

        public double TechnologicalReserve
        {
            set
            {
                technologicalReserve = value;
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

        public (double MinPermanentLink, double MaxPermanentLink, double AveragePermanentLink, int NumberOfWorkplaces, int NumberOfPorts, double? СableQuantity,
            double? CableHankMeterage, int? HankQuantity, double TotalСableQuantity)
            Calculate(double minPermanentLink, double maxPermanentLink, int numberOfWorkplaces, int numberOfPorts, double? cableHankMeterage)
        {
            if(cableHankMeterage != null)
            {
                double TechnologicalReserve = complianceWithTheStandart!.GetTechnologicalReserve(technologicalReserve);
                double MinPermanentLink = complianceWithTheStandart!.GetMinPermanentLink(minPermanentLink);
                double MaxPermanentLink = complianceWithTheStandart!.GetMaxPermanentLink(maxPermanentLink);
                double AveragePermanentLink = (MinPermanentLink + MaxPermanentLink) / 2 * TechnologicalReserve;
                int NumberOfWorkplaces = numberOfWorkplaces;
                int NumberOfPorts = this.numberOfPorts!.GetNumberOfPorts(numberOfPorts);
                double? CableHankMeterage = cableHankMeterage;
                double СableQuantity = AveragePermanentLink * NumberOfWorkplaces * NumberOfPorts;
                int HankQuantity = (int)Math.Ceiling(NumberOfWorkplaces * NumberOfPorts / Math.Floor((double)(CableHankMeterage / AveragePermanentLink)));
                double TotalСableQuantity = (double)(HankQuantity * CableHankMeterage);
                return (MinPermanentLink, MaxPermanentLink, AveragePermanentLink, NumberOfWorkplaces, NumberOfPorts, СableQuantity, CableHankMeterage, HankQuantity, TotalСableQuantity);
            }
            else
            {
                return new();
            }
        }
    }
}
