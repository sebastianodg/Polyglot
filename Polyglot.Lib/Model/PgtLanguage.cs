namespace Polyglot.Lib.Model;

/// <summary>
/// Classe rappresentante una lingua contenente tutte le sue traduzioni
/// </summary>
public class PgtLanguage
{
	/// <summary>
	/// Restituisce o imposta l'identificativo univoco della lingua
	/// </summary>
	public String LanguageId { get; set; }

	/// <summary>
	/// Restituisce un riferimento al dizionatio contenente tutti i gruppi di traduzione contenuti nella lingua
	/// </summary>
	public List<PgtEntriesGroup> EntriesGroups { get; private set; }

	/// <summary>
	/// Costruttore con inizializzazione
	/// </summary>
	/// <param name="languageId">Identificativo univoco della lingua</param>
	public PgtLanguage(String languageId)
	{
		this.LanguageId = languageId;
		this.EntriesGroups = new List<PgtEntriesGroup>();
	}
}