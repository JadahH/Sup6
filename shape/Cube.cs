namespace shape;
using System;

public class Cube : shape3D
{
    private double side;

    public Cube(double side)
    {
        Validate(side);
        this.side = side;
    }

    private void Validate(double side)
    {
        if (side <= 0)
            throw new ArgumentException("Side length must be greater than 0.");
    }

    public override double GetVolume()
    {
        return Math.Pow(side, 3);
    }

    public override double GetSurfaceArea()
    {
        return 6 * Math.Pow(side, 2);
    }

    public override string Dump()
    {
        return $"Cube: Surface Area = {GetSurfaceArea()}, Volume = {GetVolume()}";
    }
}
