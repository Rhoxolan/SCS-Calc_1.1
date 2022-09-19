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
}
