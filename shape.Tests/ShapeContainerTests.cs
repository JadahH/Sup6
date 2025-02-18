namespace shape.Tests;

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
}