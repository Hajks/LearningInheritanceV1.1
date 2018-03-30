using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LearningInheritanceV2
{
    class TestBoats
    {
        public static void Main() // we decide that our program will start from here. 
        {
            string xyz = "";
            Boat b1 = new Boat();
            Sailboat b2 = new Sailboat();
            Rowboat b3 = new Rowboat();
            b2.setLength(32);
            xyz = b1.move();
            xyz += b3.move();
            xyz += b2.move();
            System.Windows.Forms.MessageBox.Show(xyz); // we had to add reference for System.Windows.Forms
        }
    }
}
