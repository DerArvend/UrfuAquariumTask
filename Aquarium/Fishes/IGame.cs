using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Aquarium.Fishes
{
	public interface IGame
	{
		IEnumerable<IGameObject> GetAllObjects();
		JObject Settings { get; }
	}
}
