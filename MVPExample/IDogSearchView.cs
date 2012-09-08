using System.Collections.Generic;

namespace MVPExample
{
	public interface IDogSearchView
	{
		void RenderDogs(IList<Dog> dogs);
	}
}