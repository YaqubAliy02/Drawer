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
            Console.WriteLine("   /\\");
            Console.WriteLine("  /  \\");
            Console.WriteLine(" /____\\");
        }

        static void DrawSquare()
        {
            Console.WriteLine("Drawing a square:");
            Console.WriteLine(" ______");
            Console.WriteLine("|      |");
            Console.WriteLine("|      |");
            Console.WriteLine("|______|");
        }

        static void DrawRectangle()
        {
            Console.WriteLine("Drawing a rectangle:");
            Console.WriteLine(" ___________");
            Console.WriteLine("|           |");
            Console.WriteLine("|           |");
            Console.WriteLine("|___________|");
        }

    }
}

