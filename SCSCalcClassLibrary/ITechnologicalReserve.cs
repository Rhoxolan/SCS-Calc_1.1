namespace SCSCalcClassLibrary
{
    //Интерфейс для работы со значением коэффициента технологического запаса. Инкапсулирован в класс SettingsLocator.
    internal interface ITechnologicalReserve
    {
        public double TechnologicalReserve { get; set; }
    }
}
