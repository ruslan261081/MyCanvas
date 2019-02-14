using Canvas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            MyCanvas.CreateNewButton(7, 7, 10, 10);
            MyCanvas.CreateNewButton(5, 5, 15, 15);
            MyCanvas.CreateNewButton(8, 8, 20, 20);

            MyCanvas.MoveButton(0, 5, 100);

            if (MyCanvas.CheckIfAnyButtonIsOvefLapping() == true)
            {
                Console.WriteLine("There is Button over Lapping");
            }

            MyCanvas.GetCurrentNumberOfButtons();
            MyCanvas.Print();
            
            

             
        }
       
    }
}
