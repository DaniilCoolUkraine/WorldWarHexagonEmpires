using HexagonWar.ScriptableObjects;
using UnityEngine;

namespace HexagonWar
{
    public class Test : MonoBehaviour
    {

        public UnitLevelDataSO DataSo;

        private void Start()
        {
            var unit = Instantiate(new GameObject("Gameobj1").AddComponent<Unit>());
            unit.SetUnitData(DataSo);
            unit.TakeDamage(3);
            Debug.Log(unit.GetHealth());
        }
    }
}