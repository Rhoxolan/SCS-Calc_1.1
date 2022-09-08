using System.ComponentModel;

namespace SKS_Calc_1._1
{
    public class SCSCalcControl : UserControl
    {
        protected SettingsLocator settings;
        protected BindingList<Configuration> configurations;
        protected string docPath;

        public SCSCalcControl ParentControl { get; set; }

        public List<SCSCalcControl> ChildControls { get; set; }

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
