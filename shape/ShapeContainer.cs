using System;
using System.Collections.Generic;

namespace shape;

public class ShapeContainer
{

private List<Shape3D> shapes = new List<Shape3D>();

    public void Create(Shape3D shape)
    {
        shapes.Add(shape);
    }

    public Shape3D Get(int index)
    {
        if (index >= 0 && index < shapes.Count)
            return shapes[index];

        throw new IndexOutOfRangeException("Invalid index.");
    }


}
