namespace SCSCalcClassLibrary
{
    //Интерфейс для определения допустимости произвольного к-ва портов на 1 рабочее место.
    internal interface IAnArbitraryNumberOfPorts
    {
        public int GetNumberOfPorts(int numberOfPorts);
    }
}
