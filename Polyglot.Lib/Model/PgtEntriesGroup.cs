namespace Polyglot.Lib.Model;

/// <summary>
/// Classe rappresentante un gruppo di voci di traduzione
/// </summary>
public class PgtEntriesGroup
{
	/// <summary>
	/// Restituisce o imposta l'identificativo univoco del gruppo di voci di traduzione
	/// </summary>
	public String GroupId { get; set; }

	/// <summary>
	/// Restituisce il riferimento al dizionario contenente l'elenco delle voci di traduzione
	/// </summary>
	public Dictionary<String, PgtEntry> Entries { get; private set; }

	/// <summary>
	/// Costruttore con inizializzazione
	/// </summary>
	/// <param name="name">Nome del gruppo di voci di traduzione</param>
	public PgtEntriesGroup(String name)
	{
		this.GroupId = name;
		this.Entries = new Dictionary<String, PgtEntry>();
	}
}