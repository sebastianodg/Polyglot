namespace Polyglot.Lib.Model.Types;

/// <summary>
/// Classe rappresentante una voce di traduzione
/// </summary>
public class PgtTranslationEntry
{
	/// <summary>
	/// Restituisce o imposta l'identificativo univoco della voce di traduzione
	/// </summary>
	public String Id { get; set; }

	/// <summary>
	/// Restituisce o imposta il testo tradotto
	/// </summary>
	public String Text { get; set; }

	/// <summary>
	/// Restituisce o imposta il flag che indica se la voce di traduzione è completa (true) o va terminata (false)
	/// </summary>
	public Boolean Completed { get; set; }

	/// <summary>
	/// Costruttore
	/// </summary>
	public PgtTranslationEntry()
	{
		this.Id = String.Empty;
		this.Text = String.Empty;
		this.Completed = false;
	}

	/// <summary>
	/// Costruttore con inizializzazione
	/// </summary>
	/// <param name="id">Identificativo univoco della voce di traduzione</param>
	/// <param name="text">Testo tradotto</param>
	/// <param name="completed">Flag che indica se la voce di traduzione è completa (true) o va terminata (false)</param>
	public PgtTranslationEntry(String id, String text, Boolean completed)
	{
		if (String.IsNullOrEmpty(id))
			throw new Exception($"{nameof(PgtTranslationEntry)}.{nameof(PgtTranslationEntry)}: Translation entry ID cannot be null or empty.");

		this.Id = id;
		this.Text = text;
		this.Completed = completed;
	}
}