using UnityEngine;

namespace HexagonWar.ScriptableObjects
{
    public class LevelDataSO : ScriptableObject
    {
        [SerializeField] protected string _name;
        [SerializeField] protected int _level;
        [SerializeField] protected Sprite _icon;

        [Space(10)] 
        [SerializeField] protected int _price;
        [SerializeField] protected int _economyAffection;

        public string Name => _name;
        public int Level => _level;
        public Sprite Icon => _icon;

        public virtual int Health { get; }
        public virtual int Damage { get; }

        public int Price => _price;
        public int EconomyAffection => _economyAffection;
    }
}