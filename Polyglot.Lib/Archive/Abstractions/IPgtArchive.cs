namespace Polyglot.Lib.Archive.Abstractions;

/// <summary>
/// Interfaccia che descrive il comportamento degli oggetti che si occupaneo della persistenza degli archivi delle traduzioni
/// </summary>
public interface IPgtArchive
{
	/// <summary>
	/// Restituisce il percorso completo dell'archivio
	/// </summary>
	String Path { get; }

	/// <summary>
	/// Controlla l'esistenza di un archivio
	/// </summary>
	/// <returns>True se l'archivio esiste. False in caso contrario</returns>
	Boolean Exists();

	/// <summary>
	/// Restituisce il nome dell'archivio, senza percorso o estensione
	/// </summary>
	/// <returns>Nome dell'archivio</returns>
	String GetName();

	/// <summary>
	/// Restituisce la versione dell'archivio
	/// </summary>
	/// <returns>Versione dell'archivio</returns>
	String GetVersion();

	/// <summary>
	/// Crea un nuovo archivio, inizializzandolo con la struttura e le informazioni di base
	/// </summary>
	void Create();

	/// <summary>
	/// Elimina l'archivio
	/// </summary>
	void Delete();
}
