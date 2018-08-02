using System.Collections.Generic;
using System.Collections.ObjectModel;
using MvvmHelpers;
using Xamarin.Forms;

namespace GroupedListViewAlternateRowColor
{
	public partial class MainPage : ContentPage
	{
		public ObservableCollection<Grouping<string, string>> ListItems { get; set; }
			= new ObservableCollection<Grouping<string, string>>();

		public List<string> StarWarsItems { get; set; } = new List<string>
		{
			"R2-D2",
			"3CPO",
			"Luke Skywalker",
			"Darth Vader",
			"Han Solo",
			"Chewbacca",
			"Yoda",
			"Obi-Wan Kenobi"
		};

		public List<string> StarTrekItems { get; set; } = new List<string>
		{
			"Jean-Luc Picard",
			"James T. Kirk",
			"Spock",
			"Data",
			"Catherine Janeway"
		};

		public MainPage()
		{
			InitializeComponent();

			ListItems.Add(new Grouping<string, string>("Star Wars", StarWarsItems));
			ListItems.Add(new Grouping<string, string>("Star Trek", StarTrekItems));

			BindingContext = this;
		}
	}
}