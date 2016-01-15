using System;
using XamMvvmCorssMarvelDemo.Core.Models;
using System.Threading.Tasks;

namespace XamMvvmCorssMarvelDemo.Core.Services
{
	public interface IMarvelApiService
	{
		Task<MarvelApiData<Characters>> GetCharacters (string filter = null, int limit = 0, int offset = 0);
	}
}

