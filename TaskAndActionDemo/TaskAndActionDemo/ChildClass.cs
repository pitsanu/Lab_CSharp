using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace TaskAndActionDemo
{
    class ChildClass : BaseClass
    {
        public ChildClass()
            : base()
        {
            //Override Action here

            ProcessMsgAct = (obj) =>
            {
                //Debug.WriteLine("ProcessMsgAct in ChildClass");
                Console.WriteLine("ProcessMsgAct in ChildClass");
            };
        }
   
    }
}
