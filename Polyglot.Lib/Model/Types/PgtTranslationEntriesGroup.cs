namespace Polyglot.Lib.Model.Types;

/// <summary>
/// Classe rappresentante un gruppo di voci di traduzione
/// </summary>
public class PgtTranslationEntriesGroup
{
	/// <summary>
	/// Restituisce o imposta il nome del gruppo di voci di traduzione
	/// </summary>
	public String Name { get; set; }

	/// <summary>
	/// Restituisce o imposta la descrizione del gruppo di voci di traduzione
	/// </summary>
	public String Description { get; set; }

	/// <summary>
	/// Restituisce il riferimento al dizionario contenente l'elenco delle voci di traduzione
	/// </summary>
	public Dictionary<String, PgtTranslationEntry> Entries { get; private set; }

	/// <summary>
	/// Costruttore con inizializzazione
	/// </summary>
	public PgtTranslationEntriesGroup()
	{
		this.Name = String.Empty;
		this.Description = String.Empty;
		this.Entries = new Dictionary<String, PgtTranslationEntry>();
	}

	/// <summary>
	/// Costruttore con inizializzazione
	/// </summary>
	/// <param name="name">Nome del gruppo di voci di traduzione</param>
	/// <param name="description">Descrizione del gruppo di voci di traduzione</param>
	public PgtTranslationEntriesGroup(String name, String description)
	{
		if (String.IsNullOrEmpty(name))
			throw new Exception($"{nameof(PgtTranslationEntriesGroup)}.{nameof(PgtTranslationEntriesGroup)}: Entries group name cannot be null or empty.");

		this.Name = name;
		this.Description = description;
		this.Entries = new Dictionary<String, PgtTranslationEntry>();
	}
}