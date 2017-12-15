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


		public abstract Size GetSize();

		public abstract Point GetLocation();

		public abstract bool Update(IGame game);
	}
}
