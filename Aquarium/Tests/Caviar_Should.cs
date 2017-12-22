using System.Drawing;
using Aquarium.Fishes;
using NUnit.Framework;
using FluentAssertions;
using FakeItEasy;
using Newtonsoft.Json;

namespace Aquarium.Tests
{
	[TestFixture]
	public class Caviar_Should
	{
		private IGame game;

		[SetUp]
		public void SetUp()
		{
			game = FakeGame.Get();
			game.Settings.Caviar.height = 1;
			game.Settings.Caviar.spawnDelay = 2;
		}

		[Test]
		public void ShouldFall_IfUpper()
		{
			var c = new Caviar(new Point(0, 0));
			c.Update(game);
			var a = c.Location;
			{ }
		}
	}
}
