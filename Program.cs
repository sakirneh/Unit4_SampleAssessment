using System;
using static System.Console;

namespace unit_4_sample_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            openMainMenu();
            //Declare openMainMenu procedure
            void openMainMenu()
            {
                //int shapeselection = 0;
                int shapeselection = 0;

                WriteLine($"Please choose from the following options:\nPress 1 to calculate a Circle Area,\nPress 2 to calculate a Circle Circumference,\nPress 3 to calculate Square Area,\npress 4 to calculate a Square Perimeter,\nPress 5 to calculate a Cuboid Volume,\nPress 6 to calculate a Cuboid surface area,\nPress 7 to access the help menu,\nPress 8 to exit the program");
                bool isNumber = int.TryParse(ReadLine(), out shapeselection);

                if (isNumber != true)
                {
                    Clear();
                    WriteLine("Input error. Integer values Only!");
                    openMainMenu();
                }
                else if (shapeselection < 1 || shapeselection > 8)
                {
                    Clear();
                    WriteLine("Input error. Selection not valid!");
                    openMainMenu();
                }
                else
                {
                    switch (shapeselection)
                    {
                        case 1:
                            calcCircleArea();
                            break;
                        case 2:
                            calcCircleCircumference();
                            break;
                        case 3:
                            calcSquareArea();
                            break;
                        case 4:
                            calcSquarePerimeter();
                            break;
                        case 5:
                            calcCuboidVolume();
                            break;
                        case 6:
                            calcCuboidSurfaceArea();
                            break;
                        case 7:
                            openHelpMenu();
                            break;
                        case 8:
                            exitProgram();
                            break;
                        default:
                            WriteLine("Invalid Selection");
                            openMainMenu();
                            break;
                    }
                }

            }

            //Declare openHelpMenu procedure
            void openHelpMenu()
            {
                WriteLine("This is the help menu");
                openMainMenu();
            }
            //Declare exitProgram procedure
            void exitProgram()
            {
                System.Environment.Exit(0);
            }
            //Declare calcCircleArea procedure
            void calcCircleArea()
            {
                
                double radius = 0.0;
                collectRadius(radius);
                double area = 3.1416 * radius * radius;
                WriteLine($"Circle Area = {area}");
                pauseProgram();
                openMainMenu();
            }
            //Declare calcCircleCircumference procedure
            void calcCircleCircumference()
            {
                Clear();
                double radius = 0.0;
                collectRadius(radius);
                double circumference = 3.1416 * radius * 2;
                WriteLine($"Circle Circumference = {circumference}");
                pauseProgram();
                openMainMenu();
            }
            //Declare calcSquareArea procedure
            void calcSquareArea()
            {
                Clear();
                double length = 0.0;
                collectLength(length);
                double area = length * length;
                WriteLine($"Square area = {area}");
                pauseProgram();
                openMainMenu();
            }
            //Declare calcSquarePerimeter procedure
            void calcSquarePerimeter()
            {
                double length = 0.0;
                collectLength(length);
                double perimeter = length * 4;
                WriteLine($"Square perimiter = {perimeter}");
                pauseProgram();
                openMainMenu();

            }
            //Declare calcCuboidVolume procedure
            void calcCuboidVolume()
            {
                Clear();
                double length = 0.0;
                double width = 0.0;
                double depth = 0.0;
                length = collectLength(length);
                width = collectWidth(width);
                depth = collectDepth(depth);
                double volume = length * width * depth;
                WriteLine($"Cubic volume = {volume}");
                pauseProgram();
                openMainMenu();

            }
            //Declare calcCuboidSurfaceArea procedure
            void calcCuboidSurfaceArea()
            {
                Clear();
                double length = 0.0;
                double width = 0.0;
                double depth = 0.0;
                collectLength(length);
                collectWidth(width);
                collectDepth(depth);
                double surfacearea = length * width * 2 + length * width * depth * 2;
                WriteLine($"Cuboid surface area = {surfacearea}");
                pauseProgram();
                openMainMenu();
            }

            //Implement collectRadius function as return type double with passed parameter radius
            double collectRadius(double radius)
            {
                WriteLine($"Please enter the radius of the circle");
                bool isDouble = double.TryParse(ReadLine(), out radius);

                WriteLine(radius);
                
                if (isDouble != true)
                {   
                    Clear();
                    WriteLine("Input error. Double values only! e.g. 2.02");
                    collectRadius(radius);
                }
                else if (radius < 0)
                {
                    Clear();
                    WriteLine("Input error. Negative values are not valid");
                    collectRadius(radius);
                }
                else
                {
                    return radius;
                }
                return radius;
            }
            //Declare collectLength double function that will parameter pass by reference length
            double collectLength(double length)
            {
                WriteLine($"Please enter the length");
                bool isDouble = double.TryParse(ReadLine(), out length);
                if (isDouble != true)
                {
                    Clear();
                    WriteLine("Input error. Numeric values only!");
                    collectLength(length);
                }
                else if (length < 0)
                {
                    Clear();
                    WriteLine("Input errors. Negative values are not valid");
                    collectLength(length);
                }
                else
                {
                    return length;
                }
                return length;
            }

            //Declare collectWidth double function that will parameter pass by reference width
            double collectWidth(double width)
            {
                WriteLine("Please enter the width of the cuboid");
                bool isDouble = double.TryParse(ReadLine(), out width);
                if (isDouble != true)
                {
                    Clear();
                    WriteLine("Input error. Numeric values only");
                    collectWidth(width);
                }
                else if (width < 0)
                {
                    Clear();
                    WriteLine("Input error. Negative values are not valid");
                    collectWidth(width);
                }
                else
                {
                    return width;
                }
                return width;
            }
            //Declare collectDepth double function that will parameter pass by reference depth
            double collectDepth(double depth)
            {
                WriteLine("Please enter the depth of the cuboid");
                bool isDouble = double.TryParse(ReadLine(), out depth);

                if (isDouble != true)
                {
                    Clear();
                    WriteLine("Input error. Numeric values only");
                    collectDepth(depth);
                }
                else if(depth < 0)
                {
                    Clear();
                    WriteLine("Input error. Negative values are not valid");
                    collectDepth(depth);
                }
                else
                {
                    return depth;
                }

                return depth;
            }

            void pauseProgram()
            {
                Thread.Sleep(5000); // wait 5s.
            }

        }
    }
}