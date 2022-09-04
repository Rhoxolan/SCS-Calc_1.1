using System.ComponentModel;

namespace SKS_Calc_1._1
{
    public class SCSCalcControl : UserControl
    {
        protected BindingList<Configuration> configurations;
        protected string docPath;

        public SCSCalcControl? ParentControl { get; set; }

        public List<SCSCalcControl>? ChildControls { get; set; }

        protected SCSCalcControl(BindingList<Configuration> configurations, string docPath)
        {
            ParentControl = null;
            ChildControls = new();
            this.configurations = configurations;
            this.docPath = docPath;
        }

        protected void TransitionInto(Type controlType) ////Переход в указанный режим
        {
            if (ChildControls != null && ChildControls.Count > 0)
            {
                foreach (SCSCalcControl c in ChildControls)
                {
                    if (c.GetType() == controlType)
                    {
                        this.Visible = false;
                        c.Visible = true;
                        return;
                    }
                }
            }
        }

        protected void GoBack() //Переход в предыдущий режим
        {
            if (ParentControl != null)
            {
                this.Visible = false;
                ParentControl.Visible = true;
            }
        }
    }
}
