namespace SCSCalcClassLibrary
{
    //Класс, предназначенный для определения допустимых рамок вводимых значения для расчёта конфигураций СКС
    internal static class ConfigurationValue
    {
        public static double TechnologicalReserve(double technologicalReserve)
        {
            if (technologicalReserve > 2)
            {
                throw new SCSCalcException("Превышено допустимое значение технологического запаса (2.00).");
            }
            if (technologicalReserve < 1)
            {
                throw new SCSCalcException("Значение технологического запаса ниже допустимого (1.00)");
            }
            return technologicalReserve;
        }

        public static double MinPermanentLink(double minPermanentLink)
        {
            if (minPermanentLink < 1)
            {
                throw new SCSCalcException("Значение наименьшей длины постоянного линка ниже допустимого");
            }
            return minPermanentLink;
        }

        public static double MaxPermanentLink(double maxPermanentLink)
        {
            if (maxPermanentLink < 1)
            {
                throw new SCSCalcException("Значение наибольшей длины постоянного линка ниже допустимого");
            }
            return maxPermanentLink;
        }

        public static int NumberOfWorkplaces(int numberOfWorkplaces)
        {
            if (numberOfWorkplaces > 10000)
            {
                throw new SCSCalcException("Значение количества рабочих мест выше допустимого (10000)");
            }
            return numberOfWorkplaces;
        }

        public static int NumberOfPorts(int numberOfPorts)
        {
            if (numberOfPorts > 100)
            {
                throw new SCSCalcException("Превышено допустимое значение количества портов на 1 рабочее место (100).");
            }
            return numberOfPorts;
        }

        public static double? CableHankMeterage(double? cableHankMeterage)
        {
            if(cableHankMeterage > 10000)
            {
                throw new SCSCalcException("Превышено допустимое значение количества метража кабеля в 1-й катушке (бухте) (10000).");
            }
            return cableHankMeterage;
        }
    }
}
