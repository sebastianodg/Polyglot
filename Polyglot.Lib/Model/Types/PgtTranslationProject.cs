namespace Polyglot.Lib.Model.Types;

/// <summary>
/// Classe rappresentante un progetto di traduzione
/// </summary>
public class PgtTranslationProject
{
	/// <summary>
	/// Restituisce o imposta il nome del progetto di traduzioni
	/// </summary>
	public String Name { get; set; }

	/// <summary>
	/// Restituisce o imposta la descrizione associata al progetto di traduzioni
	/// </summary>
	public String Description { get; set; }

	/// <summary>
	/// Restituisce il riferimento al dizionario contenente l'elenco delle lingue contenute nel progetto
	/// </summary>
	public Dictionary<String, PgtTranslationLanguage> Languages { get; private set; }

	/// <summary>
	/// Costruttore
	/// </summary>
	public PgtTranslationProject()
	{
		this.Name = String.Empty;
		this.Description = String.Empty;
		this.Languages = new Dictionary<String, PgtTranslationLanguage>();
	}

	/// <summary>
	/// Costruttore con inizializzazione
	/// </summary>
	/// <param name="name">Nome del progetto di traduzioni</param>
	/// <param name="description">Descrizione associata al progetto di traduzioni</param>
	public PgtTranslationProject(String name, String description)
	{
		if (String.IsNullOrEmpty(name))
			throw new Exception($"{nameof(PgtTranslationProject)}.{nameof(PgtTranslationProject)}: Translation project name cannot be null or empty.");
		if (String.IsNullOrEmpty(description))
			throw new Exception($"{nameof(PgtTranslationProject)}.{nameof(PgtTranslationProject)}: Translation project description cannot be null or empty.");

		this.Name = name;
		this.Description = description;
		this.Languages = new Dictionary<String, PgtTranslationLanguage>();
	}
}
