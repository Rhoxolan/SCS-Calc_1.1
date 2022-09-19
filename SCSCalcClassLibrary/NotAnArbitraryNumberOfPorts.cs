﻿namespace SCSCalcClassLibrary
{
    //Класс, применяемый для работы с параметром количества портов на 1 рабочее место с учётом соблюдения стандарта ISO/IEC 11801
    internal class NotAnArbitraryNumberOfPorts : IAnArbitraryNumberOfPorts
    {
        public int GetNumberOfPorts(int numberOfPorts)
        {
            if (numberOfPorts < 2)
            {
                throw new SCSCalcException("Значение количества портов на 1 рабочее место ниже допустимого. " +
                    "Согласно стандарту ISO/IEC 11801 на 1 рабочее место должно быть выделено не менее 2-х портов.");
            }
            return numberOfPorts;
        }
    }
}
