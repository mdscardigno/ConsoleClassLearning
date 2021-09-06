using System;

namespace ConsoleClassLearning
{
  public class Person{
    /*
    CREATING SOME FIELDS: Name, Age and HasPet
    */
    public string Name;
    public int Age;
    public bool HasPet;
    /*
    CREATING A METHOD CALLED Greetings(); 
    We then determine if we are returning a value or if we make this method void 
    so it does not have to return any value. Just display a greeting in this case.
    */
    public void Greetings(){
      Console.WriteLine($"Hi!. My name is {Name} and my age is: {Age}");
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      /*
      Creating an instantieted object, of the Person class we defined
      This specific object is based off the class we created      */
      //we allocated new memory inside the application
      Person person = new Person();
      person.Name = "Mila";
      person.Age = 140;
      person.HasPet = true;
      /*which is what we do when wanting to instantiate a new object or a new class to create
      an object inside application.
      */
      person.Greetings();

    }
  }
}
