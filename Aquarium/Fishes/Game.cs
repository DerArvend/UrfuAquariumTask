using System.Collections.Generic;
using System.Drawing;
using Aquarium.Settings;

namespace Aquarium.Fishes
{
	class Game : IGame
	{
		public IEnumerable<IGameObject> GetAllObjects()
		{
			throw new System.NotImplementedException();
		}

		public Size AquariumSize { get; }
		public void Update()
		{
			throw new System.NotImplementedException();
		}

		public bool TryAddObject<T>(T objectType, Point location) where T : IGameObject, new()
		{
			throw new System.NotImplementedException();
		}

		public GameSettings Settings { get; }
	}
}