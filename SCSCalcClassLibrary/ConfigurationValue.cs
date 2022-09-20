namespace SCSCalcClassLibrary
{
    //Статический класс, предназначенный для проверкии вводимх значений параметров конфигурации. В случае несовпадения допустимым значениям
    //выбрасывается исключение SCSCalcException. ИСКЛЮЧЕНИЕ НЕ ДОЛЖНО ОБРАБАТЫВАТЬСЯ В ПРИЛОЖЕНИИ! Допустимые рамки значений определяются, прежде всего, интерфейсами настроек,
    //инкапсулированных в SettingsLocator.
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
            if (minPermanentLink > 1000)
            {
                throw new SCSCalcException("Значение наименьшей длины постоянного линка выше допустимого");
            }
            if (minPermanentLink < 1)
            {
                throw new SCSCalcException("Значение наименьшей длины постоянного линка ниже допустимого");
            }
            return minPermanentLink;
        }

        public static double MaxPermanentLink(double maxPermanentLink)
        {
            if (maxPermanentLink > 1000)
            {
                throw new SCSCalcException("Значение наибольшей длины постоянного линка выше допустимого");
            }
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
            if (numberOfWorkplaces < 1)
            {
                throw new SCSCalcException("Значение количества рабочих меньше 1-го");
            }
            return numberOfWorkplaces;
        }

        public static int NumberOfPorts(int numberOfPorts)
        {
            if (numberOfPorts > 100)
            {
                throw new SCSCalcException("Превышено допустимое значение количества портов на 1 рабочее место (100).");
            }
            if (numberOfPorts < 1)
            {
                throw new SCSCalcException("Значение количества портов на 1 рабочее место меньше 1-го.");
            }
            return numberOfPorts;
        }

        public static double? CableHankMeterage(double? cableHankMeterage)
        {
            if (cableHankMeterage > 10000)
            {
                throw new SCSCalcException("Значение метража кабеля в 1-й катушке (бухте) выше допустимого (10000).");
            }
            if (cableHankMeterage < 0.01)
            {
                throw new SCSCalcException("Значение метража кабеля в 1-й катушке (бухте) ниже допустимого (0.01).");
            }
            return cableHankMeterage;
        }
    }
}