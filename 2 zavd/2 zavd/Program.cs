using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_zavd
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector2D vec1 = new Vector2D();
            vec1.EnterVec();
            Vector2D vec2 = new Vector2D(22, 3);
            Console.WriteLine("length: " + vec1.VecLength());
            vec1.VecNormal();
            vec1.VecEquals(vec2);
            Console.WriteLine(vec1 + vec2);
            Console.WriteLine(vec1 - vec2);
            Console.WriteLine(vec1 * vec2);
            Console.Read();
        }
    }
}
