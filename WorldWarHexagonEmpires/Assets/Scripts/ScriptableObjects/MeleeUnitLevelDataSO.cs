using UnityEngine;

namespace HexagonWar.ScriptableObjects
{
    [CreateAssetMenu(fileName = "NewMeleeUnit", menuName = "UnitData/New Melee Unit")]
    public class MeleeUnitLevelDataSO: UnitLevelDataSO
    {
        [Space(10)]
        [SerializeField] protected int _health;
        
        [Space(10)] 
        [SerializeField] protected int _highestDangerousLevel;

        public override int HighestDangerousLevel => _highestDangerousLevel;
        public override int AttackRadius { get; } = 1;
        
        public override int Health => _health;
    }
}