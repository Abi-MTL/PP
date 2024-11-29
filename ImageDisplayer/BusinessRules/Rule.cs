namespace ImageDisplayer.BusinessRules;
public static class Rules
{

       public static bool IsLastDigitGreaterThan5(string userIdentifier)
   {
        var lastDigit = GetLastDigit(userIdentifier);
        if (lastDigit != -1)
            {
                return lastDigit > 5;
            }

                return false;
   }
      public static bool IsLastDigitLessThan6(string userIdentifier)
   {
        var lastDigit = GetLastDigit(userIdentifier);
        if (lastDigit != -1)
            {
                return lastDigit < 6 && lastDigit > 0;
            }

      return false;
   }
      public static bool DoesIdentifierContainsAtLeastOneVowel(string userIdentifier)
   {
      return ContainsVowel(userIdentifier);
   }
      public static bool DoesIdentifierContainsNonAlphaNumeric(string userIdentifier)
   {
       return ContainsNonAlphaNumeric(userIdentifier);
   }
      public static int GetLastDigit(string userIdentifier)
   {
        char LastChar = userIdentifier[userIdentifier.Length - 1];
        if (!Char.IsDigit(LastChar)) 
            {
                return -1;
            }
        return (int)char.GetNumericValue(LastChar);
  
   }
      private static bool ContainsVowel(string userIdentifier)
   {
        HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        foreach (char c in userIdentifier)
            {
                if (vowels.Contains(c))
                    {
                        return true;
                    }
            }
      return false;
   }
      private static bool ContainsNonAlphaNumeric(string str)
   {
        foreach (char c in str)
            {
                if (!char.IsLetterOrDigit(c))
                    {
                        return true; // Found a non-alphanumeric character
                    }
            }
      return false; // No non-alphanumeric characters found
   }
}