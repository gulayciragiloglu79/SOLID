using System.IO;
using System;

public class ShapeArea2
{
  public interface Animal {
    void fly();   
    void run();   
    void bark();
  }
  /*public class Bird : Animal {
          public void bark() { 
              
          }        
          public void run() {
              Console.WriteLine("Koşan kuş");
          }        
          public void fly() {
              Console.WriteLine("Uçan kuş");
          }
  }*/

  public interface Flyable {
      void fly();
  }
  public interface Runnable {
      void run();
  }
  public interface Barkable {
      void bark();
  }
  public class Bird : Flyable, Runnable {
      public void run() {
          Console.WriteLine("Kuş,Koşuyorum");
      }    
      public void fly() {
          Console.WriteLine("Kuş, Uçuyorum.");
          //logic
      }
  }

}