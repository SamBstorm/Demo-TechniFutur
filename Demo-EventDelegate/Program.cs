using System;

namespace Demo_EventDelegate
{
    class Program
    {
        public static Random RNG = new Random();
        static void Main(string[] args)
        {
            Character p = new Player("Bane");
            GameNotif.Enable(p);

            p.takeDamage += p.Hurt;
            int count = 0;
            while (p.HealthPoint > 0)
            {
                Monster m = new Monster($"Monstre{count}");
                GameNotif.Enable(m);
                m.takeDamage += m.Hurt;
                p.Attack(m);
                m.takeDamage -= m.Hurt;
                count++;
            }
            p.takeDamage -= p.Hurt; 
        }
    }
}
