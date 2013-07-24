using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WordzCheat.Model.Matrix;
using WordzCheat.Model.Factories;
using System.Net;
using System.IO;
using System.Security.Cryptography;
using WordzCheat.Controller.Properties;

namespace WordzCheat.Controller
{
    public class CheatGenerator
    {
        delegate void UpdateUI();

        const string KEY = "alperisnotherealperisnotherealpe";
        
        IViewDisplay _view;
        string _lastBoardLetters = "";

        public bool AutoInputBoardLetters { get; set; }

        public CheatGenerator(IViewDisplay inView)
        {
            _view = inView;
            AutoInputBoardLetters = true;
            Fiddler.FiddlerApplication.AfterSessionComplete += HTTPSniffer;
            Fiddler.FiddlerApplication.Startup(0, Fiddler.FiddlerCoreStartupFlags.Default);
        }

        public void Dispose()
        {
            Fiddler.FiddlerApplication.Shutdown();
        }

        public void DisplayBoardAndWords(char[] boardLetters)
        {
            if (!_lastBoardLetters.Equals(new String(boardLetters)))
            {
                _view.DisplayLetterBoard(boardLetters);
                List<string> words = FindWords(boardLetters);
                _view.DisplayWords(words);
                _lastBoardLetters = new String(boardLetters);
            }
        }

        private void HTTPSniffer(Fiddler.Session inSession)
        {
            _view.Invoke(new UpdateUI(() =>
            {
                if (AutoInputBoardLetters && 
                    inSession.fullUrl.Contains(Resources.GameInfoURL) && 
                    !inSession.fullUrl.Contains(Resources.InsuranceEnding))
                {
                    string url = Resources.GameInfoURL + Resources.InsuranceEnding;
                    string base64Data = GetHtmlBodyContent(url);
                    string bodyContent = DecodeBodyContent(KEY, base64Data);
                    char[] boardLetters = GetBoardLetters(bodyContent);

                    DisplayBoardAndWords(boardLetters);
                }
            }));
        }

        private char[] GetBoardLetters(string inHTMLBodyMsg)
        {
            string firstStageOfParsing = inHTMLBodyMsg.Split('~')[3];
            string secondStageOfParsing = firstStageOfParsing.Split('|')[0];
            char[] boardLetters = secondStageOfParsing.ToCharArray();
            
            return boardLetters;
        }

        private List<string> FindWords(char[] inLetters)
        {
            List<string> dictionary = DictionaryFactory.GetDictionary(Language.HR);
            WordzLetterMatrix matrix = new WordzLetterMatrix(inLetters);
            return matrix.FindWords(dictionary);
        }

        private static string GetHtmlBodyContent(string inURL)
        {
            string bodyContent;
            WebResponse objResponse;
            WebRequest objRequest = HttpWebRequest.Create(inURL);
            objResponse = objRequest.GetResponse();

            using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
            {
                bodyContent = sr.ReadToEnd();
            }

            return bodyContent;
        }

        private string DecodeBodyContent(string inKey, string inEncryptedData)
        {
            byte[] key = ASCIIEncoding.UTF8.GetBytes(inKey);
            byte[] encryptedData = Convert.FromBase64String(inEncryptedData);
            Aes aes = Aes.Create();
            aes.Mode = CipherMode.ECB;
            aes.Padding = PaddingMode.None;

            using (var memStream = new MemoryStream())
            {
                using (var crypStream = new CryptoStream(memStream, aes.CreateDecryptor(key, null), CryptoStreamMode.Write))
                {
                    crypStream.Write(encryptedData, 0, encryptedData.Length);
                }
                byte[] decryptedData = memStream.ToArray();

                return Encoding.UTF8.GetString(decryptedData); ;
            }
        }

    }
}
