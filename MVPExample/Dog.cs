using System.Collections.Generic;

namespace MVPExample
{
	public class Dog
	{
		public string Name { get; set; }
		public string Race { get; set; }

		public static IList<Dog> All()
		{
			return new List<Dog>
				{
					new Dog { Name = "Muffin", Race = "French Bulldog"},
					new Dog { Name = "Olaf", Race = "Labrador"},
					new Dog { Name = "Terry", Race = "Terrier"},
					new Dog { Name = "Fido", Race = "Golden Retriever"}					
				};
		}
	}
}