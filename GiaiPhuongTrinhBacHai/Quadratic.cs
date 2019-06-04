using System;

class Quadratic
{
    public int a { get; set; }
    public int b { get; set; }
    public int c { get; set; }
    public Roots r { get; set; }
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

    public Roots GiaiPhuongTrinh(int a, int b, int c)
    {
        Roots r = new Roots();
        int delta = b * b - 4 * a * c;

        if (delta < 0)
        {
            r.RootsNumber = 0;
            return r;
        }
        else if (delta == 0)
        {
            r.Root1 = GetDualRoots();
            r.Root2 = GetDualRoots();
            r.RootsNumber = 1;
            return r;
        }
        else
        {
            r.Root1 = GetRoot1();
            r.Root2 = GetRoot2();
            r.RootsNumber = 2;
            return r;
        }
    }
}