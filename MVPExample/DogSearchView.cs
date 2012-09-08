using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace MVPExample
{
	public class DogSearchView: Page, IDogSearchView
	{

		protected HtmlInputText SearchField;
		protected IList<Dog> Dogs;
		private DogSearchPresenter presenter;

		protected void Page_Load(object sender, EventArgs e)
		{
			presenter = new DogSearchPresenter(this);
			presenter.PresentAllDogs();
		}


		public void RenderDogs(IList<Dog> dogs)
		{
			Dogs = dogs;
		}

		protected void SearchClick(object sender, EventArgs e)
		{
			presenter.SearchDogs(SearchField.Value);
		}

	}
}