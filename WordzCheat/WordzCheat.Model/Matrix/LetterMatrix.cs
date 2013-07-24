using System;
using System.Collections.Generic;

namespace WordzCheat.Model.Matrix
{
    public abstract class LetterMatrix
    {
        protected List<MatrixElement> elements;

        public abstract List<string> FindWords(List<string> inDictionary);
    }
}
