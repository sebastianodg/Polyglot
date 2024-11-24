using CommunityToolkit.Mvvm.ComponentModel;
using Polyglot.Desktop.UI.MainMenu;
using System.Collections.ObjectModel;

namespace Polyglot.Desktop.UI.MainWindow;

public partial class MainWindowVM : ObservableObject
{
	/// <summary>
	/// Restituisce o imposta l'elenco delle voci che costituiscono il menù principale
	/// </summary>
	public ObservableCollection<PgtMainMenuItem> MainMenuItems { get; set; }

	/// <summary>
	/// Costruttore
	/// </summary>
	public MainWindowVM()
	{
		// Creazione dell'elenco delle voci che costituiscono il menù principale
		this.MainMenuItems = new ObservableCollection<PgtMainMenuItem>()
		{
			new PgtMainMenuItem("\uE80F", "Home"),
			new PgtMainMenuItem("\uF2B7", "Languages"),
			new PgtMainMenuItem("\uE8F2", "Translations"),
		};
	}
}
