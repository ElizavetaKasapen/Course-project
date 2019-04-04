using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_project
{
    class Figure
    {
        bool active = false;
        bool lady = false;

        public bool Active
        {
            set { active = value; }
            get { return active; }
        }

        public bool Lady
        {
            set { lady = value; }
            get { return lady; }
        }

        public Figure() { }


    }
}
