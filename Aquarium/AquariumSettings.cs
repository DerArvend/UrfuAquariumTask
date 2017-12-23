//all speed values in pixels per timeframe
//alltime values in timeframes

// ReSharper disable All
namespace Aquarium.Settings
{
	public class AquariumSettings
	{
		public int updateRate { get; set; }
		public double foodSpawnChance { get; set; }
		public int maxHungerRadiusCoefficent { get; set; }
		public Caviar Caviar { get; set; }
		public Shark Shark { get; set; }
		public Neon Neon { get; set; }
		public Piranha Piranha { get; set; }
		public Catfish Catfish { get; set; }
		public FishKing FishKing { get; set; }
		public FishFood FishFood { get; set; }
	}

	public class Caviar
	{
		public int width { get; set; }
		public int height { get; set; }
		public int moveSpeed { get; set; }
		public int spawnDelay { get; set; }
	}

	public class Shark
	{
		public int width { get; set; }
		public int height { get; set; }
		public int fastMoveSpeed { get; set; }
		public int moveSpeed { get; set; }
		public int hungerRadius { get; set; }
	}

	public class Neon
	{
		public int width { get; set; }
		public int height { get; set; }
		public int moveSpeed { get; set; }
		public int hungerRadius { get; set; }
	}

	public class Piranha
	{
		public int width { get; set; }
		public int height { get; set; }
		public int moveSpeed { get; set; }
		public int hungerRadius { get; set; }
	}

	public class Catfish
	{
		public int width { get; set; }
		public int height { get; set; }
		public int moveSpeed { get; set; }
		public int hungerRadius { get; set; }
		public int eatingRadius { get; set; }
		public int defaultHunger { get; set; }
		public int hungerGainPerFood { get; set; }
	}

	public class DefendedAreaCenter
	{
		public int x { get; set; }
		public int y { get; set; }
	}

	public class FishKing
	{
		public int moveSpeed { get; set; }
		public int radius { get; set; }
		public DefendedAreaCenter defendedAreaCenter { get; set; }
	}
	public class FishFood
	{
		public int width { get; set; }
		public int height { get; set; }
	}
}