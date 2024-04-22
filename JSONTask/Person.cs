using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONTask
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname {  get; set; }
        private static int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if(value>0)
                {
                    _age = value;
                }
            }
        }
    }
}
