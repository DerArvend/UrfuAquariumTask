using System.Drawing;

namespace Aquarium.Fishes
{
	public interface IGameObject
	{
		Size GetSize();
		Point GetLocation();
		bool Update(IGame game); //returns false if object dies
	}
}