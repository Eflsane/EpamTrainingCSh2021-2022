using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_1_2.Figures;
using Task2_1_2.Figures.Shapes;
using Task2_1_2.Interfaces;
using Task2_1_1ClassLib;
using Task2_1_2.Figures.Circles;
using Task2_1_2.Figures.Polygonals;

namespace Task2_1_2
{
    static class UIConsole
    {
        static List<Figure> _figures;
        static CustomString _username;

        public static void StartDrawingUI()
        {
            _figures = new List<Figure>();

            DrawLogIn();
        }

        private static void DrawLogIn()
        {
            _username = new CustomString();
            string input = "";
            
            do
            {
                Console.WriteLine("Enter username: (type '!!' for exit)");
                input = Console.ReadLine();
                if (input != string.Empty && input != "!!")
                {
                    _username.ConvertFromString(input);
                    DrawBasicUI();
                }                 
            } while (input != "!!");

            
        }

        public static void DrawBasicUI()
        {
            bool isDrawingBasic = true;
            do
            {
                Console.Clear();
                Console.WriteLine($"User: {_username}");
                Console.WriteLine("1. Add figure \n" +
                    "2. Show canvas \n" +
                    "3. Clear canvas \n" +
                    "4. Log off \n" +
                    "5. Exit");

                switch (Console.ReadLine())
                {
                    case "1":
                        AddFigure(FigureInput());
                        break;
                    case "2":
                        DrawCanvas();
                        break;
                    case "3":
                        ClearCanvas();
                        break;
                    case "4":
                        isDrawingBasic = false;
                        ClearCanvas();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                }
            } while (isDrawingBasic);
            
        }

        private static int FigureInput()
        {

            int res;

            do
            {
                Console.WriteLine($"User: {_username}");
                Console.WriteLine("Choose figure \n" +
                    "1. Point \n" +
                    "2. Line \n" +
                    "3. Circumference \n" +
                    "4. Circle \n" +
                    "5. Ring \n" +
                    "6. Triangle \n" +
                    "7. Rectangle \n" +
                    "8. Square");
            } while (!int.TryParse(Console.ReadLine(), out res));

            return res;
        }

        private static void AddFigure(int figureNum) 
        {
            switch (figureNum) 
            {
                case (int)FigureType.Point:
                    AddToCanvas(CreatePoint());
                    break;
                case (int)FigureType.Line:
                    AddToCanvas(CreateLine());
                    break;
                case (int)FigureType.Circumference:
                    AddToCanvas(CreateRound(FigureType.Circumference));
                    break;
                case (int)FigureType.Circle:
                    AddToCanvas(CreateRound(FigureType.Circle));
                    break;
                case (int)FigureType.Ring:
                    AddToCanvas(CreateRound(FigureType.Ring));
                    break;
                case (int)FigureType.Triangle:
                    AddToCanvas(CreateTriangle());
                    break;
                case (int)FigureType.Rectangle:
                    AddToCanvas(CreateRect(FigureType.Rectangle));
                    break;
                case (int)FigureType.Square:
                    AddToCanvas(CreateRect(FigureType.Square));
                    break;
                default:
                    Console.WriteLine("There is no such figure");
                    break;
            }           
        }

        private static Point CreatePoint()
        {
            double x;
            Console.WriteLine("Enter X: ");
            if (!double.TryParse(Console.ReadLine(), out x))
                Console.WriteLine("X should be a number");

            double y;
            Console.WriteLine("Enter Y: ");
            if (!double.TryParse(Console.ReadLine(), out y))
                Console.WriteLine("Y should be a number");

            return new Point(x, y);
        }

        private static Line CreateLine()
        {
            Console.WriteLine("Enter line start point: ");
            Point point1 = CreatePoint();

            Console.WriteLine("Enter line end point: ");
            Point point2 = CreatePoint();

            return new Line(point1, point2);
        }

        private static Circumference CreateRound(FigureType roundType)
        {
            Console.WriteLine($"Enter {roundType} center point:");
            Point center = CreatePoint();

            double radius;
            Console.WriteLine($"Enter {roundType} radius: ");
            if(!double.TryParse(Console.ReadLine(), out radius))
                Console.WriteLine("radius should be a number");

            if(roundType == FigureType.Circumference)
                return new Circumference(center, radius);
            else if(roundType == FigureType.Circle) 
                return new Circle(center, radius);

            double radiusInside;
            Console.WriteLine($"Enter {roundType} internal radius: ");
            if (!double.TryParse(Console.ReadLine(), out radiusInside))
                Console.WriteLine("internal radius should be a number");

            return new Ring(center, radius, radiusInside);
        }

        private static Triangle CreateTriangle()
        {
            Console.WriteLine("Enter triangle 1st point: ");
            Point point1 = CreatePoint();

            Console.WriteLine("Enter line 2nd point: ");
            Point point2 = CreatePoint();

            Console.WriteLine("Enter line 3d point: ");
            Point point3 = CreatePoint();

            return new Triangle(point1, point2, point3);
        }

        private static Square CreateRect(FigureType rectType)
        {
            Console.WriteLine($"Enter {rectType} start point: ");
            Point startPoint = CreatePoint();

            double width;
            Console.WriteLine($"Enter {rectType} width: ");
            if (!double.TryParse(Console.ReadLine(), out width))
                Console.WriteLine("width should be a number");

            if (rectType == FigureType.Square)
                return new Square(startPoint, width);

            double height;
            Console.WriteLine($"Enter {rectType} height: ");
            if (!double.TryParse(Console.ReadLine(), out height))
                Console.WriteLine("height should be a number");

            return new Rectangle(startPoint, width, height);
        }

        private static void AddToCanvas(Figure figure)
        {
            _figures.Add(figure);
        }

        private static void DrawCanvas()
        {
            Console.WriteLine($"User: {_username}");
            foreach (Figure f in _figures)
                f.Display();

            Console.ReadKey();
        }

        private static void ClearCanvas()
        {
            _figures.Clear();
        }    
    }
}
