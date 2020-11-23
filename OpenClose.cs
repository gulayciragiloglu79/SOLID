using System.Collections.Generic;
using System;
public class AreaService {


  public class Circle { 
   private double _radius; 
  public double Radius
   {
       get { return _radius ; }
       set {
          this._radius = value ;
       }
   }
  }
  public class Rectangle { 
   private double _height; 
   public double Height
   {
       get { return _height ; }
       set {
          this._height = value ;
       }
   }
   private double _lenght; 
  public double Lenght
   {
       get { return _lenght ; }
       set {
          this._lenght = value ;
       }
   }
    /*public double getLenght() {
      return this._lenght;
    }
    public setLenght(value) {
      this._lenght = value;
    }

    public getHeight() {
      return this._height;
    }
    public Height(value) {
      this._height = value;
    }*/
  }
  //yanlış yöntem
 /* public double calculateArea(List<Rectangle> shapes) {
        double area = 0;
        for (Rectangle rect : shapes) {
            area += (rect.getLength() * rect.getHeight());
        }
        return area;
  }*/

    public double calculateArea(List<object> shapes) {
        double area = 0;
        foreach (object  shape  in shapes) {
            //if (shape instanceof Rectangle) {
            if (shape.GetType() == typeof(Rectangle)){
                Rectangle rect = (Rectangle)shape;
                area += (rect.Lenght * rect.Height);
            } else if (shape.GetType() == typeof(Circle)) {
                Circle circle = (Circle) shape;
                area += circle.Radius * circle.Radius * Math.PI;
            } /*else {
                throw new RuntimeExceptin("Shape not supported");
            }*/
        }
         
        return area;
    }


}

//doğru openclose
public class AreaService2 {
public interface Shape {
    double getArea(); 
}

  public class Circle : Shape { 
   private double _radius; 
   public double Radius
   {
       get { return _radius ; }
       set {
          this._radius = value ;
       }
   }
   //@override 
   public double getArea() {
      return   (Radius * Radius * Math.PI);
   }

  }
  public class Rectangle { 
   private double _height; 
   public double Height
   {
       get { return _height ; }
       set {
          this._height = value ;
       }
   }
   private double _lenght; 
  public double Lenght
   {
       get { return _lenght ; }
       set {
          this._lenght = value ;
       }
   }
   public double getArea() {
      return   (Height * Lenght);
   }
  }


  public class AreaManager {
   public double calculateArea(List<Shape> shapes) {
    double area = 0;
     foreach (Shape  shape  in shapes) {
      area += shape.getArea();
   }
   return area;
 }
}

}