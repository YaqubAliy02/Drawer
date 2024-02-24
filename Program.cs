using System;


namespace ShapeDrawer
{
    class Program
    {
        static void Main()
        {
            bool continueDrawing = true;

            while (continueDrawing)
            {
                Console.WriteLine("Choose a shape to draw:");
                Console.WriteLine("1. Triangle");
                Console.WriteLine("2. Square");
                Console.WriteLine("3. Rectangle");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice (1-4): ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        DrawTriangle();
                        break;
                    case "2":
                        DrawSquare();
                        break;
                    case "3":
                        DrawRectangle();
                        break;
                    case "4":
                        continueDrawing = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select 1-4.");
                        break;
                }

                if (continueDrawing)
                {
                    Console.Write("Do you want to continue drawing? (y/n): ");
                    string continueInput = Console.ReadLine();
                    continueDrawing = (continueInput.ToLower() == "y");
                }
            }

            Console.WriteLine("Thank you for using the Shape Drawer!");
        }

        static void DrawTriangle()
        {
            Console.WriteLine("Drawing a triangle:");

             for(int i = 0; i < 7; i++)
            {
                for(int j = 7; j > 0; j--)
                {
                    if(i >= j)
                    {
                        System.Console.Write("* ");
                    }else 
                    {
                        System.Console.Write(" ");
                    }
                }
               System.Console.WriteLine();
            }

        
        }

        static void DrawSquare()
        {
            Console.WriteLine("Drawing a square:");
              for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    System.Console.Write("* ");
                }
                System.Console.WriteLine();
            }

        }

        static void DrawRectangle()
        {
            Console.WriteLine("Drawing a rectangle:");
            for(int i = 0; i < 7; i++)
            {
                for(int j = 0; j < 15; j++)
                {
                    System.Console.Write("* ");
                }
                System.Console.WriteLine();
            }
        }

    }
}

