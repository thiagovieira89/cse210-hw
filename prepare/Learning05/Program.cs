using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Rectangle s1 = new Rectangle("Blue", 5,5);
        shapes.Add(s1);

        Square s2 = new Square("black", 2);
        shapes.Add(s2);

        Circle s3 = new Circle("White", 4);
        shapes.Add(s3);

        foreach (Shape all in shapes)
        {
            string color = all.GetColor();

            double area = all.GetArea();

            Console.WriteLine($"The color is {color} and the área is {area}\n");

        }

        
    }

}