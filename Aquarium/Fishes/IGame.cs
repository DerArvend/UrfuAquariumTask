using System.Collections.Generic;
using System.Drawing;
using Aquarium.Settings;

namespace Aquarium.Fishes
{
	public interface IGame
	{
		IEnumerable<IGameObject> GetAllObjects();
		Size AquariumSize { get; }
		void Update();
		bool TryAddObject<T>(T objectType, Point location) where T: IGameObject, new();
		GameSettings Settings { get; }
	}
}
