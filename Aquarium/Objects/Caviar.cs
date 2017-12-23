using System;
using System.Collections.Generic;
using System.Drawing;
using Aquarium.Geometry;
using Aquarium.Logic;
using Aquarium.Objects.States;
using Aquarium.Settings;

namespace Aquarium.Fishes
{
	public class Caviar<T> : IAquariumObject
		where T : Fish
	{
		public Size Size { get; }
		public Point Location { get; private set; }
		public bool ShouldBeDestroyed => false;
		public CaviarState CurrentState { get; private set; }
		private int idleTimeInTicks;
		private Dictionary<CaviarState, Action<IAquarium>> actions;
		public Type FishType => typeof(T);

		public Caviar(Point location, AquariumSettings s)
		{
			Location = location;
			Size = new Size(s.Caviar.width, s.Caviar.height);
			CurrentState = CaviarState.Fall;
			InitActions();
		}

		private void InitActions()
		{
			actions = new Dictionary<CaviarState, Action<IAquarium>>();
			actions[CaviarState.Fall] = a =>
			{
				Location = Location.MoveTo(
					new Point(Location.X, a.Size.Height - 1 - Size.Height),
					a.Settings.Caviar.moveSpeed);
			};
			actions[CaviarState.Grow] = a => idleTimeInTicks++;
			actions[CaviarState.ReadyToSpawn] = a => { };
		}

		public void Update(IAquarium aquarium)
		{
			UpdateState(aquarium);
			actions[CurrentState].Invoke(aquarium);
		}

		private void UpdateState(IAquarium aquarium)
		{
			if (CurrentState == CaviarState.Fall && Location.Y == aquarium.Size.Height - 1 - Size.Height)
				CurrentState = CaviarState.Grow;
			if (CurrentState == CaviarState.Grow && idleTimeInTicks >= aquarium.Settings.Caviar.spawnDelay)
				CurrentState = CaviarState.ReadyToSpawn;
		}
	}
}