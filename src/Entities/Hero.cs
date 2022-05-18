using System;

namespace projeto.src.Entities
{
    public class Hero

    {
        public Hero(string Name, int level, string HeroType)
        {
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;


        }
        public Hero()
        {

        }

        public string Name;
        public int level;
        public string HeroType;

        public override string ToString()
        {
            return this.Name + " " + this.level + " " + this.HeroType;
        }

        public string Attack()
        {
            return this.Name + " Atacou com a sua espada";
        }
    }
}