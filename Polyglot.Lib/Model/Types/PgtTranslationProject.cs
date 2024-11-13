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
	/// Restituisce il riferimento all'elenco delle lingue tradotte
	/// </summary>
	public List<PgtTranslationLanguage> Languages { get; private set; }

	/// <summary>
	/// Costruttore
	/// </summary>
	public PgtTranslationProject()
	{
		this.Name = String.Empty;
		this.Description = String.Empty;
		this.Languages = new List<PgtTranslationLanguage>();
	}
}
