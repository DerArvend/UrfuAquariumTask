using System.Data.Common;
using System.Drawing;

namespace Aquarium.Fishes
{
	public interface IGameObject
	{
		Size Size { get; }
		Point Location { get; }
		void Update(IGame game); //returns false if object dies
	}
}