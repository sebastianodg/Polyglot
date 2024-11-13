using Polyglot.Lib.Model;

namespace Polyglot.Lib.Logic.Abstractions;

/// <summary>
/// Interfaccia che definisce il comportamento degli oggetti che gestiscono le traduzioni
/// </summary>
public interface IPgtTranslationsManager
{
	/// <summary>
	/// Restituisce un riferimento all'oggetto rappresentante l'intero set di traduzioni
	/// </summary>
	public PgtTranslationsSet Translations { get; }

	void InitTranslations();
}
