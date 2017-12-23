using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Aquarium.Logic;
using Aquarium.Settings;
using Newtonsoft.Json;
using Catfish = Aquarium.Objects.Fishes.Catfish;

namespace Aquarium
{
	public class MainForm : Form
	{
		private Logic.Aquarium a;
		private AquariumSettings settings;
		private VisualisatonDrawer drawer;

		public void OnCreate()
		{
			InitAquarium();
			DoubleBuffered = true;
			Size = a.Size;
			InitializeDrawing();
			MouseClick += (sender, args) =>
			{
				var f = new Fishes.FishFood(args.Location, new Size(settings.FishFood.width, settings.FishFood.height));
				a.TryAddObject(f);
			};
		}

		private void InitAquarium()
		{
			settings = JsonConvert.DeserializeObject<AquariumSettings>(
				Encoding.Default.GetString(Properties.Resources.Settings));
			a = new Logic.Aquarium(settings, new Size(1200, 800));
			AddRandomObjects(a);

		}

		private void AddRandomObjects(IAquarium a)
		{
			var rand = new Random();
			for (int i = 0; i < 5; i++)
			{
				a.TryAddObject(new Catfish(
					new Point(rand.Next(0, a.Size.Width - 1), rand.Next(0, a.Size.Height - 1)),
					a.Settings));
			}
		}

		public MainForm()
		{
			OnCreate();

			var timer = new Timer {Interval = 1000 / a.Settings.updateRate};

			timer.Tick += (sender, args) =>
			{
				a.Update();
				Invalidate();
			};
			KeyDown += (sender, args) =>
			{
				if (args.KeyCode == Keys.Add)
				{
					a.Settings.updateRate += 100;
					timer.Interval = 1000 / a.Settings.updateRate;
					timer.Stop();
					timer.Start();
				}
			};
			timer.Start();

		}

		private void InitializeDrawing()
		{
			drawer = new VisualisatonDrawer();
			Paint += (sender, args) =>
			{
				var v = drawer.GetVisualisation(a);
				args.Graphics.DrawImageUnscaled(v, Point.Empty);
			};
		}
	}
}