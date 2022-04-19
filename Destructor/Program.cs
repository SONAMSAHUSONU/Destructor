using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{
    //GC:-Garbage collector called in destructore to distored the un-usedless object
    //GC 
    public class Employee
    {
        //Destructor:- Destructor are used to distract the object of classes
        //we can't not call explicity destructors, destructtors called by GC.
        //destructore name same as a class name, it is use ~ tilled simbole
        //we can't used modifier in destructore, we can not pass parameters
        //user can not called by explicitly it is call by automatically
        //destructore(~) can't used under struct
        //destructore(~) can be difined only in class
        //destructore(~) can not have modifiers(Public private etc) and can not have parameter
        //destructore can not call by programmer, they invoked automatically
        //destructore called when program exit
        //destructore implicity calls finallized method 
        public Employee()
       {
        }

        ~Employee()
        {
        }

        public static void Main()
        {
            Employee e1 = new Employee();// it is not used in whole program 
        }
    }
}
