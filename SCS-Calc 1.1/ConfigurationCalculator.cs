namespace SKS_Calc_1._1
{
    public static class ConfigurationCalculator
    {
        public static Configuration Calculate(SettingsLocator settings, double minPermanentLink, double maxPermanentLink, int numberOfWorkplaces, int numberOfPorts, double? cableHankMeterage)
        {
            if (cableHankMeterage != null)
            {
                double TechnologicalReserve = settings.TechnologicalReserve.GetTechnologicalReserve();
                double MinPermanentLink = settings.ComplianceWithTheStandart.GetMinPermanentLink(minPermanentLink);
                double MaxPermanentLink = settings.ComplianceWithTheStandart.GetMaxPermanentLink(maxPermanentLink);
                double AveragePermanentLink = (MinPermanentLink + MaxPermanentLink) / 2 * TechnologicalReserve;
                int NumberOfWorkplaces = numberOfWorkplaces;
                int NumberOfPorts = settings.NumberOfPorts.GetNumberOfPorts(numberOfPorts);
                double? CableHankMeterage = cableHankMeterage;
                if (AveragePermanentLink > CableHankMeterage)
                {
                    throw new Exception("Расчет провести невозможно! Значение средней длины постояного линка " +
                        "превышает значение метража кабеля в бухте. Согласно стандарту ISO/IEC 11801, сращивание " +
                        "витой пары запрещено. Повторите расчет с другими параметрами.");
                }
                double? СableQuantity = AveragePermanentLink * NumberOfWorkplaces * NumberOfPorts;
                int? HankQuantity = (int)Math.Ceiling(NumberOfWorkplaces * NumberOfPorts / Math.Floor((double)(CableHankMeterage / AveragePermanentLink)));
                double TotalСableQuantity = (double)(HankQuantity * CableHankMeterage);
                return new Configuration(DateTime.Now, MinPermanentLink, MaxPermanentLink, AveragePermanentLink, NumberOfWorkplaces, NumberOfPorts,
                    СableQuantity, CableHankMeterage, HankQuantity, TotalСableQuantity);
            }
            else
            {
                double TechnologicalReserve = settings.TechnologicalReserve.GetTechnologicalReserve();
                double MinPermanentLink = settings.ComplianceWithTheStandart.GetMinPermanentLink(minPermanentLink);
                double MaxPermanentLink = settings.ComplianceWithTheStandart.GetMaxPermanentLink(maxPermanentLink);
                double AveragePermanentLink = (MinPermanentLink + MaxPermanentLink) / 2 * TechnologicalReserve;
                int NumberOfWorkplaces = numberOfWorkplaces;
                int NumberOfPorts = settings.NumberOfPorts.GetNumberOfPorts(numberOfPorts);
                double TotalСableQuantity = AveragePermanentLink * NumberOfWorkplaces * NumberOfPorts;
                return new Configuration(DateTime.Now, MinPermanentLink, MaxPermanentLink, AveragePermanentLink, NumberOfWorkplaces,
                    NumberOfPorts, null, null, null, TotalСableQuantity);
            }
        }
    }
}
