using System;
using System.Collections.Generic;
using System.Linq;
using WordzCheat.Model.Factories;
using WordzCheat.Model.Exceptions;

namespace WordzCheat.Model.Matrix
{
    public class WordzLetterMatrix : LetterMatrix
    {
        const int MATRIX_SIZE = 4;

        public WordzLetterMatrix(char[] inLetters)
        {
            if (inLetters.Length < MATRIX_SIZE * MATRIX_SIZE)
                throw new WrongNumberOfElements();
            else
                elements = MatrixElementsFactory.GetElements(MATRIX_SIZE, inLetters);
        }

        public override List<string> FindWords(List<string> inDictionary)
        {
            List<string> words = new List<string>();

            foreach (string word in inDictionary)
            {
                if (IsInMatrix(word) && !words.Contains(word))
                    words.Add(word);
            }

            return words;
        }

        #region private methods

        private bool IsInMatrix(string inWord)
        {
            List<List<int>> possibleIndexSequence = new List<List<int>>();
            
            foreach (char letter in inWord)
            {
                List<MatrixElement> possibleElements = elements.FindAll(item => item.Value.Equals(letter));
                if (possibleElements.Count == 0)
                    return false;

                /*
                  ako je riječ o prvom slovu onda će lista mogućih nizova indeksa biti prazna,
                  pa se za svaki element koji sadrži početno slovo inicijalizira posebna lista 
                  s njegovim indeksom
                */
                if (possibleIndexSequence.Count == 0)
                {
                    foreach (MatrixElement element in possibleElements)
                    {
                        List<int> newIndexSequence = new List<int>() { element.Index };
                        possibleIndexSequence.Add(newIndexSequence);
                    }
                }
                else
                {
                    /*
                     ako lista nije prazna, za svaki izabrani element stvaraju se novi nizovi
                     indeksa dodavanjem indeksa elementa na kraj svakog do sad napravljenog niza
                     */
                    List<List<int>> newPossibleIndexSequence = new List<List<int>>();

                    foreach (MatrixElement element in possibleElements)
                    {
                        foreach (List<int> indexSequence in possibleIndexSequence)
                        {
                            if (!indexSequence.Contains(element.Index))
                            {
                                List<int> newIndexSequence = indexSequence.ToList();
                                newIndexSequence.Add(element.Index);
                                newPossibleIndexSequence.Add(newIndexSequence);
                            }
                        }
                    }

                    /*
                     ako nije stvoren niti jedan novi niz, znači da ova riječ
                     ne postoji u matrici slova,
                     inače nova lista nizova postaje lista mogućih nizova indeksa
                     */
                    if (newPossibleIndexSequence.Count == 0)
                        return false;
                    else
                        possibleIndexSequence = newPossibleIndexSequence;
                }
            }

            /*
              na kraju se provjerava da li je moguće prošetati 
              se ijednim nizom indeksa kroz matricu,
              ako je moguće onda riječ postoji u matrici
             */
            return possibleIndexSequence.Any(item => IndexSequenceExists(item));
        }

        private bool IndexSequenceExists(List<int> inIndexSequence)
        {
            /*
             provjera da li je zadanim nizom moguće prošetati matricom na
             na način da se za svaki indeks osim prvog provjerava da
             li je trenutni elemnt susjed prethodnom
             */
            List<int> previusElementNeigbors = new List<int>();
            foreach (int index in inIndexSequence)
            {
                if ((previusElementNeigbors.Count != 0) && !previusElementNeigbors.Contains(index))
                    return false;

                previusElementNeigbors = elements[index].NeighborIndices.ToList();
            }
            return true;
        }

        #endregion
    }
}
