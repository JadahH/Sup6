using System;

class Program
{

 static void Main()
    {
        ShapeContainer container = new ShapeContainer();
        
        while (true)
        {
            Console.WriteLine("\nOptions:");
            Console.WriteLine("1 - Create Shape");
            Console.WriteLine("2 - Get Shape");
            Console.WriteLine("3 - Delete Shape");
            Console.WriteLine("4 - Exit");
            Console.Write("Enter your choice: ");
            string input = Console.ReadLine();

            if (input == "1") // Create Shape


 {
                Console.Write("Enter shape type (Cube/Sphere/Cylinder): ");
                string type = Console.ReadLine();
                Shape3D shape = null;

                try
                {
                    if (type.Equals("Cube", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Write("Enter side length: ");
                        double side = Convert.ToDouble(Console.ReadLine());
                        shape = new Cube(side);
                    }
                    else if (type.Equals("Sphere", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Write("Enter radius: ");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        shape = new Sphere(radius);
                    }
                    else if (type.Equals("Cylinder", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Write("Enter radius: ");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter height: ");
                        double height = Convert.ToDouble(Console.ReadLine());
                        shape = new Cylinder(radius, height);
                    }

                    if (shape != null)
                    {
                        container.Create(shape);
                        Console.WriteLine("Shape created: " + shape.Dump());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

     }
            else if (input == "2") // Get Shape
            {
                Console.Write("Enter index: ");
                int index = Convert.ToInt32(Console.ReadLine());

                try
                {
                    Shape3D shape = container.Get(index);
                    Console.WriteLine("Retrieved Shape: " + shape.Dump());
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            else if (input == "3") // Delete Shape
            {
                Console.Write("Enter index to delete: ");
                int index = Convert.ToInt32(Console.ReadLine());

                if (container.Delete(index))
                    Console.WriteLine("Shape deleted successfully.");
                else
                    Console.WriteLine("Invalid input. ");
            }
            else if (input == "4") // Exit
            {
                break;
    
    }

        }

    }
}
