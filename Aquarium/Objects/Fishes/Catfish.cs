using System;
using System.Drawing;
using System.Linq;
using Aquarium.Fishes;
using Aquarium.Geometry;
using Aquarium.Logic;
using Aquarium.Objects.States;
using Aquarium.Settings;

namespace Aquarium.Objects.Fishes
{
	public class Catfish : Fish
	{
		public Catfish(Point startLocation, AquariumSettings aquariumSettings) : base(startLocation, aquariumSettings)
		{
			Size = new Size(aquariumSettings.Catfish.width, aquariumSettings.Catfish.height);
			Hunger = aquariumSettings.Catfish.defaultHunger;
			Direction = startLocation;
			InitializeStateActions();
		}

		private void InitializeStateActions()
		{
			Actions[FishState.Default] = Default;
			Actions[FishState.RunningAway] = Running;
			Actions[FishState.GoToFood] = GoToFood;
		}

		public override void UpdateState(IAquarium aquarium)
		{
			if (Hunger == 0)
				CurrentState = FishState.Dead;
			else if (GetEnemies(aquarium).Any())
				CurrentState = FishState.RunningAway;
			else if (GetFoodNear(aquarium, GetHungerRadius(aquarium, aquarium.Settings.Catfish.hungerRadius)).Any())
				CurrentState = FishState.GoToFood;
			else
				CurrentState = FishState.Default;
		}

		private void Default(IAquarium aquarium)
		{
			if (Location == Direction || Direction.IsNearBorder(aquarium))
				Direction = SelectRandomDirection(aquarium.Size);

			Location = Location.MoveTo(Direction, aquarium.Settings.Catfish.moveSpeed);
		}

		private void Running(IAquarium aquarium)
		{
			var enemies = GetEnemies(aquarium);
			var directionVector = GetRunAwayDirection(enemies) * aquarium.Settings.Catfish.moveSpeed;
			Location = directionVector.ToPoint();
		}

		private void GoToFood(IAquarium aquarium)
		{
			var hungerRadius = GetHungerRadius(aquarium, aquarium.Settings.Catfish.hungerRadius);
			var nearestFood = GetFoodNear(aquarium, hungerRadius)
				.OrderBy(x => x.Location.GetDistanceTo(Location))
				.First();
			if (nearestFood.Location.GetDistanceTo(Location) < aquarium.Settings.Catfish.eatingRadius)
			{
				Hunger += Math.Max(aquarium.Settings.Catfish.hungerGainPerFood, 100);
				nearestFood.Destroy();
			}
			else
			{
				Location = Location.MoveTo(GetFoodNear(aquarium, hungerRadius)
					.OrderBy(x => x.Location.GetDistanceTo(Location))
					.First()
					.Location, aquarium.Settings.Catfish.moveSpeed);
			}
		}
	}
}