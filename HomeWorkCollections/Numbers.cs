using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCollections
{
	public class Numbers
	{
		public IEnumerator<int> GetEnumerator()
		{
			for (int i = 0; i < 6; i++)
			{
				yield return i * i;
			}
		}
	}
}
