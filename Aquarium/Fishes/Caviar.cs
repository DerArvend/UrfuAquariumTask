using System;
using System.Drawing;

namespace Aquarium.Fishes
{
	class Caviar : IGameObject
	{
		public Point Locaton { get; }

		public Size GetSize()
		{
			throw new NotImplementedException();
		}

		public Point GetLocation()
		{
			return Locaton;
		}

		public bool Update(IGame game)
		{
			throw new NotImplementedException();
		}
	}
}
