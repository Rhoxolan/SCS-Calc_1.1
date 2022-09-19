namespace SCSCalcClassLibrary
{
    //Класс для работы с параметром технологического запаса с его учётом
    internal class TechnologicalReserveAvailability : ITechnologicalReserve
    {
        private double? technologicalReserve;

        public TechnologicalReserveAvailability()
        {
            technologicalReserve = null;
        }

        public void SetTechnologicalReserve(double value)
        {
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
                throw new SCSCalcException("Значение технологического запаса не инициализировано.");
            }
        }
    }
}
