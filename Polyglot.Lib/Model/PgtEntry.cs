namespace Polyglot.Lib.Model;

/// <summary>
/// Classe rappresentante una voce di traduzione
/// </summary>
public class PgtEntry
{
	/// <summary>
	/// Restituisce o imposta l'identificativo univoco della voce tradotta
	/// </summary>
	public String EntryId { get; set; }

	/// <summary>
	/// Restituisce o imposta il testo tradotto
	/// </summary>
	public String Text { get; set; }

	/// <summary>
	/// Restituisce o imposta il flag che indica se la traduzione è completa (true) o va terminata (false)
	/// </summary>
	public Boolean Completed { get; set; }

	/// <summary>
	/// Costruttore
	/// </summary>
	public PgtEntry()
	{
		this.EntryId = String.Empty;
		this.Text = String.Empty;
		this.Completed = false;
	}
}