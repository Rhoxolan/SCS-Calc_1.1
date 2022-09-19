namespace SCSCalcClassLibrary
{
    //Интерфейс для определения настраиваемых параметров учета технологического запаса
    internal interface ITechnologicalReserve
    {
        public double GetTechnologicalReserve();
        public void SetTechnologicalReserve(double value);
    }
}
