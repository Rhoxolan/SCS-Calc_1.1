namespace SCSCalcClassLibrary
{
    //Класс для работы со значением коэффициента технологического запаса без его учёта. Инкапсулирован в класс SettingsLocator.
    internal class NonTechnologicalReserve : ITechnologicalReserve
    {
        public double TechnologicalReserve
        {
            get
            {
                return 1.00;
            }
            set
            {
                throw new SCSCalcException("Учёт технологичегского запаса отключён. Пожалуйста, проверьте настройки.");
            }
        }
    }
}
