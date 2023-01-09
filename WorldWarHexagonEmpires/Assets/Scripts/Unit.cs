using System;
using HexagonWar.ScriptableObjects;
using UnityEngine;

namespace HexagonWar
{

    public class Unit : MonoBehaviour
    {
        private UnitData _unitData;

        public void SetUnitData(UnitLevelDataSO unitLevelData)
        {
            _unitData = new UnitData(unitLevelData);
        }

        public void TakeDamage(int damage)
        {
            _unitData.TakeDamage(damage);
        }

        public int GetHealth() => _unitData.Health;

    }
}