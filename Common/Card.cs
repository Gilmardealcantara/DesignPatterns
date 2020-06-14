using System;

namespace Common
{
    public class Card : ICardComponent
    {
        protected string _name;
        protected int _attack;
        protected int _defense;

        public Card(string name, int attack, int defense)
        {
            _name = name;
            _attack = attack;
            _defense = defense;
        }
        public virtual string Name { get { return _name; } }
        public virtual int Attack { get { return _attack; } }
        public virtual int Defense { get { return _defense; } }

        public string Display() => $"{_name}: {_attack} / {_defense}";

        public void Add(ICardComponent component)
        {
            throw new NotImplementedException("Can't Call this method on a card");
        }

        public ICardComponent Get(int index)
        {
            throw new NotImplementedException("Can't Call this method on a card");
        }

        public bool Remove(ICardComponent component)
        {
            throw new NotImplementedException("Can't Call this method on a card");
        }
    }
}