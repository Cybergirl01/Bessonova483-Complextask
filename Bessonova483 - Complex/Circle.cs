using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bessonova483___Complex
{
    public class Circle : Drawcircle
    {
        public float radius;
        static public int local_id;

        public Circle(float rad)
        {

            local_id++;
            id = "node " + local_id.ToString();
            radius = rad;
        }

        public override bool test(float x, float y)
        {
            float radius_squared = radius * radius;
            float dx = x - pos_x;
            float dy = y - pos_y;
            if (dx * dx + dy * dy <= radius_squared) return true;
            return false;
        }

        public override void draw(Graphics g)
        {
            float diameter = radius * 2.0f;
            float x0 = pos_x - radius;
            float y0 = pos_y - radius;
            Pen p = Pens.Black;
            if (selected == true)
            { p = Pens.Green;
               g.DrawEllipse(p, x0-45, y0-45, 100, 100);
            }
            else if (selected == false)
            {
                p = Pens.Blue;
               
            }
            if (selectTarget == true)
            {
                p = Pens.Pink;
            }
            
            g.DrawEllipse(p, x0, y0, diameter, diameter);
        }
         public override void Maketarget()
        {
            float diameter = radius * 2.0f;
            float x0 = pos_x - radius;
            float y0 = pos_y - radius;
            Pen p = Pens.Black;

                if (selectTarget == false)
                {
                    p = Pens.Blue;
                }
            
            p = Pens.Pink;
        }
    }
}
