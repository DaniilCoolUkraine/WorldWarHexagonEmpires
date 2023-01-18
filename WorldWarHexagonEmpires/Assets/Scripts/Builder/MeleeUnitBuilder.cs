using HexagonWar.Item;
using HexagonWar.ScriptableObjects;
using UnityEngine;

namespace HexagonWar.Builder
{
    public class MeleeUnitBuilder : UnitBuilder
    {
        protected override string Path { get; set; } = "UnitsData/Melee";

        protected override void LoadData()
        {
            ItemLevelData = Resources.LoadAll<MeleeUnitLevelDataSO>(Path);
        }

        public override ItemBuilder WithLevel(int level)
        {
            //TODO optimize this call to once on game load
            LoadData();
            
            Item = new GameObject("TestName");
            Item.AddComponent<Unit>();
            Item.AddComponent<SpriteRenderer>();

            foreach (LevelDataSO levelDataSo in ItemLevelData)
            {
                var levelData = (MeleeUnitLevelDataSO) levelDataSo;
                if (levelData.Level == level)
                {
                    Item.GetComponent<Unit>().SetUnitData(levelData);
                    break;
                }
            }
            
            return this;
        }
    }
}