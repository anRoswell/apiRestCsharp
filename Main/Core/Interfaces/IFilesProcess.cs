using System.Collections.Generic;
using System.Threading.Tasks;
using Core.ModelProcess;
using Core.QueryFilters;

namespace Core.Interfaces
{
    public interface IFilesProcess
    {
        Task<FileResponse> GetFileCreated(FormDataImagen data);

        Task<List<FileResponse>> GetFilesCreated(FormDataImagen data);
    }
}