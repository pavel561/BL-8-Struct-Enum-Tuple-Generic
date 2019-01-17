using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_8_Struct_Enum_Tuple_Generic
{
	partial class Practice
	{
		public static Random random = new Random();


		/// <summary>
		/// BL8-P1/3. Cоздать структуру 2DRectangle, которая будет содержать ширину, высоту и координату.
		/// </summary>
		public static void Lb8_P1_3()
		{
			Rectangle rectangle = new Rectangle(10, 20, 50, 50);
			Console.WriteLine(rectangle);
			Console.ReadLine();
		}
		public struct Rectangle
		{
			public int Height;
			public int Width;
			public Coordinate Coord;
			public Rectangle(int CoordX, int CoordY, int Height, int Width)
			{
				Coord = new Coordinate(CoordX, CoordY);
				this.Height = Height;
				this.Width = Width;
			}
			public override string ToString()
			{
				return $"heigth - {this.Height}; width - {this.Width}; {Coord}";
			}
		}
		public struct Coordinate
		{
			public int X;
			public int Y;
			public Coordinate(int X, int Y)
			{
				this.X = X;
				this.Y = Y;
			}
			public override string ToString()
			{
				return $"coordX - {this.X}; coordY - {this.Y}";
			}
		}


		/// <summary>
		/// BL8-P2/3. Cоздать случайный массив квадратов с количеством элементов 100. 
		/// Используйте класс Random(10), чтоб установить значения сторон. 
		/// </summary>
		public static void Lb8_P2_3()
        {
			const int COUNT = 100;
			const int RND_VALUE = 5;
			Random rnd = new Random();
			Random rnd2 = new Random();
			Rectangle[] massRectangle = new Rectangle[COUNT];
			//Заполняю массив случайными значениями
			for(int i = 0; i < COUNT; i++)
			{
				massRectangle[i] = new Rectangle(rnd.Next(RND_VALUE), rnd.Next(RND_VALUE), rnd.Next(1, RND_VALUE), rnd.Next(1, RND_VALUE));
			}
			//Вывожу на консоль
			foreach (Rectangle rectangle in massRectangle)
			{
				Console.WriteLine(rectangle);
			}
			//Создаю List и копирую в него элементы массива
			List<Rectangle> listRectangle = new List<Rectangle>();
			foreach(Rectangle item in massRectangle)
			{
				listRectangle.Add(item);
			}
			//Сравниваю каждый элемент списка с остальными, при совпадении всех полей объекта - удаляю дубликат
			for (int item = 0; item < listRectangle.Count-1; item++)
			{
				for(int i = item+1; i<listRectangle.Count;)
				{
					if (listRectangle[item].Height == listRectangle[i].Height &&
						listRectangle[item].Width == listRectangle[i].Width &&
						listRectangle[item].Coord.X == listRectangle[i].Coord.X &&
						listRectangle[item].Coord.Y == listRectangle[i].Coord.Y)
					{
						listRectangle.Remove(listRectangle[i]);
					}
					else
					{
						i++;
					}
				}
			}
			//Вывожу на консоль получившийся список
			Console.WriteLine($"");
			foreach (Rectangle rectangle in listRectangle)
			{
				Console.WriteLine(rectangle);
			}
			//Вывожу на консоль информацию о количестве элементов
			Console.WriteLine($"Количество элементов в исходном массиве = {massRectangle.Length}");
			Console.WriteLine($"Количество элементов в очищенном массиве = {listRectangle.Count}");
			Console.ReadLine();
		}

        /// <summary>
        /// BL8-P3/3.Anonymous. Создать метод GetSongData, 
        /// который принимает обьекта типа Song и возвращает анонимный тип, 
        /// который содержит Title, Minutes, Seconds и AlbumYear. 
        /// </summary>
        public static void Lb8_P3_3_Anonymous()
        {            
        }

		//public Anonymous GetSongData()
		//{
		//	return null;
		//}

    }
}
