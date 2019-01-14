using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_8_Struct_Enum_Tuple_Generic
{
    partial class Lesson
    {
		public static void Struct2Example()
		{
			var array = new Coordinate[] { new Coordinate(20, 25) };
			var list = new List<Coordinate> { new Coordinate(20, 25) };

			var arrayElement1 = array[0];
			var listElement1 = list[0];

			arrayElement1.y = 1;
			listElement1.y = 1;

			Console.WriteLine($"array - {array[0]}");
			Console.WriteLine($"arrayElement - {arrayElement1.y}");
			Console.WriteLine($"list - {list[0]}");
			Console.WriteLine($"listElement - {listElement1.y}");
		}

		public static void StructExample()
        {
            Coordinate coord0 = new Coordinate(0, 0);
            Coordinate coord1;
            Coordinate coord2;

            coord1.x = 15;
            coord1.y = 15;
			Console.WriteLine($"Vector length - {coord1.Vector()}");

            coord2 = coord1;
			coord2.y = 10;
			Console.WriteLine($"Vector length - {coord2.Vector()}");
		}
    }

    public struct Color
    {
        public string rgb;
        public string name;
    }

	public struct Coordinate
	{
		public int x;
		public int y;

		public Coordinate(int x, int y)
		{
			this.x = x;
			this.y = y;
		}
		public double Length
		{
			get { return Vector(); }
		}
		public double Vector()
		{
			var length =  Math.Sqrt(x * x + y * y);
			return length;
		}
		public override string ToString()
		{
			return $"x - {this.x}; y - {this.y}";
		}
	}
}
