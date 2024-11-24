using System.Windows;

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
}