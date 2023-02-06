using UnityEngine;

namespace HexagonWar
{
    public class CameraMover : MonoBehaviour
    {
        [SerializeField] private Camera _camera;
        [SerializeField] [Range(0, 1)] private float _zoom;
        
        void Start()
        {
            _zoom = 0.5f;
        }
        
        void Update()
        {
            
            // shit
            if (Input.GetMouseButtonDown(0))
            {
                Vector2 _mouseWorldPosition = _camera.ScreenToWorldPoint(Input.mousePosition);
                Vector3 _cameraPosition = _camera.transform.position;
                
                float _magnitude = _mouseWorldPosition.magnitude;

                float _newXPosition = _cameraPosition.x + _magnitude;
                float _newYPosition = _cameraPosition.y + _magnitude;

                _camera.transform.position += new Vector3(_newXPosition, _newYPosition, 0);

            }
        }
    }
}
