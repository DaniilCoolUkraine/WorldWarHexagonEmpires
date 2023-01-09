using HexagonWar.ScriptableObjects;

namespace HexagonWar
{
    public class UnitData
    {
        private UnitLevelDataSO _unitCharacteristics;
        public int Health { get; private set; }

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