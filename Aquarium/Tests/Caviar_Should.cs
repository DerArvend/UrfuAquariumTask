using System.Drawing;
using System.Text;
using Aquarium.Fishes;
using Aquarium.Logic;
using Aquarium.Objects.States;
using Aquarium.Settings;
using NUnit.Framework;
using FluentAssertions;
using FakeItEasy;
using Newtonsoft.Json;

namespace Aquarium.Tests
{
	[TestFixture]
	public class Caviar_Should
	{

		[Test]
		public void ShouldFall_IfUpper()
		{
			var settings = JsonConvert.DeserializeObject<Settings.AquariumSettings>(
				Encoding.Default.GetString(Properties.Resources.Settings));
			settings.Caviar.spawnDelay = 3;
			
			var a = new Logic.Aquarium(settings, new Size(50, 50));
			var c = new Caviar<Fish>(new Point(5, 10), a.Settings);
			a.TryAddObject(c);
			{}
			while (c.CurrentState == CaviarState.Fall)
			{
				a.Update();
			}
			{ }
			a.Update();
			if(c.CurrentState == CaviarState.ReadyToSpawn) { }
			a.Update();
			if (c.CurrentState == CaviarState.ReadyToSpawn) { }

			a.Update();
			if (c.CurrentState == CaviarState.ReadyToSpawn) { }

			{ }
		}
	}
}