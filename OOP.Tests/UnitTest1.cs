namespace OOP.Tests;

public class UnitTest1
{
    [Fact]
    public void CubeVolume()
    {
    Cube cube = new Cube(3);
        Assert.AreEqual(27, cube.GetVolume());
    }

    [Fact]
    public void CubeSurfaceAreaTest()
    {
        Cube cube = new Cube(3);
        Assert.AreEqual(54, cube.GetSurfaceArea());
    }


    [Fact]
    public void SphereVolumeTest()
    {
        Sphere sphere = new Sphere(2);
        Assert.AreEqual((4.0 / 3.0) * Math.PI * Math.Pow(2, 3), sphere.GetVolume(), 1e-6);
    }

    [Fact]
    public void SphereSurfaceAreaTest()
    {
        Sphere sphere = new Sphere(2);
        Assert.AreEqual(4 * Math.PI * Math.Pow(2, 2), sphere.GetSurfaceArea(), 1e-6);
    }

    [Fact]
    public void CylinderVolumeTest()
    {
        Cylinder cylinder = new Cylinder(2, 5);
        Assert.AreEqual(Math.PI * Math.Pow(2, 2) * 5, cylinder.GetVolume(), 1e-6);
    }

    [Fact]
    public void CylinderSurfaceAreaTest()
    {
        Cylinder cylinder = new Cylinder(2, 5);
        Assert.AreEqual(2 * Math.PI * 2 * (2 + 5), cylinder.GetSurfaceArea(), 1e-6);
    }

}