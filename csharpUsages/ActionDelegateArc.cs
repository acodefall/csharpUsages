using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpUsages
{
    public class ActionDelegateArc
    {
            //declare a delegate
            //this gives the signature for call-back function
            public Action<int, string> delAct1;

            public void callActionDel()
            {
                //create delegate instance and pass the call-back function to be used by delegate-instance
                delAct1 = new Action<int, string>(callbackForDelegate);

                passDelegate(delAct1);
            }

            // call-back function to be passed to delegate
            void callbackForDelegate(int num, string value)
            {
                Console.WriteLine("inside callbackForDelegate");
            }


            void passDelegate(Action<int, string> delgateIn)
            {
                Console.WriteLine("about to call callbackForDelegate");

                //Trigger the delegate
                delgateIn(1, "123");
            }

    }
    
}
