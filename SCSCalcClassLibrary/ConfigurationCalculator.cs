namespace SCSCalcClassLibrary
{
    //Класс для расчёта конфигурации СКС
    public static class ConfigurationCalculator
    {
        public static Configuration Calculate(SettingsPresent settingsPresent, double minPermanentLink, double maxPermanentLink, int numberOfWorkplaces, int numberOfPorts, double? cableHankMeterage)
        {
            if (cableHankMeterage != null)
            {
                double TechnologicalReserve = ConfigurationValue.TechnologicalReserve(settingsPresent.GetTechnologicalReserve());
                double MinPermanentLink = ConfigurationValue.MinPermanentLink(settingsPresent.GetMinPermanentLink(minPermanentLink));
                double MaxPermanentLink = ConfigurationValue.MaxPermanentLink(settingsPresent.GetMaxPermanentLink(maxPermanentLink));
                double AveragePermanentLink = (MinPermanentLink + MaxPermanentLink) / 2 * TechnologicalReserve;
                int NumberOfWorkplaces = ConfigurationValue.NumberOfWorkplaces(numberOfWorkplaces);
                int NumberOfPorts = ConfigurationValue.NumberOfPorts(settingsPresent.GetNumberOfPorts(numberOfPorts));
                double? CableHankMeterage = ConfigurationValue.CableHankMeterage(cableHankMeterage);
                if (AveragePermanentLink > CableHankMeterage)
                {
                    throw new SCSCalcException("Расчет провести невозможно! Значение средней длины постояного линка " +
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
                double TechnologicalReserve = ConfigurationValue.TechnologicalReserve(settingsPresent.GetTechnologicalReserve());
                double MinPermanentLink = ConfigurationValue.MinPermanentLink(settingsPresent.GetMinPermanentLink(minPermanentLink));
                double MaxPermanentLink = ConfigurationValue.MaxPermanentLink(settingsPresent.GetMaxPermanentLink(maxPermanentLink));
                double AveragePermanentLink = (MinPermanentLink + MaxPermanentLink) / 2 * TechnologicalReserve;
                int NumberOfWorkplaces = ConfigurationValue.NumberOfWorkplaces(numberOfWorkplaces);
                int NumberOfPorts = ConfigurationValue.NumberOfPorts(settingsPresent.GetNumberOfPorts(numberOfPorts));
                double TotalСableQuantity = AveragePermanentLink * NumberOfWorkplaces * NumberOfPorts;
                return new Configuration(DateTime.Now, MinPermanentLink, MaxPermanentLink, AveragePermanentLink, NumberOfWorkplaces,
                    NumberOfPorts, null, null, null, TotalСableQuantity);
            }
        }
    }
}
