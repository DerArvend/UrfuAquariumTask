using System.Collections.Generic;
using System.Drawing;
using Aquarium.Fishes;
using Aquarium.Settings;

namespace Aquarium.Logic
{
	public interface IAquarium
	{
		IEnumerable<IAquariumObject> AllObjects { get; }
		Size Size { get; }
		void Update();
		bool TryAddObject(IAquariumObject obj);
		AquariumSettings Settings { get; }
	}
}
