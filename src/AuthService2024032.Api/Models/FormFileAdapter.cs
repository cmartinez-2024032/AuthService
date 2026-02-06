using AuthService2024032.Application.interfaces;
using Microsoft.AspNetCore.Http;
namespace AuthService2024032.Api.Models;
 
public class FormFileAdapter : IFileData
{
    private readonly IFormFile _formfile;
    private byte[]? _data;
 
    public FormFileAdapter(IFormFile formfile)
    {
        ArgumentNullException.ThrowIfNull(formfile);
        _formfile = formfile;
    }
 
    public byte[] Data
    {
        get
        {
            if(_data == null)
            {
                using var memoryStream = new MemoryStream();
                _formfile.CopyTo(memoryStream);
                _data = memoryStream.ToArray();
            }
            return Data;
        }
    }
 
    public string ContentType => _formfile.ContentType;
    public string FileName => _formfile.FileName;
    public long Size => _formfile.Length;
   
}
 