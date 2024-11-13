using Polyglot.Lib.Model.Types;

namespace Polyglot.Lib.Logic.Abstractions;

/// <summary>
/// Interfaccia che definisce il comportamento degli oggetti che gestiscono le traduzioni
/// </summary>
public interface IPgtTranslationsManager
{
	/// <summary>
	/// Restituisce un riferimento all'oggetto rappresentante l'intero set di traduzioni
	/// </summary>
	public PgtTranslationProject TranslationsSet { get; }

	/// <summary>
	/// Inizializza un set di traduzioni
	/// </summary>
	void InitTranslationsSet();

	/// <summary>
	/// Aggiunge un nuovo set di voci di traduzione
	/// </summary>
	/// <param name="name">Nome del set di voci di traduzione</param>
	void AddTranslationsEntriesSet(String name);

	/// <summary>
	/// Rimuove un set di voci di traduzione
	/// </summary>
	/// <param name="name">Nome del set di voci di traduzione</param>
	void RemoveTranslationsEntriesSet(String name);

	/// <summary>
	/// Cambia il nome di un set di voci di traduzione
	/// </summary>
	/// <param name="actualName">Nome attuale del set di voci di traduzione</param>
	/// <param name="newName">Nuovo nome del set di voci di traduzione</param>
	void RenameTranslationsEntriesSet(String actualName, String newName);
}
