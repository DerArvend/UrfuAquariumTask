using System;
using System.Drawing;

namespace Aquarium.Fishes
{
	class Caviar : IGameObject
	{
		public Size Size { get; }
		public Point Location { get; }
		public void Update(IGame game)
		{
			throw new NotImplementedException();
		}
	}
}
