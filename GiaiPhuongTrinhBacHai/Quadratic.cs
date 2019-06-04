using System;

class Quadratic
{
    public int a{get; set;}
    public int b{get;set;}
    public int c{get;set;}

    public Quadratic(int _a, int _b, int _c)
    {
        a = _a;
        b = _b;
        c = _c;
    }

    public double GetDiscriminant() 
    {
        return (b * b - 4 * a * c);
    }

    public double GetRoot1()
    {
        return ((-b + Math.Sqrt(GetDiscriminant())) / (2 * a));
    }

    public double GetRoot2()
    {
        return ((-b - Math.Sqrt(GetDiscriminant())) / (2 * a));
    }

    public double GetDualRoots()
    {
        return (-b / (2 * a));
    }
}