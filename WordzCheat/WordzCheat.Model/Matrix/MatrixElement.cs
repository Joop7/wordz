using System;
using System.Collections.Generic;

namespace WordzCheat.Model.Matrix
{
    public class MatrixElement
    {
        public char Value { get; private set; }
        public int Index { get; private set; }
        public int[] NeighborIndices { get; private set; }

        public MatrixElement(char inValue, int inIndex, int[] inNeighborIndices)
        {
            Value = inValue;
            Index = inIndex;
            NeighborIndices = inNeighborIndices;
        }
    }
}
