using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_project
{
    class Cell
    {
        string figure_color;
        int first_way=0, second_way=0;
        bool active = false;

        public int First_way
        {
            set { first_way = value; }
            get { return first_way; }
        }

        public int Second_way
        {
            set { second_way = value; }
            get { return second_way; }
        }

        public string Figure_color
        {
            set { figure_color = value; }
            get { return figure_color; }
        }

        public bool Active
        {
            set { active = value; }
            get { return active; }
        }
        public Cell(string n_color, int n_f_way, int n_s_way)
        {
            figure_color = n_color;
            first_way = n_f_way;
            second_way = n_s_way;
        }

        public Cell() {}
        public void Make_Active() { active = true; }///////////////пусть будет 
    }
}
