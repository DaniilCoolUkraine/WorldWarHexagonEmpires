using HexagonWar.ScriptableObjects;
using UnityEngine;

namespace HexagonWar.Item
{
    public class Unit : MonoBehaviour
    {
        private UnitData _unitData;

        public void SetUnitData(UnitLevelDataSO unitLevelData)
        {
            _unitData = new UnitData(unitLevelData);
            
            //TODO make it different func
            GetComponent<SpriteRenderer>().sprite = _unitData.Sprite;
        }

        public void TakeDamage(int damage)
        {
            _unitData.TakeDamage(damage);
        }

        public int GetHealth() => _unitData.Health;
    }
}