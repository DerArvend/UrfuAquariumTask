using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Aquarium.Geometry;

namespace Aquarium.Fishes
{
	public abstract class Fish : IGameObject
	{
		protected Dictionary<FishState, Action<IGame>> Actions;
		protected FishState CurrentState;
		protected Point Direction;
		protected int Hunger; //value from 0 to 100
		public Size Size { get; protected set; }
		public Point Location { get; protected set; }


		protected Fish(Point startLocation)
		{
			Action<IGame> doNothing = x => { };

			Actions = Enum.GetValues(typeof(FishState))
				.Cast<FishState>()
				.ToDictionary(x => x, x => doNothing);
			CurrentState = FishState.Default;
			Location = startLocation;
			Direction = Point.Empty;
		}

		public abstract void UpdateState(IGame game);

		public void Update(IGame game)
		{
			UpdateState(game);
			Actions[CurrentState].Invoke(game);
		}

		protected IEnumerable<HunterFish> GetEnemies(IGame game)
		{
			return game.GetAllObjects()
				.Where(f => f is HunterFish)
				.Where(f => ((HunterFish) f).AttackTarget == this)
				.Cast<HunterFish>();
		}

		public void Kill()
		{
			CurrentState = FishState.Dead;
		}

		protected Vector GetRunAwayDirection(IEnumerable<IGameObject> enemies)
		{
			var directionVector = enemies.Aggregate(Vector.Zero,
				(current, enemy) => current - new Vector(enemy.Location.Substract(Location)));
			return directionVector.Normalize();
		}

		protected IEnumerable<FishFood> GetFoodNear(IGame game, double searchRadius)
		{
			return game.GetAllObjects()
				.Where(o => o is FishFood)
				.Where(food => food.Location.GetDistanceTo(Location) <= searchRadius)
				.Cast<FishFood>();
		}

		protected double GetHungerRadius(IGame game, double defaultHungerRadius)
		{
			return defaultHungerRadius + defaultHungerRadius *
			       (1 - Hunger / 100) * game.Settings.maxHungerRadiusCoefficent;
		}


		protected Point SelectRandomDirection(IGame game)
		{
			var rand = new Random();
			return new Point(
				rand.Next(0, game.AquariumSize.Width),
				rand.Next(0, game.AquariumSize.Height));
		}
	}
}