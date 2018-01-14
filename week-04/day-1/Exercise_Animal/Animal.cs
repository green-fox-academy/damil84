namespace Exercise_Animal
{
    class Animal
    {
        public int HungerValue { get; set; } = 50;
        public int ThirstValue { get; set; } = 50;
      
        public void Eat()
        {
            HungerValue--;
        }

        public void Drink()
        {
            ThirstValue--;
        }

        public void Play()
        {
            HungerValue++;
            ThirstValue++;
        }

        public int GetHungerStatus()
        {
            return HungerValue;
        }

        public int GetThirstStatus()
        {
            return ThirstValue;
        }
    }
}