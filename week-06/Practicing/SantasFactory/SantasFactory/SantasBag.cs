using System;
using System.Collections.Generic;

namespace SantasFactory
{
    class SantasBag
    {
        private List<Toys> santaBag = new List<Toys>();

        public void Add(Toys toys)
        {
            santaBag.Add(toys);
        }

        public int GetNumberOfItems()
        {
           return santaBag.Count;
        }
    }
}