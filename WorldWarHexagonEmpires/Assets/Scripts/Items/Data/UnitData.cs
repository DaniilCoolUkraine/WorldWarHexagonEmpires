using HexagonWar.ScriptableObjects;

namespace HexagonWar.Items.Data
{
    public class UnitData : ItemData
    {
        public override int Health { get; protected set; }
        public override int Damage { get; }

        public UnitData(UnitLevelDataSO unitLevelData)
        {
            ItemCharacteristics = unitLevelData;
            
            Health = ItemCharacteristics.Health;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }

    }
}