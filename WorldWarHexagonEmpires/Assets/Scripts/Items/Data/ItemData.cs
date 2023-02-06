using HexagonWar.ScriptableObjects;
using UnityEngine;

namespace HexagonWar.Items.Data
{
    public abstract class ItemData
    {
        protected ItemLevelDataSO ItemCharacteristics;

        public string Name => ItemCharacteristics.Name;
        public int Level => ItemCharacteristics.Level;
        public Sprite Sprite => ItemCharacteristics.Icon;

        public int Price => ItemCharacteristics.Price;
        public int EconomyAffection => ItemCharacteristics.EconomyAffection;

        public virtual int Health { get; protected set; }
        public virtual int Damage => ItemCharacteristics.Damage;
    }
}