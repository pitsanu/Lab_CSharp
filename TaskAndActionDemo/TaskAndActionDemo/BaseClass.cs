using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TaskAndActionDemo
{
    class BaseClass
    {
        protected Action<object> ProcessMsgAct;

        public BaseClass()
        {
            ProcessMsgAct = (obj) =>
            {
                //Debug.WriteLine("ProcessMsgAct in BaseClass");
                Console.WriteLine("ProcessMsgAct in BaseClass");
            };
        }

        public virtual void Act(object obj)
        {
            var task = new Task(() => ProcessMsgAct(obj));
            task.Start();
        }
    }
}
