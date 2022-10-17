using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MaxContinuousValue
{/*陣列裡只會有 0, 3, 找出連續3的總和,例如
{0,3,3,0,0,3,3,3} => 9
{0,3,3,0,0,3,0,3,0,3} => 6
{0,3,0,0} => 3
*/
	internal class Program
	{
		static void Main(string[] args)
		{
			// 各個陣列
			int[][] items =
				{new int[] { 0, 3, 3, 0, 0, 3, 3, 3 },
				new int[]{ 0, 3, 3, 0, 0, 3, 0, 3, 0, 3 },
				new int[]{ 0, 3, 0, 0 }
			};

			for (int i = 0; i <= items.Length - 1; i++)// 取到陣列items最後的row
			{
				int sum = 0, subSum = 0;
				for (int k = 0; k <= items[i].Length - 1; k++)
				{
					if (items[i][k] == 0)
					{
						subSum = 0;
						continue;
					}
					else
					{
						subSum += items[i][k];
					}

					if (sum < subSum)
					{
						sum = subSum;
					}
				}
				Console.WriteLine($"總和{i}: {sum}");
			}
		}
	}
}
