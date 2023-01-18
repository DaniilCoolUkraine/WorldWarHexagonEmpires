using System;
using HexagonWar.Builder;
using HexagonWar.Item;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace HexagonWar
{
    public class ItemPlacer : MonoBehaviour
    {

        protected Unit _flyingItem;
        [SerializeField] protected Camera _camera;
        [SerializeField] protected Tilemap _map;

        // public void OpenMenu(GameObject menu)
        // {
        //     menu.SetActive(true);
        // }
        // public void CloseMenu(GameObject menu)
        // {
        //     menu.SetActive(false);
        // }
        
        private void Update()
        {
            if (_flyingItem != null)
            {
                _flyingItem.transform.position =
                    _map.WorldToCell(_camera.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0, 0, 10));

            }

            if (Input.GetMouseButtonDown(0))
            {
                _flyingItem = null;
            }
        }
        
        public void PlaceItem(int level)
        {
            // TODO check if it`s a building or unit
            // better way -- decompose for buildings and units

            MeleeUnitBuilder unitBuilder = new MeleeUnitBuilder();
            _flyingItem = unitBuilder.WithLevel(level).Build().GetComponent<Unit>();
            
        }
        
    }
}