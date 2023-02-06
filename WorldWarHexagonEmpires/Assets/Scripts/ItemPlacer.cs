using HexagonWar.Builder;
using HexagonWar.Items;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace HexagonWar
{
    public class ItemPlacer : MonoBehaviour
    {
        private Item _flyingItem;
        
        [SerializeField] protected Camera _camera;
        [SerializeField] protected Tilemap _map;
        
        private void Update()
        {
            if (_flyingItem != null)
            {
                _flyingItem.transform.position =
                    _map.CellToWorld(
                        _map.WorldToCell(
                            _camera.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0, 0, 10)));
            }

            if (Input.GetMouseButtonDown(0))
            {
                _flyingItem = null;
            }
        }
        
        public void PlaceMeleeUnit(int level)
        {
            var meleeUnitBuilder = new MeleeUnitBuilder();
            _flyingItem = meleeUnitBuilder.WithLevel(level).Build().GetComponent<Item>();
        }
    }
}