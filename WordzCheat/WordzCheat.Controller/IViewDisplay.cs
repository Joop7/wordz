using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordzCheat.Controller
{
    public interface IViewDisplay
    {
        void DisplayWords(List<string> words);
        void DisplayLetterBoard(char[] letters);
        object Invoke(Delegate methode);
    }
}
