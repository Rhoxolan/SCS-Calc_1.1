namespace SCSCalcClassLibrary
{
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
