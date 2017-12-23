using System.Drawing;
using Aquarium.Logic;

namespace Aquarium.Fishes
{
	public interface IAquariumObject
	{
		Size Size { get; }
		Point Location { get; }
		bool ShouldBeDestroyed { get; }
		void Update(IAquarium aquarium); 
	}
}