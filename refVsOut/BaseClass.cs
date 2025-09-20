using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refVsOut;

internal class BaseClass
{
    public virtual void Add(int num1, int num2)
    {
        Console.WriteLine($"Base is called {num1+num2}"); 
    }
}

internal class ParentClass  : BaseClass
{
    public override void Add(int num1,int num2)
    {
        Console.WriteLine($"Parent is called {num1 * num2}");
    }
}



