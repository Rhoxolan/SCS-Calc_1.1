namespace SCSCalcClassLibrary
{
    //Класс для работы с параметром технологического запаса без его учёта
    internal class NonTechnologicalReserve : ITechnologicalReserve
    {
        public void SetTechnologicalReserve(double value)
        {
            throw new SCSCalcException("Учёт технологичегского запаса отключён. Пожалуйста, проверьте настройки.");
        }

        public double GetTechnologicalReserve()
        {
            return 1.00;
        }
    }
}
