using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Aquarium.Fishes
{
	public interface IGame
	{
		IEnumerable<IGameObject> GetAllObjects();
		void Update();
		GameSettings Settings { get; }
	}
}
