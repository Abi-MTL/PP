namespace ImageDisplayer.Services;
public interface IImageProvider
{
    Task<string>  GetImage(string userIdentifier);
}