using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shape shape1 = new Shape(); Shape is declared abstract

            Circle circle1 = new Circle();
            Triangle triangle1 = new Triangle();
            Square square1 = new Square();

            Shape shape44 = new Circle();

           

            triangle1.setCoordinates(45, 45);

            //Parent/superclass refference can point to a subclass (or any decendant) object type
            Shape shape2 = square1;

            shape2.color = "blue";
            Console.WriteLine(square1.color);



            //Create an array of shapes
            Shape[] myShapes = new Shape[3];
            myShapes[0] = square1;
            myShapes[1] = triangle1;
            myShapes[2] = circle1;

            foreach (Shape  thing in myShapes)
            {
                thing.color = "Pink";
                thing.setCoordinates(0, 0);
            }




            Console.ReadLine();





        }
    }
    //Shape cannot be instanciated
    abstract class Shape
    {
        public double xCoordinate;
        public double yCoordinate;
        public string color;

        public void setCoordinates(double x, double y)
        {
            xCoordinate = x;
            yCoordinate = y;
        }




    }


    class Square : Shape
    {
        public void calculateArea()
        {
            double area = xCoordinate * yCoordinate;
            Console.WriteLine("The are a of this square is: " + area);
        }


    }

    class Circle : Shape
    {
        public void Spin()
        {
            Console.WriteLine("Spin....");
        }

    }

    class Triangle : Shape
    {

    }



}
