namespace SCSCalcClassLibrary
{
    //Класс, применяяемых для работы с параметром количества портов на 1 рабочее место без учёта соблюдения стандарта ISO/IEC 11801
    internal class AnArbitraryNumberOfPorts : IAnArbitraryNumberOfPorts
    {
        public int GetNumberOfPorts(int numberOfPorts)
        {
            return numberOfPorts;
        }
    }
}
