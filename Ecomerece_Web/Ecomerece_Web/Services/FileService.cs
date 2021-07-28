using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecomerece_Web.Services
{

    public class FileService
    {
        private readonly BlobContainerClient containerClient;

        public FileService([NotNull] BlobServiceClient serviceClient, [NotNull] AzureStorageOption option)
        {
            if (serviceClient is null)
            {
                throw new ArgumentNullException(nameof(serviceClient));
            }

            if (option is null)
            {
                throw new ArgumentNullException(nameof(option));
            }

            this.containerClient = serviceClient.GetBlobContainerClient(option.ContainerName);
        }

        public async Task<Stream> loadImg(string fileName, CancellationToken cancellationToken = default)
        {
            var blobClient = containerClient.GetBlobClient(fileName);
            var response = await blobClient.DownloadStreamingAsync(cancellationToken: cancellationToken);

            return response.Value.Content;
        }
        public async Task uploadFile(IFormFile file, CancellationToken cancellationToken = default)
        {
            if (!containerClient.GetBlobClient(file.FileName).Exists())
            {
                using var stream = file.OpenReadStream();

                await containerClient.UploadBlobAsync(file.FileName, stream, cancellationToken);

            }
        }
        public async Task uploadMultiFile(IEnumerable<IFormFile> files, CancellationToken cancellationToken = default)
        {
            foreach (var i in files)
            {
                if (!containerClient.GetBlobClient(i.FileName).Exists())
                {
                    using var stream = i.OpenReadStream();

                    await containerClient.UploadBlobAsync(i.FileName, stream, cancellationToken);

                    stream.Dispose();
                }

            }
        }
        public async Task deleteFile(string fileName, CancellationToken cancellationToken = default)
        {
            await containerClient.DeleteBlobIfExistsAsync(fileName, cancellationToken: cancellationToken);
        }
        public string GetContainerUrl()
        {
            return containerClient.Uri.AbsoluteUri;
        }
    }
}

