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
			if (CurrentState == FishState.Dead)
				throw new InvalidOperationException("Attempt to update dead fish");
			UpdateState(game);
			Actions[CurrentState].Invoke(game);
		}

		protected abstract Point SelectNewDirection(IGame game);
	}
}