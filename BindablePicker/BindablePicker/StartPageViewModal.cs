using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindablePicker
{
    public class StartPageViewModal
    {
        public IEnumerable<SystemElement> SystemElementList { get; set; }
        public int SESelectedValue { get; set; }

        public StartPageViewModal()
        {
            List<SystemElement> SEList = new List<SystemElement>();
            SystemElement s = new SystemElement();
            s.SystemElementID = 0;
            s.SystemElementName = "SysElement 1";
            SEList.Add(s);

            s = new SystemElement();
            s.SystemElementID = 1;
            s.SystemElementName = "SysElement 2";
            SEList.Add(s);

            SystemElementList = SEList;
            SESelectedValue = 1;
        }
        public string strSystemElement
        {
            get { return "System Element"; }
        }
    }
}
