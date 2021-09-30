using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    abstract class AbstractClass
    {
        abstract public string Content
        {
            get;

            set;
        }
        abstract public void Show();
    }
}
