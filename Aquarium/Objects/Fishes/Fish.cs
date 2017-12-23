using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Aquarium.Geometry;
using Aquarium.Logic;
using Aquarium.Objects.States;
using Aquarium.Settings;

namespace Aquarium.Fishes
{
	public abstract class Fish : IAquariumObject
	{
		protected Dictionary<FishState, Action<IAquarium>> Actions;
		public FishState CurrentState { get; protected set; }
		public Point Direction { get; protected set; }
		public int Hunger { get; protected set; }//value from 0 to 100
		public Size Size { get; protected set; }
		public Point Location { get; protected set; }
		public bool ShouldBeDestroyed { get; }
		private static Random rand = new Random();


		protected Fish(Point startLocation, AquariumSettings settings)
		{
			Action<IAquarium> doNothing = x => { };

			Actions = Enum.GetValues(typeof(FishState))
				.Cast<FishState>()
				.ToDictionary(x => x, x => doNothing);
			CurrentState = FishState.Default;
			Location = startLocation;
			Direction = Location;
		}

		public abstract void UpdateState(IAquarium aquarium);

		public void Update(IAquarium aquarium)
		{
			UpdateState(aquarium);
			Actions[CurrentState].Invoke(aquarium);
		}

		protected IEnumerable<HunterFish> GetEnemies(IAquarium aquarium)
		{
			return aquarium.AllObjects
				.Where(f => f is HunterFish)
				.Where(f => ((HunterFish) f).AttackTarget == this)
				.Cast<HunterFish>();
		}

		public void Kill()
		{
			CurrentState = FishState.Dead;
		}

		protected Vector GetRunAwayDirection(IEnumerable<IAquariumObject> enemies)
		{
			var directionVector = enemies.Aggregate(Vector.Zero,
				(current, enemy) => current - new Vector(enemy.Location.Substract(Location)));
			return directionVector.Normalize();
		}

		protected IEnumerable<FishFood> GetFoodNear(IAquarium aquarium, double searchRadius)
		{
			return aquarium.AllObjects
				.Where(o => o is FishFood)
				.Where(food => food.Location.GetDistanceTo(Location) <= searchRadius)
				.Cast<FishFood>();
		}

		protected double GetHungerRadius(IAquarium aquarium, double defaultHungerRadius)
		{
			return defaultHungerRadius + defaultHungerRadius *
			       (1 - Hunger / 100) * aquarium.Settings.maxHungerRadiusCoefficent;
		}


		protected Point SelectRandomDirection(Size size)
		{
			return new Point(
				rand.Next(0, size.Width - Size.Width),
				rand.Next(0, size.Height - Size.Height));
		}
	}
}