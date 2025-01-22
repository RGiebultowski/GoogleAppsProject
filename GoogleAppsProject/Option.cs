using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAppsProject
{
    public class Option
    {
        private string ActionName { get; set; }
        private Action Selected { get; }

        public Option(string selectedActionName, Action selectedAction) 
        {
            ActionName = selectedActionName;
            Selected = selectedAction;
        }
    }
}
