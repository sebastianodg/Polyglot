using Polyglot.Lib.Types;

namespace Polyglot.Lib.Archive.Abstractions;

/// <summary>
/// Interfaccai che definisce il comportamento degli oggetti factory per la creazione degli archivi delle traduzioni
/// </summary>
public interface IPgtArchiveFactory
{
	/// <summary>
	/// Restituisce l'oggetto concreato per la gestione dell'archivio delle traduzioni
	/// </summary>
	/// <param name="archiveType">Tipo di archivio</param>
	/// <param name="version">Versione dell'archivio</param>
	/// <param name="path">Percorso completo del file contenente l'archivio</param>
	/// <returns>Oggetto concreto per la gestione dell'archivio delle traduzioni</returns>
	IPgtArchive Get(PgtArchiveType archiveType, String version, String path);
}
