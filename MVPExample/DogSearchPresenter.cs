using System.Collections.Generic;
using System.Linq;

namespace MVPExample
{
	public class DogSearchPresenter
	{
		private readonly IDogSearchView view;
		public DogSearchPresenter(IDogSearchView view)
		{
			this.view = view;
		}

		public void PresentAllDogs()
		{
			view.RenderDogs(Dog.All());
		}

		public void SearchDogs(string value)
		{
			var searchResult = Dog.All().Where(d => d.Name.Contains(value)).ToList();
			view.RenderDogs(searchResult);
		}
	}
}