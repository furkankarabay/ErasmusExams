
//Student Library

using System;

namespace Library
{
  abstract class Person 
  {
    public abstract void IStudy();
  }
  
  class Student : Person 
  {
    public override void IStudy()
    {
      Console.WriteLine("I Study");
    }
    static void Main(string[] args)
    {
      Student s1 = new Student();
      Student s2 = new Student();

      s1.IStudy();
      s2.IStudy();
    }
  }

}