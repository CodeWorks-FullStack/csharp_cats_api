
namespace cats_api_csharp.Models;

public class Cat
{

  public string Name { get; set; }
  public int Age { get; set; }
  public bool HasTail { get; set; }
  public double NumberOfLegs { get; set; }

  // NOTE constructor
  public Cat(string name, int age, bool hasTail, double numberOfLegs)
  {
    // this.Name = name;
    Name = name;
    Age = age;
    HasTail = hasTail;
    NumberOfLegs = numberOfLegs;
  }

}
