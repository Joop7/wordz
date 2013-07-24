using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WordzCheat.Model.Properties;
using WordzCheat.Model.Exceptions;

namespace WordzCheat.Model.Factories
{
    public enum Language
    {
        HR
    }
    public static class DictionaryFactory
    {
        public static List<string> GetDictionary(Language inLanguage)
        {
            switch (inLanguage)
            {
                case Language.HR:
                    string[] delimiter = new string[] { "\r\n" };
                    List<string> dictionary = Resources.HRdict.Split(delimiter, StringSplitOptions.RemoveEmptyEntries).ToList();
                    return dictionary;

                default:
                    throw new NoSuchDictionary();
            }
        }
    }
}
