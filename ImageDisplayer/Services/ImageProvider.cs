using System;
using ImageDisplayer.BusinessRules;
using ImageDisplayer.Repositories;
namespace ImageDisplayer.Services;


public class ImageProvider : IImageProvider
{
    private readonly IConfiguration _configs;
    private readonly IRepository _repository;
    public ImageProvider(IConfiguration configuration, IRepository repository)
    {
        _configs = configuration;
        _repository = repository;
    }

    public async Task<string> GetImage(string userIdentifier)
    {
        if(Rules.IsLastDigitGreaterThan5(userIdentifier))
        {
              return _configs["ApiURLs:IsLastDigitGreaterThan5"] + Rules.GetLastDigit(userIdentifier);
        } 
        else if (Rules.IsLastDigitLessThan6(userIdentifier))
        {
            var image =  await _repository.GetImageById(Rules.GetLastDigit(userIdentifier));
              return image?.URL ;
        }
        else if(Rules.DoesIdentifierContainsAtLeastOneVowel(userIdentifier))
        {
              return  _configs["ApiURLs:DoesIdentifierContainsAtLeastOneVowel"];
        }
        else if(Rules.DoesIdentifierContainsNonAlphaNumeric(userIdentifier))
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 6);
              return  (_configs["ApiURLs:DoesIdentifierContainsNonAlphaNumeric"]).Replace("randomNumber", randomNumber.ToString());
        }
        return  (_configs["ApiURLs:Default"]);
    }
        
}