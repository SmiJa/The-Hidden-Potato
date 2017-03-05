using System;

namespace theHiddenPotato
{



    public class Enemy
    {
        public int level;
        public int health;
        public int strength;
        public string name;
    }

    public class GiantPotatoTroll : Enemy
    {
        public GiantPotatoTroll(int _level, int _health, int _strength)
        {
            level = _level;
            health = _health;
            strength = _strength;
            name = "Giant Potato Troll";
        }
    }    

    public class yamBeast : Enemy
    {
        public yamBeast(int _level, int _health, int _strength)
        {
            level = _level;
            health = _health;
            strength = _strength;
            name = "Yam Beast";
        }
    }

    public class Papas : Enemy
    {
        public Papas(int _level, int _health, int _strength)
        {
            level = _level;
            health = _health;
            strength = _strength;
            name = "Papas";
        }
    }

    public class totArmy : Enemy
    {
        public totArmy(int _level, int _health, int _strength)
        {
            level = _level;
            health = _health;
            strength = _strength;
            name = "Tot Army";
        }
    } 

    public class spudBaby : Enemy
    {
        public spudBaby(int _level, int _health, int _strength)
        {
            level = _level;
            health = _health;
            strength = _strength;
            name = "Spud Baby";
        }
    }
}