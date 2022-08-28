namespace SKS_Calc_1._1
{
    public record Configuration(DateTime RecordTime, double MinPermanentLink, double MaxPermanentLink,
        double AveragePermanentLink, int NumberOfWorkplaces, int NumberOfPorts, double? СableQuantity,
        double? CableHankMeterage, int? HankQuantity, double TotalСableQuantity)
    {
        public override string ToString()
        {
            if(CableHankMeterage != null)
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
