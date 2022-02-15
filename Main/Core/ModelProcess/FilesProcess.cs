using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Core.Entities;
using Core.Exceptions;
using Core.Interfaces;
using Core.QueryFilters;
using ImageMagick;
using Microsoft.AspNetCore.Http;

namespace Core.ModelProcess
{
    public class FilesProcess : IFilesProcess
    {
        private readonly IUnitOfWork _unitOfWork;

        public FilesProcess(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<FileResponse> GetFileCreated(FormDataImagen data)
        {
            try
            {
                // Obtenemos Path de File Server (Red)
                AppsFileServerPath rootFileServer = await _unitOfWork.AppsFileServerPathRepository.GetById(data.IdPathFileServer);

                string PathRedRelative = Path.Combine(rootFileServer.PathRedArchivo, data.Carpeta);
                string PathRedReal = Path.Combine(rootFileServer.PathRed, PathRedRelative);
                string NombreArchivo = string.Empty;
                string PathRedCompleto = string.Empty;
                FileResponse fileData = null;
                FileInfo fileInfo = null;

                // Si no existe la ruta del 'Pathreal' se crea.
                if (!Directory.Exists(PathRedReal))
                {
                    Directory.CreateDirectory(PathRedReal); //Creamos Carpetas
                }

                // Obtenemos información más relevante del adjunto.
                string fileExt = Path.GetExtension(data.Files[0].FileName);
                string NombreUnico = Tools.Funciones.GetCodigoUnico("a");
                NombreArchivo = string.Concat(NombreUnico, fileExt);

                if (data.Files[0].Length > 0)
                {
                    if (fileExt.Contains(".heic"))
                    {
                        Stream streamImagen = data.Files[0].OpenReadStream();
                        using (var image = new MagickImage(streamImagen))
                        {
                            // Save frame as jpg
                            NombreArchivo = NombreArchivo.Replace(".heic", ".jpg");
                            PathRedCompleto = Path.Combine(PathRedReal, NombreArchivo);
                            image.Write(PathRedCompleto);
                        }
                    }
                    else
                    {
                        PathRedCompleto = Path.Combine(PathRedReal, NombreArchivo);
                        using (var stream = File.Create(PathRedCompleto))
                        {
                            await data.Files[0].CopyToAsync(stream);
                        }
                    }
                }
                else
                {
                    throw new BusinessException("El archivo no contiene un tamaño específico.");
                }

                if (!File.Exists(PathRedCompleto))
                {
                    throw new BusinessException("Se presentó un error al crear archivo");
                }

                fileInfo = new FileInfo(PathRedCompleto);

                // Consultamos el Path de las imágenes (Web)
                string rootWeb = rootFileServer.PathWeb;
                string relativeWebPath = rootFileServer.PathWebArchivo;
                string PathWebRelativo = string.Concat(relativeWebPath, data.Carpeta, "/", NombreArchivo);
                string PathWebCompleto = string.Concat(rootWeb, PathWebRelativo);

                fileData = new FileResponse
                {
                    Extension = fileInfo.Extension,
                    NombreInterno = NombreUnico,
                    NombreOriginal = Path.GetFileNameWithoutExtension(data.Files[0].FileName),
                    PathWebAbsolute = PathWebCompleto,
                    PathWebRelative = PathWebRelativo,
                    Size = fileInfo.Length
                };

                return fileData;
            }
            catch (Exception e)
            {
                throw new BusinessException($"Error inesperado: {(e.InnerException is null ? e.Message : e.InnerException.Message)}");
            }
        }

        public async Task<List<FileResponse>> GetFilesCreated(FormDataImagen data)
        {
            try
            {
                // Obtenemos Path de File Server (Red)
                AppsFileServerPath rootFileServer = await _unitOfWork.AppsFileServerPathRepository.GetById(data.IdPathFileServer);

                string PathRedRelative = Path.Combine(rootFileServer.PathRedArchivo, data.Carpeta);
                string PathRedReal = Path.Combine(rootFileServer.PathRed, PathRedRelative);
                string NombreArchivo = string.Empty;
                string PathRedCompleto = string.Empty;
                FileResponse fileData = null;
                FileInfo fileInfo = null;
                List<FileResponse> fileList = new List<FileResponse>();

                // Si no existe la ruta del 'Pathreal' se crea.
                if (!Directory.Exists(PathRedReal))
                {
                    Directory.CreateDirectory(PathRedReal); //Creamos Carpetas
                }

                foreach (var file in data.Files)
                {
                    // Obtenemos información más relevante del adjunto.
                    string fileExt = Path.GetExtension(file.FileName);
                    string NombreUnico = Tools.Funciones.GetCodigoUnico("a");
                    NombreArchivo = string.Concat(NombreUnico, fileExt);

                    if (file.Length > 0)
                    {
                        if (fileExt.Contains(".heic"))
                        {
                            Stream streamImagen = file.OpenReadStream();
                            using (var image = new MagickImage(streamImagen))
                            {
                                // Save frame as jpg
                                NombreArchivo = NombreArchivo.Replace(".heic", ".jpg");
                                PathRedCompleto = Path.Combine(PathRedReal, NombreArchivo);
                                image.Write(PathRedCompleto);
                            }
                        }
                        else
                        {
                            PathRedCompleto = Path.Combine(PathRedReal, NombreArchivo);
                            using (var stream = File.Create(PathRedCompleto))
                            {
                                await file.CopyToAsync(stream);
                            }
                        }
                    }
                    else
                    {
                        throw new BusinessException("El archivo no contiene un tamaño específico.");
                    }

                    if (!File.Exists(PathRedCompleto))
                    {
                        throw new BusinessException("Se presentó un error al crear archivo");
                    }

                    fileInfo = new FileInfo(PathRedCompleto);

                    // Consultamos el Path de las imágenes (Web)
                    string rootWeb = rootFileServer.PathWeb;
                    string relativeWebPath = rootFileServer.PathWebArchivo;
                    string PathWebRelativo = string.Concat(relativeWebPath, data.Carpeta, "/", NombreArchivo);
                    string PathWebCompleto = string.Concat(rootWeb, PathWebRelativo);

                    fileData = new FileResponse
                    {
                        Extension = fileInfo.Extension,
                        NombreInterno = NombreUnico,
                        NombreOriginal = Path.GetFileNameWithoutExtension(file.FileName),
                        PathWebAbsolute = PathWebCompleto,
                        PathWebRelative = PathWebRelativo,
                        Size = fileInfo.Length
                    };

                    fileList.Add(fileData);
                }

                return fileList;
            }
            catch (Exception e)
            {
                throw new BusinessException($"Error inesperado: {(e.InnerException is null ? e.Message : e.InnerException.Message)}");
            }
        }
    }

    public class FileResponse
    {
        public string Extension { get; set; }
        public string NombreInterno { get; set; }
        public string NombreOriginal { get; set; }
        public string PathWebAbsolute { get; set; }
        public string PathWebRelative { get; set; }
        public long Size { get; set; }
    }
}
