using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInheritanceV2
{
    class Boat
    {
        private int length;
        public void setLength(int len)
        {
            length = len;
        }
        public int getLength()
        {
            return length;
        }
        public virtual string move() // we set move to virtual because we wanna override it later
        {
            return "dryfuje ";
        }

    }
}
