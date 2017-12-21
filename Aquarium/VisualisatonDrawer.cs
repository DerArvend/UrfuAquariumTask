using System;
using System.Drawing;
using Aquarium.Fishes;

namespace Aquarium
{
	public class VisualisatonDrawer : IDrawer
	{
		public Bitmap GetVisualisation(IGame game)
		{
            var background = new Bitmap(Properties.Resources.background);
            var g = Graphics.FromImage(background);
            foreach (var obj in game.GetAllObjects())
            {
                if (obj is Catfish fish)
                    DrawCatfish(g, fish, game);
                if (obj is Caviar caviar)
                    DrawCaviar(g, caviar, game);
                if (obj is HunterFish hunterFish)
                    DrawHunterFish(g, hunterFish, game);
            }
            return background;
		}

        private void DrawHunterFish(Graphics g, HunterFish hunterFish, IGame game)
        {
            g.DrawImage(Properties.Resources.Piranha_left,
                hunterFish.Location.X, hunterFish.Location.Y,
                game.Settings.Catfish.width,
                game.Settings.Catfish.height);
        }

        private void DrawCatfish (Graphics g, Catfish catfish, IGame game)
        {
            g.DrawImage(Properties.Resources.Som_left,
                catfish.Location.X, catfish.Location.Y,
                game.Settings.Catfish.width,
                game.Settings.Catfish.height);
        }
        private void DrawCaviar(Graphics g, Caviar caviar, IGame game)
        {
            g.DrawImage(Properties.Resources.Breed,
                caviar.Location.X, caviar.Location.Y,
                game.Settings.Caviar.width,
                game.Settings.Caviar.height);
        }
        private void DrawIndicator(Graphics g, Fish fish, IGame game)
        {
            g.DrawRectangle(new Pen(Color.DarkGray), fish.Location.X + 10, fish.Location.Y + 10, 40, 50);
            g.DrawRectangle(new Pen(Color.DarkGreen), (fish.Location.X + 10)*fish.Hunger, (fish.Location.Y + 10)*fish.Hunger, 30, 40);
        }
    }
}