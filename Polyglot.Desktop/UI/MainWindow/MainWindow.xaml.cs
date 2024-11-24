using Polyglot.Desktop.UI.MainMenu;
using Polyglot.Desktop.UI.Pages;
using System.Windows;
using System.Windows.Controls;

namespace Polyglot.Desktop.UI.MainWindow;

public partial class MainWindow : Window
{
	private MainWindowVM _vm;

	public MainWindow()
	{
		this.InitializeComponent();

		this._vm = new MainWindowVM();
		this.DataContext = this._vm;
	}

	private void MainMenuSelectionChanged(Object sender, SelectionChangedEventArgs e)
	{
		PgtMainMenuItem selectedItem = (PgtMainMenuItem)((ListBox)sender).SelectedItem;

		if (selectedItem.Id == "home")
			this._mainFrame.Content = new HomePage();
		else if (selectedItem.Id == "languages")
			this._mainFrame.Content = new LanguagesPage();
		else if (selectedItem.Id == "translations")
			this._mainFrame.Content = new TranslationsPage();
		else if (selectedItem.Id == "info")
			this._mainFrame.Content = new InfoPage();
		else if (selectedItem.Id == "settings")
			this._mainFrame.Content = new SettingsPage();
		else
			this._mainFrame.Content = null;
	}
}