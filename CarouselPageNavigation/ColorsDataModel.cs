using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Majestasaurus.Portable
{
	public class ColorsDataModel
	{
		public string Name { get; set; }

		public Color Color { get; set; }

		public static IList<ColorsDataModel> All { get; set; }

		static ColorsDataModel ()
		{
			All = new ObservableCollection<ColorsDataModel> {
				new ColorsDataModel {
					Name = "Titania the Tyrannosaurus wanted to be queen of the forest.",
					Color = Color.Blue
				},
				new ColorsDataModel {
					Name = "One day she met a handsome man tyrannosarus.",
					Color = Color.Green
				},
				new ColorsDataModel {
					Name = "She killed him and ate him.",
					Color = Color.Red
				}
			};
		}
	}
}
