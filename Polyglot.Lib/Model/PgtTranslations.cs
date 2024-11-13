namespace Polyglot.Lib.Model;

/// <summary>
/// Classe rappresentante un set di traduzioni
/// </summary>
internal class PgtTranslations
{
	/// <summary>
	/// Restituisce o imposta la versione del set di traduzioni
	/// </summary>
	public String Version { get; set; }

	/// <summary>
	/// Restituisce il riferimento all'elenco delle lingue tradotte
	/// </summary>
	public List<PgtLanguage> Languages { get; private set; }

	/// <summary>
	/// Costruttore
	/// </summary>
	public PgtTranslations()
	{
		this.Version = String.Empty;
		this.Languages = new List<PgtLanguage>();
	}
}
