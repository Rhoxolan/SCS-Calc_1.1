using System.ComponentModel;

namespace SKS_Calc_1._1
{
    public interface ISCSCalcControl
    {
        public UserControl? ParentControl { get; set; }

        public List<UserControl>? ChildControls { get; set; }

    }
}
