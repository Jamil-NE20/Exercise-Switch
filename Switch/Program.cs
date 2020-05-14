using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the student numerikal mark between 0 to 10:  ");
            int numerikalMark = Convert.ToInt32(Console.ReadLine());

            switch (numerikalMark)
            {
                case (0):
                case (1):
                case (2):
                case (3):
                case (4):
                    Console.WriteLine("Fail");
                    break;
                
                case (5):
                    Console.WriteLine("Pass");
                    break;
                case (6):
                    Console.WriteLine("Good");
                    break;
                case (7):
                case (8):
                    Console.WriteLine("Notable");
                    break;
                case (9):
                case (10):
                    Console.WriteLine("Excellent");
                    break;

                default:
                    Console.WriteLine("Your Numerikal mark is not valid! Try Again!");
                    break;
            }
            Console.WriteLine("\n\nEnter any key to quit!");
            Console.ReadLine();

            
        //if ((numerikalMark == 10) || (numerikalMark == 9))
        //    {
        //        Console.WriteLine("Excellent");
        //    }
        //    else if ((numerikalMark == 8) || (numerikalMark == 7))
        //    {
        //        Console.WriteLine("Notable");
        //    }
        //    else if (numerikalMark == 6)
        //    {
        //        Console.WriteLine("Good");
        //    }
        //    else if (numerikalMark == 5)
        //    {
        //        Console.WriteLine("Pass");
        //    }
        //    else if ((numerikalMark <= 4) && (numerikalMark >=0))
        //    {
        //        Console.WriteLine("Fail");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Your Numerikal mark is not valid! Try Again!");
        //    }
        //    Console.WriteLine("\n\nEnter any key to quit!");
        //    Console.ReadLine();
        }
    }
}
