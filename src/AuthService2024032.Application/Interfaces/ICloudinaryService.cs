namespace AuthService2024032.Application.interfaces;

public interface ICloudinaryService
{
    Task<string> UploadImageAsync(IFileData imageFile, string filename);
    Task<bool> DeleteImageAsync(string publicId);
    string GetDeFailtAvatarUl();
    string GetFullImageUrl(string imagePath);
}