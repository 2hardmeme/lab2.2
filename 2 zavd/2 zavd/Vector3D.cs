using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_zavd
{
    class Vector3D : Vector2D
    {
        private double z_;
        public double z
        {
            get 
            { 
                return z_; 
            }
            set
            {
                z_ = value;
            }
        }
        public Vector3D() { }
        public Vector3D(double x, double y, double z) : base(x, y)
        {
            this.z = z;
        }
        public Vector3D(Vector3D vec) : base(vec)
        {
            this.z = vec.z;
        }
        override public string ToString()
        {
            return "x: " + x + "y: " + y + "z: " + z + "";
        }
        override public void EnterVec()
        {
            Console.WriteLine("Enter x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter z");
            double z = double.Parse(Console.ReadLine());
            this.x = x;
            this.y = y;
            this.z = z;
        }
        override public double VecLength()
        {
            return Math.Abs(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2)));
        }
        public new void VecNormal()
        {
            double n = x / this.VecLength();
            double m = y / this.VecLength();
            double k = z / this.VecLength();
            Console.WriteLine("normalized vector: ({0};{1};{2})", n, m, k);
        }
        public void VecEquals(Vector3D vec)
        {
            if (x == vec.x && y == vec.y && z == vec.z)
            {
                Console.WriteLine("vector 1 equals vector 2");
            }
            else
            {
                Console.WriteLine("vector 1 not equals to vector 2");
            }
        }
        public static Vector3D operator +(Vector3D a, Vector3D b)
        {
            double n = a.x + b.x;
            double m = a.y + b.y;
            double k = a.z + b.z;
            Vector3D vec = new Vector3D(n, m, k);
            return vec;
        }
        public static Vector3D operator -(Vector3D a, Vector3D b)
        {
            double n = a.x - b.x;
            double m = a.y - b.y;
            double k = a.z - b.z;
            Vector3D vec = new Vector3D(n, m, k);
            return vec;
        }
        public static double operator *(Vector3D a, Vector3D b)
        {
            double n = a.x * b.x;
            double m = a.y * b.y;
            double k = a.z * b.z;
            double result = n + m + k;
            return result;
        }
    }
}