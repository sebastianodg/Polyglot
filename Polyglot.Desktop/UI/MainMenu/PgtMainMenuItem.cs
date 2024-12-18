﻿using CommunityToolkit.Mvvm.ComponentModel;

namespace Polyglot.Desktop.UI.MainMenu;

/// <summary>
/// Classe rappresentante una voce del menù principale dell'applicazione
/// </summary>
public partial class PgtMainMenuItem : ObservableObject
{
	[ObservableProperty]
	private String _id;

	[ObservableProperty]
	private String _icon;

	[ObservableProperty]
	private String _text;

	/// <summary>
	/// Costruttore
	/// </summary>
	public PgtMainMenuItem()
	{
		this._id = String.Empty;
		this._icon = String.Empty;
		this._text = String.Empty;
	}

	/// <summary>
	/// Costruttore con inizializzazione
	/// </summary>
	/// <param name="id">Identificativo univoco della voce di men§</param>
	/// <param name="icon">Testo che identifica l'icona associata alla voce di menù</param>
	/// <param name="text">Testo da visualizzare per la voce di menù</param>
	public PgtMainMenuItem(String id, String icon, String text)
	{
		if (String.IsNullOrEmpty(id))
			throw new Exception($"{nameof(PgtMainMenuItem)}.{nameof(PgtMainMenuItem)}: Id string cannot be null or empty.");
		if (String.IsNullOrEmpty(icon))
			throw new Exception($"{nameof(PgtMainMenuItem)}.{nameof(PgtMainMenuItem)}: Icon string cannot be null or empty.");
		if (String.IsNullOrEmpty(text))
			throw new Exception($"{nameof(PgtMainMenuItem)}.{nameof(PgtMainMenuItem)}: Text string cannot be null or empty.");

		this._id = id;
		this._icon = icon;
		this._text = text;
	}
}
