using Polyglot.Lib.Logic.Abstractions;
using Polyglot.Lib.Model.Types;

namespace Polyglot.Lib.Model.Logic.Implementations;

internal class PgtDefaultProjectManager : IPgtProjectManager
{
	private PgtTranslationProject _translationsProject;

	public PgtTranslationProject TranslationsProject {  get { return _translationsProject; } }

	/// <summary>
	/// Costruttore con inizializzazione
	/// </summary>
	/// <param name="translationsProject">Oggetto rappresentante il progetto contenente le traduzioni</param>
	public PgtDefaultProjectManager(PgtTranslationProject translationsProject)
	{
		if (translationsProject == null)
			throw new Exception($"{nameof(PgtDefaultProjectManager)}.{nameof(PgtDefaultProjectManager)}: Reference to {nameof(PgtTranslationProject)} cannot be null.");

		this._translationsProject = translationsProject;
	}

	public Dictionary<String, String> GetAllLanguages()
	{
		Dictionary<String, String> languages = new Dictionary<String, String>();
		foreach (String translationLanguageId in this._translationsProject.Languages.Keys)
			languages.Add(translationLanguageId, this._translationsProject.Languages[translationLanguageId].Name);

		return languages;
	}

	public void InitTranslationsProject(String projectName, String projectDescription)
	{
		if (String.IsNullOrEmpty(projectName))
			throw new Exception($"{nameof(PgtDefaultProjectManager)}.{nameof(InitTranslationsProject)}: Translation project name cannot be null or empty.");
		if (String.IsNullOrEmpty(projectDescription))
			throw new Exception($"{nameof(PgtDefaultProjectManager)}.{nameof(InitTranslationsProject)}: Translation project description cannot be null or empty.");

		// Reset di tutte le lingue presenti
		this._translationsProject.Languages.Clear();

		// Impostazione del nome e della descrizione del progetto
		this._translationsProject.Name = projectName;
		this._translationsProject.Description = projectDescription;

		// Aggiunta delle lingue di default
		this._translationsProject.Languages.Add("de-DE", new PgtTranslationLanguage("de-DE", "Deutsch"));
		this._translationsProject.Languages.Add("en-GB", new PgtTranslationLanguage("en-GB", "English (United Kingdom)"));
		this._translationsProject.Languages.Add("en-US", new PgtTranslationLanguage("en-US", "English (United States)"));
		this._translationsProject.Languages.Add("es-ES", new PgtTranslationLanguage("es-ES", "Español"));
		this._translationsProject.Languages.Add("fr-FR", new PgtTranslationLanguage("fr-FR", "Français"));
		this._translationsProject.Languages.Add("it-IT", new PgtTranslationLanguage("it-IT", "Italiano"));
		this._translationsProject.Languages.Add("ru-RU", new PgtTranslationLanguage("ru-RU", "Русский"));
		this._translationsProject.Languages.Add("zh-CN", new PgtTranslationLanguage("zh-CN", "中国人"));

		// Aggiunta del set di voci di traduzione di default per ogni lingua
		foreach (String languageId in this._translationsProject.Languages.Keys)
		{
			PgtTranslationEntriesGroup newEntriesGroup = new PgtTranslationEntriesGroup("Group 1", "Simple group description");
			this._translationsProject.Languages[languageId].EntriesGroups.Add(newEntriesGroup.Name, newEntriesGroup);
		}
	}

	public Boolean LanguageExists(String languageId)
	{
		if (String.IsNullOrEmpty(languageId))
			throw new Exception($"{nameof(PgtDefaultProjectManager)}.{nameof(LanguageExists)}: Language ID cannot be null or empty.");

		return this._translationsProject.Languages.ContainsKey(languageId);
	}

	public void AddLanguage(String languageId, String languageName)
	{
		if (String.IsNullOrEmpty(languageId))
			throw new Exception($"{nameof(PgtDefaultProjectManager)}.{nameof(AddLanguage)}: Language ID cannot be null or empty.");
		if (String.IsNullOrEmpty(languageName))
			throw new Exception($"{nameof(PgtDefaultProjectManager)}.{nameof(AddLanguage)}: Language name cannot be null or empty.");

		// Creazione della nuova lingua
		PgtTranslationLanguage newLanguage = new PgtTranslationLanguage(languageId, languageName);

		// La nuova lingua deve avere tutti i gruppi e tutte le voci di traduzione delle altre lingue
		PgtTranslationLanguage firstLanguage = this._translationsProject.Languages.Values.First();
		foreach (PgtTranslationEntriesGroup entriesGroup in firstLanguage.EntriesGroups.Values)
		{
			// Creazione del nuovo gruppo
			PgtTranslationEntriesGroup newEntriesGroup = new PgtTranslationEntriesGroup(entriesGroup.Name, entriesGroup.Description);

			// Aggiunta di tutte le voci di traduzione al gruppo
			foreach (PgtTranslationEntry translationEntry in entriesGroup.Entries.Values)
			{
				PgtTranslationEntry newEntry = new PgtTranslationEntry(translationEntry.Id, "", false);
				newEntriesGroup.Entries.Add(newEntry.Id, newEntry);
			}

			// Aggiunta del nuovo gruppo alla lingua
			newLanguage.EntriesGroups.Add(newEntriesGroup.Name, newEntriesGroup);
		}

		// Aggiunta della nuova lingua al progetto
		this._translationsProject.Languages.Add(newLanguage.Id, newLanguage);
	}

	public void RemoveLanguage(String languageId)
	{
		if (String.IsNullOrEmpty(languageId))
			throw new Exception($"{nameof(PgtDefaultProjectManager)}.{nameof(RemoveLanguage)}: Language ID cannot be null or empty.");
		if (!this._translationsProject.Languages.ContainsKey(languageId))
			throw new Exception($"{nameof(PgtDefaultProjectManager)}.{nameof(RemoveLanguage)}: Language \"{languageId}\" was not found in project.");

		this._translationsProject.Languages.Remove(languageId);
	}

	public void EditLanguage(String actualLanguageId, String newLanguageId, String newLanguageName)
	{
		if (String.IsNullOrEmpty(actualLanguageId))
			throw new Exception($"{nameof(PgtDefaultProjectManager)}.{nameof(EditLanguage)}: Actual language ID cannot be null or empty.");
		if (!this._translationsProject.Languages.ContainsKey(actualLanguageId))
			throw new Exception($"{nameof(PgtDefaultProjectManager)}.{nameof(EditLanguage)}: Language \"{actualLanguageId}\" was not found in project.");
		if (String.IsNullOrEmpty(newLanguageId))
			throw new Exception($"{nameof(PgtDefaultProjectManager)}.{nameof(EditLanguage)}: New language ID cannot be null or empty.");
		if (String.IsNullOrEmpty(newLanguageName))
			throw new Exception($"{nameof(PgtDefaultProjectManager)}.{nameof(EditLanguage)}: New language name cannot be null or empty.");

		PgtTranslationLanguage actualLanguage = this._translationsProject.Languages[actualLanguageId];
		actualLanguage.Id = newLanguageId;
		actualLanguage.Name = newLanguageName;
	}

	public Boolean EntriesGroupExists(String entriesGroupId)
	{
		if (String.IsNullOrEmpty(entriesGroupId))
			throw new Exception($"{nameof(PgtDefaultProjectManager)}.{nameof(EntriesGroupExists)}: Entries group ID cannot be null or empty.");

		return this._translationsProject.Languages.Values.First().EntriesGroups.ContainsKey(entriesGroupId);
	}

	public void AddEntriesGroup(String groupName, String groupDescription)
	{
		throw new NotImplementedException();
	}

	public void RemoveEntriesGroup(String groupName)
	{
		throw new NotImplementedException();
	}

	public void RenameGroup(String actualGroupName, String newGroupName)
	{
		throw new NotImplementedException();
	}
}
