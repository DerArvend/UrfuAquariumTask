using System;
using System.Collections.Generic;
using System.Drawing;
using Newtonsoft.Json.Linq;

namespace Aquarium.Fishes
{
	public interface IGame
	{
		IEnumerable<IGameObject> GetAllObjects();
		Size AquariumSize { get; }
		void Update();
		GameSettings Settings { get; }
	}
}
