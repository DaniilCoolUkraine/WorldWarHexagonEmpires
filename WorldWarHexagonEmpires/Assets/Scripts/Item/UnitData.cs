using HexagonWar.ScriptableObjects;
using UnityEngine;

namespace HexagonWar.Item
{
    public class UnitData
    {
        private UnitLevelDataSO _unitCharacteristics;
        public int Health { get; private set; }
        public Sprite Sprite => _unitCharacteristics.Icon;
        
        public UnitData(UnitLevelDataSO unitLevelData)
        {
            _unitCharacteristics = unitLevelData;
            Health = _unitCharacteristics.Health;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }

    }
}