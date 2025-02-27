namespace shape;
using System;

public class Cylinder : shape3D

{
    private double radius;
    private double height;

    public Cylinder(double radius, double height)
    {
        Validate(radius, height);
        this.radius = radius;
        this.height = height;
    }

    private void Validate(double radius, double height)
    {
        if (radius <= 0 || height <= 0)
            throw new ArgumentException("Radius and height must be greater than 0.");
    }

    public override double GetVolume()
    {
        return Math.PI * Math.Pow(radius, 2) * height;
    }

    public override double GetSurfaceArea()
    {
        return 2 * Math.PI * radius * (radius + height);
    }

    public override string Dump()
    {
        return $"Cylinder: Surface Area = {GetSurfaceArea()}, Volume = {GetVolume()}";
    }
}
