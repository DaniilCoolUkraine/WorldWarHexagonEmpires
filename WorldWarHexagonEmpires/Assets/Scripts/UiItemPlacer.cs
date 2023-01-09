using HexagonWar.ScriptableObjects;
using UnityEngine;

namespace HexagonWar
{
    public class UiItemPlacer : MonoBehaviour
    {
        public void OpenMenu(GameObject menu)
        {
            menu.SetActive(true);
        }

        public void CloseMenu(GameObject menu)
        {
            menu.SetActive(false);
        }

        public void PlaceItem(LevelDataSO itemLevelData)
        {
            // TODO check if it`s a building or unit
            // better way -- decompose for buildings and units


        }
    }
}