using SCSCalc.Settings;

namespace SCSCalc
{
    //Запись конфигурации СКС
    public record Configuration(DateTime RecordTime, double MinPermanentLink, double MaxPermanentLink, double AveragePermanentLink,
        int NumberOfWorkplaces, int NumberOfPorts, double? СableQuantity, double? CableHankMeterage, int? HankQuantity, double TotalСableQuantity)
    {
        public static Configuration Calculate(SettingsPresent settingsPresent, double minPermanentLink, double maxPermanentLink, int numberOfWorkplaces,
            int numberOfPorts, double? cableHankMeterage)
        {
            if (cableHankMeterage != null)
            {
                double TechnologicalReserve = ConfigurationValue.TechnologicalReserve(settingsPresent.TechnologicalReserve);
                double MinPermanentLink = ConfigurationValue.MinPermanentLink(minPermanentLink);
                double MaxPermanentLink = ConfigurationValue.MaxPermanentLink(maxPermanentLink);
                double AveragePermanentLink = (MinPermanentLink + MaxPermanentLink) / 2 * TechnologicalReserve;
                int NumberOfWorkplaces = ConfigurationValue.NumberOfWorkplaces(numberOfWorkplaces);
                int NumberOfPorts = ConfigurationValue.NumberOfPorts(numberOfPorts);
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
                double TechnologicalReserve = ConfigurationValue.TechnologicalReserve(settingsPresent.TechnologicalReserve);
                double MinPermanentLink = ConfigurationValue.MinPermanentLink(minPermanentLink);
                double MaxPermanentLink = ConfigurationValue.MaxPermanentLink(maxPermanentLink);
                double AveragePermanentLink = (MinPermanentLink + MaxPermanentLink) / 2 * TechnologicalReserve;
                int NumberOfWorkplaces = ConfigurationValue.NumberOfWorkplaces(numberOfWorkplaces);
                int NumberOfPorts = ConfigurationValue.NumberOfPorts(numberOfPorts);
                double TotalСableQuantity = AveragePermanentLink * NumberOfWorkplaces * NumberOfPorts;
                return new Configuration(DateTime.Now, MinPermanentLink, MaxPermanentLink, AveragePermanentLink, NumberOfWorkplaces,
                    NumberOfPorts, null, null, null, TotalСableQuantity);
            }
        }

        public override string ToString()
        {
            if (CableHankMeterage != null)
            {
                return $"{RecordTime.ToString()}, мин.{MinPermanentLink.ToString("F" + 2)} м / макс.{MaxPermanentLink.ToString("F" + 2)} м, " +
                    $"{HankQuantity} бухт; {TotalСableQuantity.ToString("F" + 2)} м.";
            }
            else
            {
                return $"{RecordTime.ToString()}, мин.{MinPermanentLink.ToString("F" + 2)} м / макс.{MaxPermanentLink.ToString("F" + 2)} м; " +
                    $"{TotalСableQuantity.ToString("F" + 2)} м.";
            }
        }
    }
}
