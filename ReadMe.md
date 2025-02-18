# Shape3D OOP Implementation in C#

## Objective
This project introduces **Object-Oriented Programming (OOP) in C#** by implementing a **Shape3D** abstract class and its concrete subclasses: `Cube`, `Sphere`, and `Cylinder`. The project focuses on **abstraction, inheritance, validation, and unit testing**.

## Features
- **Abstract Class (`Shape3D`)**
  - `GetVolume()`: Returns the volume of the shape.
  - `GetSurfaceArea()`: Returns the surface area of the shape.
  - `Dump()`: Provides a string identifying shape name, surface area, and volume.
- **Concrete Classes:**
  - `Cube`: Implements volume and surface area formulas.
  - `Sphere`: Implements volume and surface area formulas.
  - `Cylinder`: Implements volume and surface area formulas.
- **Validation:**
  - Each class includes a private `Validate()` method ensuring that all dimensions are **greater than 0** before object creation.
- **Unit Testing:**
  - Tests overridden methods (`GetVolume()`, `GetSurfaceArea()`, and `Dump()`).
  - Ensures proper behavior of input validation.
- **Git Version Control Guidelines:**
  - Commit after each **test, function, and documentation update**.
  - Use **meaningful commit messages**.
  - Avoid improper Git practices such as nested repositories or a single commit for the entire assignment.

## Setup & Installation
1. Clone the repository:
   ```sh
   git clone <https://github.com/JadahH/Sup5.git>
   cd <Sup5>
   ```
2. Open the project in **Visual Studio** or any C# IDE.


## Running Unit Tests
Unit tests are implemented using **NUnit**. To execute the tests, use:
   dotnet test