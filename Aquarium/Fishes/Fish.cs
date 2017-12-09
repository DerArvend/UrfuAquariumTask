using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium.Fishes
{
	public abstract class Fish: IGameObject
	{
		

		public Size GetSize()
		{
			throw new NotImplementedException();
		}

		public Point GetLocation()
		{
			throw new NotImplementedException();
		}

		public bool Update(IGame game)
		{
			throw new NotImplementedException();
		}
	}
}
