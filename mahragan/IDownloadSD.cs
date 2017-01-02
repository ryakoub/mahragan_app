using System;
namespace mahragan.DependencyService
{
	public interface IDownloadSD
	{
		void Save(string name, byte[] bytes, out string fullPathToSavedFile);
	}
}
