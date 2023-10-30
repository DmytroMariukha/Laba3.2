using System;

class Parent
{
    protected double Pole1;
    protected double Pole2;
    protected double Pole3;

    public Parent()
    {
        Pole1 = 0;
        Pole2 = 0;
        Pole3 = 0;
    }

    public Parent(double side, double angle)
    {
        Pole1 = side;
        Pole2 = angle;
        Pole3 = angle * (Math.PI / 180.0);
    }

    public void Print()
    {
        Console.WriteLine($"Side: {Pole1} одиниць");
        Console.WriteLine($"Angle (degrees): {Pole2} градусів");
        Console.WriteLine($"Angle (radians): {Pole3} радіан");
    }

    public double Metod1()
    {
        return Math.Pow(Pole1, 2) * Math.Sin(Pole3);
    }

    public double Metod2()
    {
        return 4 * Pole1;
    }
}

class Child : Parent
{
    public Child(double side) : base(side, 90)
    {
    }

    public double Metod3()
    {
        return Math.PI * Pole1 / 2;
    }

    public double Metod4()
    {
        return Math.PI * Pole1;
    }
}

class Program
{
    static void Main()
    {
        Random random = new Random();

        for (int i = 0; i < 5; i++)
        {
            double side = random.Next(1, 11); 
            double angle = random.Next(1, 180); 

            if (angle != 90)
            {
                Parent rhombus = new Parent(side, angle);
                Console.WriteLine("Rhombus:");
                rhombus.Print();
                Console.WriteLine($"Area: {rhombus.Metod1()}");
                Console.WriteLine($"Perimeter: {rhombus.Metod2()}");
            }
            else
            {
                Child square = new Child(side);
                Console.WriteLine("Square:");
                square.Print();
                Console.WriteLine($"Area: {square.Metod1()}");
                Console.WriteLine($"Perimeter: {square.Metod2()}");
                Console.WriteLine($"Area of inscribed circle: {square.Metod3()}");
                Console.WriteLine($"Circumference of inscribed circle: {square.Metod4()}");
            }

            Console.WriteLine();
        }
    }
}
