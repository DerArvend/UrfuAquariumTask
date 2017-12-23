using System;
using System.Drawing;
using Aquarium.Fishes;
using Aquarium.Logic;
using Aquarium.Objects.Fishes;

namespace Aquarium
{
	public class VisualisatonDrawer : IDrawer
	{
		public Bitmap GetVisualisation(IAquarium aquarium)
		{
            var background = new Bitmap(Properties.Resources.background, aquarium.Size.Width, aquarium.Size.Height);
            var g = Graphics.FromImage(background);
            foreach (var obj in aquarium.AllObjects)
            {
                if (obj is Catfish fish)
                    DrawCatfish(g, fish, aquarium);
                else if (obj is Caviar<Fish> caviar)
                    DrawCaviar(g, caviar, aquarium);
                else if (obj is HunterFish hunterFish)
                    DrawHunterFish(g, hunterFish, aquarium);
	            else if (obj is FishFood food)
		            DrawFishFood(g, food, aquarium);
            }
            return background;
		}

		private void DrawFishFood(Graphics g, FishFood food, IAquarium aquarium)
		{
			g.DrawImage(Properties.Resources.food,
				food.Location.X, food.Location.Y,
				aquarium.Settings.FishFood.width,
				aquarium.Settings.FishFood.height);
		}

		private void DrawHunterFish(Graphics g, HunterFish hunterFish, IAquarium aquarium)
        {
            g.DrawImage(Properties.Resources.Piranha_left,
                hunterFish.Location.X, hunterFish.Location.Y,
                aquarium.Settings.Catfish.width,
                aquarium.Settings.Catfish.height);
        }

        private void DrawCatfish (Graphics g, Catfish catfish, IAquarium aquarium)
        {
            g.DrawImage(Properties.Resources.Som_left,
                catfish.Location.X, catfish.Location.Y,
                aquarium.Settings.Catfish.width,
                aquarium.Settings.Catfish.height);
        }
        private void DrawCaviar(Graphics g, Caviar<Fish> caviar, IAquarium aquarium)
        {
            g.DrawImage(Properties.Resources.Breed,
                caviar.Location.X, caviar.Location.Y,
                aquarium.Settings.Caviar.width,
                aquarium.Settings.Caviar.height);
        }
        private void DrawIndicator(Graphics g, Fish fish, IAquarium aquarium)
        {
            g.DrawRectangle(new Pen(Color.DarkGray), fish.Location.X + 10, fish.Location.Y + 10, 40, 50);
            g.DrawRectangle(new Pen(Color.DarkGreen), (fish.Location.X + 10)*fish.Hunger, (fish.Location.Y + 10)*fish.Hunger, 30, 40);
        }
    }
}