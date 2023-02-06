using HexagonWar.Items.Data;
using HexagonWar.ScriptableObjects;
using UnityEngine;

namespace HexagonWar.Items
{
    public class Unit : Item
    {
        private UnitData _unitData;

        public void SetUnitData(UnitLevelDataSO unitLevelData)
        {
            _unitData = new UnitData(unitLevelData);

            GetComponent<SpriteRenderer>().sprite = _unitData.Sprite;
        }

        public void TakeDamage(int damage)
        {
            _unitData.TakeDamage(damage);
            
            if (_unitData.Health<=0)
            {
                Destroy(gameObject);
            }
        }
        
    }
}