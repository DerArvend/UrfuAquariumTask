using System.Drawing;
using Aquarium.Fishes;
using Aquarium.Logic;

namespace Aquarium
{
	public interface IDrawer
	{
		 Bitmap GetVisualisation(IAquarium aquarium);
	}
}