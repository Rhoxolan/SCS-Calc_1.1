namespace SCSCalcClassLibrary
{
    //Класс для работы со значением коэффициента технологического запаса с его учётом. Инкапсулирован в класс SettingsLocator.
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
