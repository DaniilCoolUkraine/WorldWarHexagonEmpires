using UnityEngine;

namespace HexagonWar.ScriptableObjects
{
    public class UnitLevelDataSO : ItemLevelDataSO
    {
        [Space(10)]
        [SerializeField] protected int _availableMovementRadius;

        [Space(10)]
        [SerializeField] protected int _damage;
        
        public int AvailableMovementRadius => _availableMovementRadius;
        public virtual int HighestDangerousLevel { get; }
        public virtual int AttackRadius { get; }
        
        public override int Damage => _damage;
    }
}