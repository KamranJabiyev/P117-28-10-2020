using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNS
{
    namespace InDemoNS.First
    {
        class Person
        {
            public Person()
            {
                Console.WriteLine("InDemoNS");
            }
        }
    }
    class Person
    {
        public Person()
        {
            Console.WriteLine("DemoNS");
        }
    }

    class Test
    {

    }
}

namespace DemoNS1
{
    class Person
    {
        public Person()
        {
            Console.WriteLine("DemoNS1");
        }
    }
}
