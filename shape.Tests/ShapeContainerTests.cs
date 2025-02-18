using System;
using Xunit; 
using shape; 
 

public class ShapeContainerTests
{
    [Fact]
    public void Test1()
    {
    // Arrange
        ShapeContainer container = new ShapeContainer();
        Cube cube = new Cube(5);

        // Act
        container.Create(cube);
        Shape3D retrieved = container.Get(0);

        // Assert
        Assert.Equal(cube, retrieved);
    }

    [Fact]
    public void Test2()
    {
        // Arrange
        ShapeContainer container = new ShapeContainer();
        Sphere sphere = new Sphere(3);

        // Act
        container.Create(sphere);
        bool deleted = container.Delete(0);

        // Assert
        Assert.True(deleted);
        Assert.Throws<IndexOutOfRangeException>(() => container.Get(0));
    }




}