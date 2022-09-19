using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCSCalcClassLibrary
{
    //Класс, инкапсулирующий объекты для работы с настраиваемыми параметрами расчета конфигурации СКС
    internal class SettingsLocator 
    {
        private IStrictСomplianceWithTheStandart? complianceWithTheStandart;
        private IAnArbitraryNumberOfPorts? numberOfPorts;
        private ITechnologicalReserve? technologicalReserve;

        public SettingsLocator()
        {
            complianceWithTheStandart = null;
            numberOfPorts = null;
            technologicalReserve = null;
        }

        public double GetTechnologicalReserve()
        {
            if (technologicalReserve != null)
            {
                return technologicalReserve.GetTechnologicalReserve();
            }
            else
            {
                throw new Exception("Значение необходимости учёта технологического запаса не инициализировано. Пожалуйста, проверьте настройки.");
            }
        }

        public double GetMinPermanentLink(double minPermanentLink)
        {
            if (complianceWithTheStandart != null)
            {
                return complianceWithTheStandart.GetMinPermanentLink(minPermanentLink);
            }
            else
            {
                throw new Exception("Значение соответствия стандарту ISO/IEC 11801 не инициализировано. Пожалуйста, проверьте настройки.");
            }
        }

        public double GetMaxPermanentLink(double maxPermanentLink)
        {
            if (complianceWithTheStandart != null)
            {
                return complianceWithTheStandart.GetMaxPermanentLink(maxPermanentLink);
            }
            else
            {
                throw new Exception("Значение соответствия стандарту ISO/IEC 11801 не инициализировано. Пожалуйста, проверьте настройки.");
            }
        }

        public int GetNumberOfPorts(int numberOfPorts)
        {
            if (this.numberOfPorts != null)
            {
                return this.numberOfPorts.GetNumberOfPorts(numberOfPorts);
            }
            else
            {
                throw new Exception("Значение соответствия стандарту ISO/IEC 11801 не инициализировано. Пожалуйста, проверьте настройки.");
            }
        }

        public void SetTechnologicalReserve(double value)
        {
            if (technologicalReserve != null)
            {
                technologicalReserve.SetTechnologicalReserve(value);
            }
            else
            {
                throw new Exception("Значение необходимости учёта технологического запаса не инициализировано. Пожалуйста, проверьте настройки.");
            }
        }

        public void SetStrictСomplianceWithTheStandart()
        {
            complianceWithTheStandart = new StrictСomplianceWithTheStandart();
        }

        public void SetNonStrictСomplianceWithTheStandart()
        {
            complianceWithTheStandart = new NonStrictСomplianceWithTheStandart();
        }

        public void SetNotAnArbitraryNumberOfPorts()
        {
            numberOfPorts = new NotAnArbitraryNumberOfPorts();
        }

        public void SetAnArbitraryNumberOfPorts()
        {
            numberOfPorts = new AnArbitraryNumberOfPorts();
        }

        public void SetTechnologicalReserveAvailability()
        {
            technologicalReserve = new TechnologicalReserveAvailability();
        }

        public void SetNonTechnologicalReserve()
        {
            technologicalReserve = new NonTechnologicalReserve();
        }

        public bool IsStrictСomplianceWithTheStandart
        {
            get
            {
                if (complianceWithTheStandart is StrictСomplianceWithTheStandart)
                {
                    return true;
                }
                if (complianceWithTheStandart is NonStrictСomplianceWithTheStandart)
                {
                    return false;
                }
                throw new Exception("Значение соответствия стандарту ISO/IEC 11801 не инициализировано. Пожалуйста, проверьте настройки.");
            }
        }

        public bool IsAnArbitraryNumberOfPorts
        {
            get
            {
                if (numberOfPorts is AnArbitraryNumberOfPorts)
                {
                    return true;
                }
                if (numberOfPorts is NotAnArbitraryNumberOfPorts)
                {
                    return false;
                }
                throw new Exception("Значение соответствия стандарту ISO/IEC 11801 не инициализировано. Пожалуйста, проверьте настройки.");
            }
        }

        public bool IsTechnologicalReserveAvailability
        {
            get
            {
                if (technologicalReserve is TechnologicalReserveAvailability)
                {
                    return true;
                }
                if (technologicalReserve is NonTechnologicalReserve)
                {
                    return false;
                }
                throw new Exception("Значение необходимости учёта технологического запаса не инициализировано. Пожалуйста, проверьте настройки.");
            }
        }
    }
}
