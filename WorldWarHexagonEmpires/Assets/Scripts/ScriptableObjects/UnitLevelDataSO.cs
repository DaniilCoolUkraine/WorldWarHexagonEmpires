using UnityEngine;

namespace ScriptableObjects
{
    public class UnitLevelDataSO : ScriptableObject
    {
        [SerializeField] protected string _name;
        [SerializeField] protected int _level;
        [SerializeField] protected Sprite _icon;
        
        [Space(10)]
        [SerializeField] protected int _damage;

        [Space(10)]
        [SerializeField] protected int _availableMovementRadius;
        [SerializeField] protected bool _canCaptureTerritories;
        
        [Space(10)]
        [SerializeField] protected int _price;
        [SerializeField] protected int _payment;
        
        public string Name => _name;
        public int Level => _level;
        public Sprite Icon => _icon;
        
        public virtual int Health { get; }
        public int Damage => _damage;

        public int AvailableMovementRadius => _availableMovementRadius;
        public bool CanCaptureTerritories => _canCaptureTerritories;

        public int Price => _price;
        public int Payment => _payment;
        
        public virtual int AttackRadius { get; }
    }
}