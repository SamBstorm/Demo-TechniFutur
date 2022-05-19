using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_EventDelegate
{
    public delegate void DeathAction(Character character);
    public delegate void HurtAction(Character character, int damage);
    public abstract class Character
    {
        private Random RNG = new Random();
        public event DeathAction isDead;
        public event HurtAction isHurt;
        public event Action<Character, int> takeDamage;
        private int _hpMax;
        public int HP_MAX { get { return _hpMax; } }
        private int _healthPoint;

        private int _strength;
        private int _deffense;

        public string Name { get; set; }
        public int HealthPoint
        {
            get { return _healthPoint; }
            set
            {
                int old_value = _healthPoint;
                if (value < 0)
                {
                    _healthPoint = 0;
                }
                else if (value > HP_MAX) _healthPoint = HP_MAX;
                else _healthPoint = value;
                if (_healthPoint == 0) isDead(this);
            }
        }

        public Character(int hp, int strength, int def, string name)
        {
            this._hpMax = hp;
            this._healthPoint = HP_MAX;
            this._strength = strength;
            this._deffense = def;
            this.Name = name;
        }

        public void Attack(Character opponent) {
            int damage = RNG.Next(this._strength/2, this._strength);
            opponent.takeDamage(this, damage);
        }

        public void Hurt(Character bully, int damage)
        {
            damage = damage / this._deffense;
            isHurt(this, damage);
            this.HealthPoint -= damage;
            if (this.HealthPoint > 0) this.Attack(bully);
        }
    }
}
