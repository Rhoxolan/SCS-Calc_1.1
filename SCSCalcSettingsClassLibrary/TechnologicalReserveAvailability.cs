namespace SCSCalc.Settings
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
                    technologicalReserve = 1.10;
                    return (double)technologicalReserve;
                }
            }
            set
            {
                technologicalReserve = value;
            }
        }
    }
}
