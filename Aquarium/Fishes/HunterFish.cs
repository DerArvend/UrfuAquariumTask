using System.Drawing;

namespace Aquarium.Fishes
{
	public abstract class HunterFish : Fish
	{
		public IGameObject AttackTarget;
		protected HunterFish(Point startLocation) : base(startLocation)
		{
		}
	}
}
