namespace Polyglot.Lib.Model.Types;

/// <summary>
/// Classe rappresentante un set di voci di traduzione
/// </summary>
public class PgtTranslationEntriesSet
{
	/// <summary>
	/// Restituisce o imposta il nome del set di voci di traduzione
	/// </summary>
	public String Name { get; set; }

	/// <summary>
	/// Restituisce o imposta la descrizione del set di voci di traduzione
	/// </summary>
	public String Description { get; set; }

	/// <summary>
	/// Restituisce il riferimento al dizionario contenente l'elenco delle voci di traduzione
	/// </summary>
	public Dictionary<String, PgtTranslationEntry> Entries { get; private set; }

	/// <summary>
	/// Costruttore con inizializzazione
	/// </summary>
	public PgtTranslationEntriesSet()
	{
		this.Name = String.Empty;
		this.Description = String.Empty;
		this.Entries = new Dictionary<String, PgtTranslationEntry>();
	}
}