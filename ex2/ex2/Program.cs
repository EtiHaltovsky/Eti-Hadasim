// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 3)
        {
          
            Console.WriteLine("Welcome to the construction and real estate system of the Twitter company");
           
            Console.WriteLine("Please choose one of the following options");
            Console.WriteLine("1:Choosing a rectangle tower");
            Console.WriteLine("2:Choosing a triangle tower");
            Console.WriteLine("3:Exit the program");

            
            choice = Convert.ToInt32(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    RectangleTower();
                    break;
                case 2:
                    int a = 0;
                    Console.WriteLine("please chose one");
                    Console.WriteLine("1:perimeter");
                    Console.WriteLine("2:print the triangle");
                    a = Convert.ToInt32(Console.ReadLine());

                    switch (a)
                    {
                        case 1:
                            TrianglePerimeter();
                            break;
                        case 2:
                            TriangleTower();
                            break;
                        default:
                            Console.WriteLine("Please enter a valid selection(1-2)");
                            break;
                    }
                    //TriangleTower();
                    break;
                case 3:
                    Console.WriteLine("Thank you and goodbye");
                    break;
                default:
                    Console.WriteLine("Please enter a valid selection(1-3)");
                    break;
            }
        }
    }
    static void TrianglePerimeter()
    {
        Console.WriteLine("Please enter the width of the triangle:");
        double width, height;

        //Receiving the width from the user
        if (!double.TryParse(Console.ReadLine(), out width) || width <= 0)
        {
            Console.WriteLine("The input is incorrect, please enter a positive number.");
            return;
        }

        Console.WriteLine("Please enter the height of the triangle:");

       // Receiving the height from the user
        if (!double.TryParse(Console.ReadLine(), out height) || height <= 0)
        {
            Console.WriteLine("The input is incorrect, please enter a positive number.");
            return;
        }

        //Calculation of the excess according to the Pythagorean theorem
        double hypotenuse = Math.Sqrt(Math.Pow((width/2), 2) + Math.Pow(height, 2));

        //Calculate the perimeter of the triangle
        double perimeter = width+ ( hypotenuse*2);

        Console.WriteLine($"the perimeter is: {perimeter}");
    }

    static void RectangleTower()
    {
        Console.WriteLine("Please enter the height of the tower");
        int height = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the weight of the tower");
        int width = Convert.ToInt32(Console.ReadLine());

        if (height >= 2 && width >= 2)
        {
            if (height == width)
            {
                Console.WriteLine("area: " + (height * width));
            }
            else
            {
                Console.WriteLine("perimeter : " + 2 * (height + width));
            }
        }
        else
        {
            Console.WriteLine("Height of the tower must be greater than or equal to 2");
        }
    }

    static void TriangleTower()
    {
       

        Console.WriteLine("Please enter the height of the triangle");
        int height = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the weight of the triangle");
        int width = Convert.ToInt32(Console.ReadLine());
        //להוסיף לפני ההמרה בדיקה שזה באמת מספר
        if (height >= 2 && width >= 2)
        {
            if (width % 2 != 0 && width <= height * 2)
            {
                if (width != 3)
                {
                    //How many lines prints the same number of stars
                    int baseLine = (height - 2) / (width / 2 - 1);
                    //Calculates what you have left and adds
                    int leftoverLine = (height - 2) % (width / 2 - 1);

                    for (int i = 1; i <= width; i += 2)
                    {

                        if (i == 1 || i == width)
                        {
                            for (int x = 0; x < (width - i) / 2; x++)
                            {
                                Console.Write(" ");
                            }
                            for (int j = 0; j < i; j++)
                            {
                                Console.Write("*");
                            }
                        }
                        else
                        {
                            int cala = i == 3 ? baseLine + leftoverLine : baseLine;
                            for (int j = 0; j < cala; j++)
                            {
                                for (int x = 0; x < (width - i) / 2; x++)
                                {
                                    Console.Write(" ");
                                }
                                for (int y = 0; y < i; y++)
                                {
                                    Console.Write("*");
                                }
                                if (j + 1 < cala)
                                {
                                    Console.WriteLine();
                                }

                            }


                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    for (int i = 1; i <height; i++)
                    {

                        Console.Write(" ");
                        Console.Write("*");
                        Console.WriteLine();
                    }
                    Console.Write("***");
                    Console.WriteLine();
                }
         
            }
            else
            {

                Console.WriteLine("cant print the triangle");
            }
        }
        else
        {
            Console.WriteLine("the number must be bigger then 2");

        }
    }
}

