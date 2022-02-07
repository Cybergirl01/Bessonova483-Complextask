using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bessonova483___Complex
{
    public class Drawcircle
    {
        public float pos_x, pos_y;
        public bool selected, selectTarget;
        public string id;

        virtual public bool test(float x, float y)
        {
            return false;
        }
        virtual public void draw(Graphics g)
        {

        }
        virtual public void Maketarget()
        {

        }
    }
}
