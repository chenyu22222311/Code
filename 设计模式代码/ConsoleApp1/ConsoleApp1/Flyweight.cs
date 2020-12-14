using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    //享元模式
    public abstract class Shape
    {
       public  abstract  void  Draw();
    }
    public class Circle : Shape
    {
        private String color;
        private int x;
        private int y;
        private int radius;

        public Circle(String color)
        {
            this.color = color;
        }

        public void setX(int x)
        {
            this.x = x;
        }

        public void setY(int y)
        {
            this.y = y;
        }

        public void setRadius(int radius)
        {
            this.radius = radius;
        }

       
    public override void Draw()
        {
           Console.WriteLine("Circle: Draw() [Color : " + color
               + ", x : " + x + ", y :" + y + ", radius :" + radius);
        }
    }
    public class ShapeFactory
    {
        private static  Dictionary<String, Circle> list = new Dictionary<String, Circle>();

        public static Shape getCircle(String color)
        {
            Circle circle ;
            list.TryGetValue(color, out circle);

            if (circle == null)
            {
                circle = new Circle(color);
                list.Add(color, circle);
               Console.WriteLine("Creating circle of color : " + color);
            }
            return circle;
        }
    }

    public class FlyweightPatternDemo
    {
        private static  String [] colors = 
      { "Red", "Green", "Blue", "White", "Black" };
        public static void Main(string[] args)
        {

            for (int i = 0; i < 20; ++i)
            {
                Circle circle =
                   (Circle)ShapeFactory.getCircle(getRandomColor());
                circle.setX(getRandomX());
                circle.setY(getRandomY());
                circle.setRadius(100);
                circle.Draw();
            }
            Console.ReadLine();
        }
         private static String getRandomColor()
        {
            return colors[(int)( new Random().Next(0, colors.Length) )];
        }
        private static int getRandomX()
        {
            return (int)(new Random().Next(1,100)  );
        }
        private static int getRandomY()
        {
            return (int)(new Random().Next(1,100));
        }
    }

}
