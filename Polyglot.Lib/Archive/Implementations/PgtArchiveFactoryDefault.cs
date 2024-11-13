using Polyglot.Lib.Archive.Abstractions;
using Polyglot.Lib.Archive.Types;

namespace Polyglot.Lib.Archive.Implementations;

/// <summary>
/// Oggetto factory concreto per la creazione dei gestori degli archivi con implementazione di default
/// </summary>
public class PgtArchiveFactoryDefault : IPgtArchiveFactory
{
	public IPgtArchive Get(PgtArchiveType archiveType, String version, String path)
	{
		if (archiveType != PgtArchiveType.SqlLiteDB)
			throw new Exception($"{nameof(PgtArchiveFactoryDefault)}.{nameof(Get)}: Unsupported archive type: {archiveType}.");
		if (String.IsNullOrEmpty(version))
			throw new Exception($"{nameof(PgtArchiveFactoryDefault)}.{nameof(Get)}: Archive version cannot be null or empty.");
		if (String.IsNullOrEmpty(path))
			throw new Exception($"{nameof(PgtArchiveFactoryDefault)}.{nameof(Get)}: Archive path cannot be null or empty.");
		
		// Restituzione del giusto tipo di archivio
		if (archiveType == PgtArchiveType.SqlLiteDB)
			if (version == "1.0")
				return new PgtSqlLiteDBArchive(path);

		throw new Exception($"{nameof(PgtArchiveFactoryDefault)}.{nameof(Get)}: Unhandled archive type: {archiveType} - Version {version}.");
	}
}
