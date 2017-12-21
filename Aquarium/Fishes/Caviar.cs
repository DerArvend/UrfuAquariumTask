using System.Data.Common;
using System.Drawing;
using Aquarium.Geometry;
using Aquarium.Settings;

namespace Aquarium.Fishes
{
    class Caviar : IGameObject
    {
        public Size Size { get; private set; }
        public Point Location { get; private set; }
		public bool IsReadyToSpawn { get; private set; }
	    private Point? bottom;
	    private int timaBeforeSpawn;

	    public Caviar(Point Location)
	    {
		    this.Location = Location;
	    }
	    public void Update(IGame game)
	    {
		    if (bottom == null)
			    bottom = new Point(Location.X, game.AquariumSize.Height - Size.Height);
		    if (Location.Y < bottom.Value.Y)
		    {
			    Location = Location.MoveTo(bottom.Value, game.Settings.Caviar.moveSpeed);
		    }
			else if (timaBeforeSpawn < game.Settings.Caviar.spawnDelay)
		    {
			    timaBeforeSpawn++;
		    }
		    else
		    {
			    IsReadyToSpawn = true;
		    }
	    }
    }
}