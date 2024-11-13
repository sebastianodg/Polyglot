using Polyglot.Lib.Archive.Abstractions;

namespace Polyglot.Lib.Archive.Implementations;

/// <summary>
/// Oggetto che si occupa della gestione degli archivi di traduzione memorizzati in un DB SqlLite
/// </summary>
public class PgtSqlLiteDBArchive : IPgtArchive
{
	private String _path;

	public String Path { get { return this._path; } }

	/// <summary>
	/// Costruttore
	/// </summary>
	/// <param name="path">Percorso completo dell'archivio</param>
	public PgtSqlLiteDBArchive(String path)
	{
		if (String.IsNullOrEmpty(path))
			throw new Exception($"{nameof(PgtSqlLiteDBArchive)}.{nameof(PgtSqlLiteDBArchive)}: Archive path cannot be null or empty.");
		
		this._path = path;
	}

	public Boolean Exists()
	{
		return File.Exists(this._path);
	}

	public String GetName()
	{
		FileInfo fileInfo = new FileInfo(this._path);
		return fileInfo.Name;
	}

	public String GetVersion()
	{
		return String.Empty;
	}

	public void Create()
	{
	}

	public void Delete()
	{
	}
}
