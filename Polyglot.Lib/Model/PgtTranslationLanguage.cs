namespace Polyglot.Lib.Model;

/// <summary>
/// Classe rappresentante una lingua contenente tutte le sue traduzioni
/// </summary>
public class PgtTranslationLanguage
{
	/// <summary>
	/// Restituisce o imposta l'identificativo univoco della lingua
	/// </summary>
	public String LanguageId { get; set; }

	/// <summary>
	/// Restituisce un riferimento al dizionario contenente tutti i set di traduzione contenuti nella lingua
	/// </summary>
	public Dictionary<String, PgtTranslationEntriesSet> EntriesGroups { get; private set; }

	/// <summary>
	/// Costruttore con inizializzazione
	/// </summary>
	/// <param name="languageId">Identificativo univoco della lingua</param>
	public PgtTranslationLanguage(String languageId)
	{
		this.LanguageId = languageId;
		this.EntriesGroups = new Dictionary<String, PgtTranslationEntriesSet>();
	}
}