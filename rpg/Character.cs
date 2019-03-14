namespace Rpg
{
    public class Character
    {
        public string Name { get; set; }

        public long CurrentExperience { get; set; }

        public long NextLevelExperience { get; set; }

        public int Level { get; set; }

        public int MaxLevel { get; set; }

        public long CurrentHealthPoints { get; set; }

        public long MaxHealthPoints { get; set; }

        public Character(string name)
        {
            Name = name;
            Level = 1;
            CurrentExperience = 0;
            NextLevelExperience = 100;
            CurrentHealthPoints = 400;
            MaxHealthPoints = CurrentHealthPoints;
        }
    }
}
