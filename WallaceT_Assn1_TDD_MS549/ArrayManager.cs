using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallaceT_Assn1_TDD_MS549
{
    public class ArrayManager 
    {
        private int?[] iInts;
        private ArrayList alInts;
        private bool bHasLimit;
        private int iLen;

        public bool isPredefinedSize { get { return bHasLimit; } }
        public int GetArraySize { get { return iLen; } }
        public Type GetArrayType
        {
            get {
                Type rType;

                if (bHasLimit) { rType = alInts.GetType(); }
                else { rType = iInts.GetType(); }

                return rType;
            }

        }

        public ArrayManager()
        {
            //alInts is unlimited arraylist
            alInts = new ArrayList();
            bHasLimit = false;
            iLen = 0;
        }

        public ArrayManager(int ArraySize)
        {
            //iInts is limited to ArraySize Passed in
            iInts = new int?[ArraySize];
            iLen = ArraySize;
            bHasLimit = true;
        }

        ~ArrayManager()
        {
            //Deconstructor
        }
    }
}
