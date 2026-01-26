namespace AuthService2024032.Application.interfaces;

public interface IFileData
{
    byte[] Data {get;}
    string ContenType {get;}
    string FileName {get;}
    long Size {get;}
}