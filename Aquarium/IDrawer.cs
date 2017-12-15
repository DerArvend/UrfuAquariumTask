using System.Drawing;
using Aquarium.Fishes;

namespace Aquarium
{
	public interface IDrawer
	{
		 Bitmap GetVisualisation(IGame game);
	}
}