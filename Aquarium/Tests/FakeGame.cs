using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aquarium.Fishes;
using Aquarium.Settings;
using FakeItEasy;
using Newtonsoft.Json;

namespace Aquarium.Tests
{
	public static class FakeGame
	{
		public static IGame Get()
		{
			var g = A.Fake<IGame>();
			var settings = JsonConvert.DeserializeObject<GameSettings>(
				Encoding.Default.GetString(Properties.Resources.Settings));
			A.CallTo(() => g.Settings)
				.Returns(settings);
			A.CallTo(() => g.AquariumSize).Returns(new Size(10, 10));
			return g;
		}
	}
}