using Unity.VisualScripting;
using UnityEngine;

using HexagonWar.ScriptableObjects;
using Unit = HexagonWar.Item.Unit;

namespace HexagonWar
{
    public class Test : MonoBehaviour
    {
        public UnitLevelDataSO[] DataSO;

        private void Start()
        {
            for (int i = 0; i < DataSO.Length; i++)
            {
                var unit = new GameObject("Unit");

                unit.AddComponent<Item.Unit>();
                unit.AddComponent<SpriteRenderer>();
                
                unit.GetComponent<Unit>().SetUnitData(DataSO[i]);

                unit.transform.position = new Vector3(i, 0, 0);
            }
            
        }
    }
}