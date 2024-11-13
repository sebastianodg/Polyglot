using Polyglot.Lib.Model.Types;

namespace Polyglot.Lib.Logic.Abstractions;

/// <summary>
/// Interfaccia che definisce il comportamento degli oggetti che gestiscono i progetti delle traduzioni
/// </summary>
public interface IPgtProjectManager
{
	/// <summary>
	/// Restituisce un riferimento all'oggetto rappresentante l'intero set di traduzioni
	/// </summary>
	public PgtTranslationProject TranslationsProject { get; }

	/// <summary>
	/// Restituisce un dizionario contenente tutte le lingue presenti nel progetto e i loro identificativi corrispondenti
	/// </summary>
	/// <returns>Dizionario contenente tutte le lingue presenti nel progetto e i loro identificativi corrispondenti (ID, Nome)</returns>
	Dictionary<String, String> GetAllLanguages();

	/// <summary>
	/// Inizializza un progetto di traduzioni
	/// </summary>
	/// <param name="projectName">Nome del progetto di traduzione</param>
	/// <param name="projectDescription">Descrizione associata al progetto di traduzione</param>
	void InitTranslationsProject(String projectName, String projectDescription);

	/// <summary>
	/// Controlla la presenza di una lingua all'interno del progetto di traduzione
	/// </summary>
	/// <param name="languageId">Identificativo della lingua</param>
	/// <returns>True se la lingua è presente nel progetto, altrimenti false</returns>
	Boolean LanguageExists(String languageId);

	/// <summary>
	/// Aggiunge una nuova lingua da tradurre
	/// </summary>
	/// <param name="languageId">Identificativo univoco della lingua</param>
	/// <param name="languageName">Nome della lingua</param>
	void AddLanguage(String languageId, String languageName);

	/// <summary>
	/// Rimuove un set di voci di traduzione
	/// </summary>
	/// <param name="languageId">Identificativo univoco della lingua</param>
	void RemoveLanguage(String languageId);

	/// <summary>
	/// Cambia il nome di un set di voci di traduzione
	/// </summary>
	/// <param name="actualLanguageId">Identificativo attuale della lingua da modificare</param>
	/// <param name="newLanguageId">Nuovo identificativo della lingua</param>
	/// <param name="newLanguageName">Nuovo nome della lingua</param>
	void EditLanguage(String actualLanguageId, String newLanguageId, String newLanguageName);

	/// <summary>
	/// Aggiunge un nuovo gruppo di voci di traduzione alle lingue
	/// </summary>
	/// <param name="groupName">Nome del gruppo</param>
	/// <param name="groupDescription">Descrizione del gruppo</param>
	void AddEntriesGroup(String groupName, String groupDescription);

	/// <summary>
	/// Elimina un intero gruppo di traduzioni da tutte le lingue
	/// </summary>
	/// <param name="groupName">Nome del gruppo</param>
	void RemoveEntriesGroup(String groupName);

	/// <summary>
	/// Cambia il nome di un gruppo di traduzioni in tutte le lingue
	/// </summary>
	/// <param name="actualGroupName">Nome attuale del gruppo</param>
	/// <param name="newGroupName">Nuovo nome del gruppo</param>
	void RenameGroup(String actualGroupName, String newGroupName);
}
