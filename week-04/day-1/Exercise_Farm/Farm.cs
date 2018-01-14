﻿using System;
using System.Collections.Generic;

namespace Exercise_Farm
{
    class Farm
    {
        public List<Animals> AnimalList { get; set; }
        public double FreePlaces { get; set; }

        public Farm(List<Animals> animalList, double freePlaces)
        {
            AnimalList = animalList;
            FreePlaces = freePlaces - animalList.Count;
        }

        public void Breed()
        {
            if (FreePlaces > 0)
            {
                AnimalList.Add(new Animals());
                FreePlaces--;
            }
        }
        public void Slaughter()
        {
            var theLeastHungry = AnimalList[0];
            foreach (Animals item in AnimalList)
            {
                if (theLeastHungry.HungerValue > item.HungerValue)
                {
                    theLeastHungry = item;
                }
            }
            AnimalList.Remove(theLeastHungry);
            FreePlaces++;
        }
    }
}