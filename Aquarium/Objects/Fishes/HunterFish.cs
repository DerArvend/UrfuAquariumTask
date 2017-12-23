using System.Drawing;
using Aquarium.Settings;

namespace Aquarium.Fishes
{
	public abstract class HunterFish : Fish
	{
		public IAquariumObject AttackTarget;
		protected HunterFish(Point startLocation, AquariumSettings settings) : base(startLocation, settings)
		{
		}
	}
}
