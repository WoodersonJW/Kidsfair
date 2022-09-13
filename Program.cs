using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsFair
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            PrepareConsolesLook();
            //Arrange console window

            //Create an object (instance) of the Pet class
            Pet petObj = new Pet();

            //Use the object
            petObj.Start();

            Console.WriteLine("Press enter to start the next object");
            Console.ReadLine();

            //Start TicketSeller
            TicketSeller ticket = new TicketSeller();
            ticket.Start();

            Console.WriteLine("Press enter to start the next object");
            Console.ReadLine();

            //Start Album
            Album album = new Album();
            album.Start();

            Console.WriteLine("Press enter to exit the Program");
            Console.ReadLine();

        }
        static void PrepareConsolesLook()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear(); //Paint background with above color
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Kids Fair";
        }
}
}
