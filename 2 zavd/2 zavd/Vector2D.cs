using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_zavd
{
    class Vector2D
    {
        //поля для зберігання координат
        private double x_;
        private double y_;
        public double x
        {
            get 
            { 
                return x_; 
            }
            set
            {
                x_ = value;
            }
        }
        public double y
        {
            get 
            {
                return y_;
            }
            set
            {
                y_ = value;
            }
        }
        //пустий конструткор
        public Vector2D() { }
        //конструктоp який ініціалізуэться від чисел
        public Vector2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        //конструктор від об'єкту
        public Vector2D(Vector2D vec)
        {
            this.x = vec.x;
            this.y = vec.y;
        }
        override public string ToString()
        {
            return "x: " + x + "" + "y: " + y + "";
        }
        public virtual void EnterVec()
        {
            Console.WriteLine("Enter x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y");
            double y = double.Parse(Console.ReadLine());
            this.x = x;
            this.y = y;
        }
        public virtual double VecLength()
        {
            return Math.Abs(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)));
        }
        public virtual void VecNormal()
        {
            double n = x / this.VecLength();
            double m = y / this.VecLength();
            Console.WriteLine("normalized vector: {0}, {1}", n, m);
        }
        public virtual void VecEquals(Vector2D vec)
        {
            string equals = "";
            if (x == vec.x && y == vec.y)
            {
                equals = "vector 1 equals vector 2";
            }
            else
            {
                equals = "vector 1 not equals to vector 2";
            }
            Console.WriteLine(equals);
        }
        public static Vector2D operator +(Vector2D a, Vector2D b)
        {
            double n = a.x + b.x;
            double m = a.y + b.y;
            Vector2D vec = new Vector2D(n, m);
            return vec;
        }
        public static Vector2D operator -(Vector2D a, Vector2D b)
        {
            double n = a.x - b.x;
            double m = a.y - b.y;
            Vector2D vec = new Vector2D(n, m);
            return vec;
        }
        public static double operator *(Vector2D a, Vector2D b)
        {
            double n = a.x * b.x;
            double m = a.y * b.y;
            return n + m;
        }
    }
}