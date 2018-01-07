using System;
using System.Collections.Generic;

namespace SantasFactory
{
    class SantasBag
    {
        private List<Toys> inSantasBag = new List<Toys>();

        public void Add(Toys toys)
        {
            inSantasBag.Add(toys);
        }

        public int GetNumberOfItems()
        {
           return inSantasBag.Count;
        }

        public void Deliver(string name)
        {
            int lastIndex= inSantasBag.Count-1;
            inSantasBag[lastIndex].Owner = name;
            inSantasBag.RemoveAt(lastIndex);
        }
    }
}