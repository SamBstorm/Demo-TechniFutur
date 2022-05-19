using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_EventDelegate
{
    public static class GameNotif
    {
        public static void NotifDeath(Character character)
        {
            Console.WriteLine($"Le {character.Name} est mort");
        }
        public static void MusicDeath(Character character)
        {
            Console.WriteLine("Ta ta tata ta tata tata tataaaa");
        }

        public static void NotifHurt(Character character, int damage) {
            Console.WriteLine($"{character.Name} prend {damage} points de dégats... ({character.HealthPoint}/{character.HP_MAX})");
        }

        public static void Enable(Character character)
        {
            character.isDead += NotifDeath;
            character.isDead += MusicDeath;
            character.isDead += Disable;
            character.isHurt += NotifHurt;
        }

        public static void Disable(Character character)
        {
            character.isDead -= NotifDeath;
            character.isDead -= MusicDeath;
            character.isHurt -= NotifHurt;
        }
    }
}
