namespace SCSCalcClassLibrary
{
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
}
