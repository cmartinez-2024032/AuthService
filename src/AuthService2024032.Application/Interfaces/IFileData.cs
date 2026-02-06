namespace AuthService2024032.Application.interfaces;

public interface IFileData
{
    byte[] Data {get;}
    string ContentType {get;}
    string FileName {get;}
    long Size {get;}
}