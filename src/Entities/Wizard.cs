using System;
namespace projeto.src.Entities
{
    public class Wizard : Hero
    {


        public Wizard(string Name, int level, string HeroType)
        {
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;
        }
        public new virtual string Attack()
        {
            return this.Name + " Atacou com sua magia.";
        }

        public virtual string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Atacou com sua ultimate Bonus de ataque + " + Bonus;
            }
            else
            {
                return this.Name + " Atacou com sua mágia primária Bonus de ataque + " + Bonus;
            }

        }
    }
}