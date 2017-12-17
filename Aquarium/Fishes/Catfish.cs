using System.Drawing;
using System.Linq;
using Aquarium.Geometry;

namespace Aquarium.Fishes
{
	public class Catfish : Fish
	{
		public Catfish(Point startLocation, IGame game) : base(startLocation)
		{
			Size = new Size(game.Settings.Catfish.width, game.Settings.Catfish.height);
			InitializeStateActions();
		}

		private void InitializeStateActions()
		{
			Actions[FishState.Default] = Default;
			Actions[FishState.RunningAway] = Running;
			Actions[FishState.GoToFood] = GoToFood;
		}

		public override void UpdateState(IGame game)
		{
			if (Hunger == 0)
				CurrentState = FishState.Dead;
			else if (GetEnemies(game).Any())
				CurrentState = FishState.RunningAway;
			else if (GetFoodNear(game, GetHungerRadius(game, game.Settings.Catfish.hungerRadius)).Any())
				CurrentState = FishState.GoToFood;
			else
				CurrentState = FishState.Default;
		}

		private void Default(IGame game)
		{
			if (Location == Direction || Location.IsNearBorder(game))
					Direction = SelectRandomDirection(game);

			Location = Location.MoveTo(Direction, game.Settings.Catfish.moveSpeed);
		}

		private void Running(IGame game)
		{
			var enemies = GetEnemies(game);
			var directionVector = GetRunAwayDirection(enemies) * game.Settings.Catfish.moveSpeed;
			Location = directionVector.ToPoint();
		}

		private void GoToFood(IGame game)
		{
			var hungerRadius = GetHungerRadius(game, game.Settings.Catfish.hungerRadius);
			Location = GetFoodNear(game, hungerRadius)
				.OrderBy(x => x.Location.GetDistanceTo(Location))
				.First()
				.Location;
		}
	}
}