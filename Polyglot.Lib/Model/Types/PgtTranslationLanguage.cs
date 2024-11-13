namespace Polyglot.Lib.Model.Types;

/// <summary>
/// Classe rappresentante una lingua contenente tutte le sue traduzioni
/// </summary>
public class PgtTranslationLanguage
{
	/// <summary>
	/// Restituisce o imposta l'identificativo univoco della lingua
	/// </summary>
	public String Id { get; set; }

	/// <summary>
	/// Restituisce o imposta il nome della lingua
	/// </summary>
	public String Name { get; set; }

	/// <summary>
	/// Restituisce un riferimento al dizionario contenente tutti i gruppi di traduzione contenuti nella lingua
	/// </summary>
	public Dictionary<String, PgtTranslationEntriesGroup> EntriesGroups { get; private set; }

	/// <summary>
	/// Costruttore
	/// </summary>
	public PgtTranslationLanguage()
	{
		this.Id = String.Empty;
		this.Name = String.Empty;
		this.EntriesGroups = new Dictionary<String, PgtTranslationEntriesGroup>();
	}

	/// <summary>
	/// Costruttore con inizializzazione
	/// </summary>
	/// <param name="id">Identificativo univoco della lingua</param>
	/// <param name="name">Nome della lingua</param>
	public PgtTranslationLanguage(String id, String name)
	{
		if (String.IsNullOrEmpty(id))
			throw new Exception($"{nameof(PgtTranslationLanguage)}.{nameof(PgtTranslationLanguage)}: Language ID cannot be null or empty.");
		if (String.IsNullOrEmpty(name))
			throw new Exception($"{nameof(PgtTranslationLanguage)}.{nameof(PgtTranslationLanguage)}: Language name cannot be null or empty.");

		this.Id = id;
		this.Name = name;
		this.EntriesGroups = new Dictionary<String, PgtTranslationEntriesGroup>();
	}
}