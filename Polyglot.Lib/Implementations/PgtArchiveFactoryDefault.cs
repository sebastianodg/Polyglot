﻿using Polyglot.Lib.Abstractions;
using Polyglot.Lib.Types;

namespace Polyglot.Lib.Implementations;

/// <summary>
/// Oggetto factory concreto per la creazione dei gestori degli archivi con implementazione di default
/// </summary>
internal class PgtArchiveFactoryDefault : IPgtArchiveFactory
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