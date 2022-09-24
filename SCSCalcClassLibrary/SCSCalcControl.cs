using System.ComponentModel;

namespace SCSCalcClassLibrary
{
    //Класс, представлящий единицу режима приложения SCS-Calc, например, режима настроек или режима расчёта.
    public class SCSCalcControl : UserControl
    {
        protected SettingsPresent? settingsPresent;
        protected BindingList<Configuration>? configurations;
        protected string? docPath;
        protected string? settingsDocPath;

        public SCSCalcControl? ParentControl { get; set; }

        public List<SCSCalcControl>? ChildControls { get; set; }

        protected void GoBack() //Переход в предыдущий режим
        {
            if (ParentControl != null)
            {
                this.Visible = false;
                ParentControl.Visible = true;
            }
        }

        protected void TransitionInto(Type controlType) //Переход в указанный режим
        {
            if (ChildControls != null && ChildControls.Count > 0)
            {
                foreach (SCSCalcControl control in ChildControls)
                {
                    if (control.GetType() == controlType)
                    {
                        this.Visible = false;
                        control.Visible = true;
                        return;
                    }
                }
            }
        }
    }
}
