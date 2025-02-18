using System;
namespace shape;

public abstract class shape3D
{
    public abstract double GetVolume();
    public abstract double GetSurfaceArea();
    public abstract string Dump();
}
