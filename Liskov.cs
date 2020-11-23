using System.Collections.Generic;
using System;
using System.IO;
public class ShapeArea{
  public interface Shape {
    long area();
  }
  public class Square : Shape {
      private int size;
      public Square(int size) {
          this.size = size;
      }
      //@Override
      public long area() {
          return size * size;
      }
      public void setSize(int size) {
          this.size = size;
      }
  }
  public class Rectangle : Shape {    
    private int width;
      private int height;    
      public Rectangle(int width, int height) {
          this.width = width;
          this.height = height;
      }    
      //@Override
      public long area() {
          return width * height;
      }    
      public void setWidth(int width) {
          this.width = width;
      }    
      public void setHeight(int height) {
          this.height = height;
      }
  }
  public double testSquareArea()  {
          Shape square = new Square(5);
          if ( square.area()==25)
            Console.WriteLine("");

            return  square.area();


  }
}


