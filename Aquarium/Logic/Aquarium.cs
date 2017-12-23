using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Aquarium.Fishes;
using Aquarium.Geometry;
using Aquarium.Settings;

namespace Aquarium.Logic
{
	class Aquarium : IAquarium
	{
		private readonly HashSet<IAquariumObject> allObjects;

		#region deprecated

		//public HashSet<FishFood> Food;
		//public HashSet<Caviar<Fish>> Caviars { get; }
		//public HashSet<Catfish> Catfishes { get; }
		//public HashSet<HunterFish> Hunters { get; }

		#endregion


		public IEnumerable<IAquariumObject> AllObjects => allObjects;
		public Size Size { get; }
		public AquariumSettings Settings { get; }

		public Aquarium(AquariumSettings settings, Size aquariumSize)
		{
			Settings = settings;
			Size = aquariumSize;
			allObjects = new HashSet<IAquariumObject>();
		}

		public void Update()
		{
			var objectsToDestroy = new List<IAquariumObject>();
			foreach (var obj in allObjects)
			{
				obj.Update(this);
				if (obj.ShouldBeDestroyed)
					objectsToDestroy.Add(obj);
			}
			foreach (var o in objectsToDestroy)
			{
				allObjects.Remove(o);
			}
		}

		public bool TryAddObject(IAquariumObject obj)
		{
			if (!obj.Location.IsInSize(Size))
				throw new ArgumentException("Object location is outside of aquarium borders");
	
			allObjects.Add(obj);
			return true;
		}
	}
}