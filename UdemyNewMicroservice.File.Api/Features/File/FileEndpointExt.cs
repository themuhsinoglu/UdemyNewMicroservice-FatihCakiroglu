using Asp.Versioning.Builder;
using UdemyNewMicroservice.File.Api.Features.File.Upload;

namespace UdemyNewMicroservice.File.Api.Features.File
{
    public class FileEndpointExt
    {
        public static void AddFileGroupEndpointExt(this WebApplication app, ApiVersionSet apiVersionSet)
        {
            app.MapGroup("api/v{version:apiVersion}/files").WithTags("files").WithApiVersionSet(apiVersionSet).UploadFileGroupItemEndpoint();
              .DeleteFileGroupItemEndpoint();
        }
    }
}
