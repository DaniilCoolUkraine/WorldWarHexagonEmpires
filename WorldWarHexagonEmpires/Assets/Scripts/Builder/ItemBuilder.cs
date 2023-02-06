using HexagonWar.ScriptableObjects;
using UnityEngine;

namespace HexagonWar.Builder
{
    public abstract class ItemBuilder
    {
        protected GameObject Item;

        protected virtual string Path { get; set; }
        //protected array of items level data to store its data. loads once from ItemsData folder on game start
        protected ItemLevelDataSO[] ItemLevelData;

        protected abstract void LoadData();

        public abstract ItemBuilder WithLevel(int level);
        public GameObject Build() => Item;
    }
}