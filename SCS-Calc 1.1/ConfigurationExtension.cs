using SCSCalcClassLibrary;

namespace SKS_Calc_1._1
{
    //Методы расширения класса Configuration. Методы создаются для удобства работы с объектами
    //класса Configuration в разных частях приложения, в частности в разных UserControl-ах.
    //Создание методов в этом классе не регламентировано, методы создаются по мере необходимости.
    public static class ConfigurationExtension
    {
        //Используется для вывода конфигурации СКС в блоке вывода режима "История"
        //Рекомендовано для вывода конфигурации СКС в других режимах
        public static string ToLongOutputString(this Configuration configuration)
        {
            if (configuration.СableQuantity != null && configuration.HankQuantity != null &&
                configuration.CableHankMeterage != null)
            {
                return
                    $"{configuration.RecordTime.ToString()}{Environment.NewLine}" +
                    $"Наименьшая длина постоянного линка (Permanent Link): " +
                    $"{configuration.MinPermanentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Наибольшая длина постоянного линка (Permanent Link): " +
                    $"{configuration.MaxPermanentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Средняя длина постоянного линка (Permanent Link): " +
                    $"{configuration.AveragePermanentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Количество рабочих мест: " +
                    $"{configuration.NumberOfWorkplaces}{Environment.NewLine}" +
                    $"Количество портов на 1 рабочее место: " +
                    $"{configuration.NumberOfPorts}{Environment.NewLine}" +
                    $"Необходимое количество кабеля: " +
                    $"{configuration.СableQuantity?.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Метраж кабеля в 1-й бухте: " +
                    $"{configuration.CableHankMeterage?.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Необходимое количество бухт кабеля: " +
                    $"{configuration.HankQuantity}{Environment.NewLine}" +
                    $"Итоговое необходимое количество кабеля: " +
                    $"{configuration.TotalСableQuantity.ToString("F" + 2)} м.{Environment.NewLine}";
            }
            else
            {
                return
                    $"{configuration.RecordTime.ToString()}{Environment.NewLine}" +
                    $"Наименьшая длина постоянного линка (Permanent Link): " +
                    $"{configuration.MinPermanentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Наибольшая длина постоянного линка (Permanent Link): " +
                    $"{configuration.MaxPermanentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Средняя длина постоянного линка (Permanent Link): " +
                    $"{configuration.AveragePermanentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Количество рабочих мест: " +
                    $"{configuration.NumberOfWorkplaces}{Environment.NewLine}" +
                    $"Количество портов на 1 рабочее место: " +
                    $"{configuration.NumberOfPorts}{Environment.NewLine}" +
                    $"Итоговое необходимое количество кабеля: " +
                    $"{configuration.TotalСableQuantity.ToString("F" + 2)} м.{Environment.NewLine}";
            }
        }

        //Ремомендовано для записи конфигурации СКС в текстовые документы
        public static string ToLongSaveString(this Configuration configuration)
        {
            if (configuration.СableQuantity != null && configuration.HankQuantity != null &&
                configuration.CableHankMeterage != null)
            {
                return
                    $"Конфигурация создана в приложении SCS-Calc{Environment.NewLine}{Environment.NewLine}" +
                    $"Дата записи конфигурации: {configuration.RecordTime.ToString()}{Environment.NewLine}" +
                    $"Наименьшая длина постоянного линка (Permanent Link): " +
                    $"{configuration.MinPermanentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Наибольшая длина постоянного линка (Permanent Link): " +
                    $"{configuration.MaxPermanentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Средняя длина постоянного линка (Permanent Link): " +
                    $"{configuration.AveragePermanentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Количество рабочих мест: " +
                    $"{configuration.NumberOfWorkplaces}{Environment.NewLine}" +
                    $"Количество портов на 1 рабочее место: " +
                    $"{configuration.NumberOfPorts}{Environment.NewLine}" +
                    $"Необходимое количество кабеля: " +
                    $"{configuration.СableQuantity?.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Метраж кабеля в 1-й бухте: " +
                    $"{configuration.CableHankMeterage?.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Необходимое количество бухт кабеля: " +
                    $"{configuration.HankQuantity?.ToString()}{Environment.NewLine}" +
                    $"Итоговое необходимое количество кабеля: " +
                    $"{configuration.TotalСableQuantity.ToString("F" + 2)} м.{Environment.NewLine}";
            }
            else
            {
                return
                    $"Конфигурация создана в приложении SCS-Calc{Environment.NewLine}{Environment.NewLine}" +
                    $"Дата записи конфигурации: {configuration.RecordTime.ToString()}{Environment.NewLine}" +
                    $"Наименьшая длина постоянного линка (Permanent Link): " +
                    $"{configuration.MinPermanentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Наибольшая длина постоянного линка (Permanent Link): " +
                    $"{configuration.MaxPermanentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Средняя длина постоянного линка (Permanent Link): " +
                    $"{configuration.AveragePermanentLink.ToString("F" + 2)} м.{Environment.NewLine}" +
                    $"Количество рабочих мест: " +
                    $"{configuration.NumberOfWorkplaces}{Environment.NewLine}" +
                    $"Количество портов на 1 рабочее место: " +
                    $"{configuration.NumberOfPorts}{Environment.NewLine}" +
                    $"Итоговое необходимое количество кабеля: " +
                    $"{configuration.TotalСableQuantity.ToString("F" + 2)} м.{Environment.NewLine}";
            }
        }

        //Рекомендовано для сохранения выбранной конфигурации СКС в текстовый документ
        public static void SaveToTXT(this Configuration configuration)
        {
            SaveFileDialog sfd = new();
            sfd.Filter = "Текстовые документы(*.txt)|*.txt";
            sfd.FileName = $"Конфигурация СКС {configuration.RecordTime.ToShortDateString()} " +
                $"{configuration.RecordTime.Hour:00}.{configuration.RecordTime.Minute:00}." +
                $"{configuration.RecordTime.Second:00}.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new(sfd.FileName, FileMode.Create);
                using (StreamWriter sw = new(fs))
                {
                    sw.WriteLine(configuration.ToLongSaveString());
                }
            }
        }
    }
}
