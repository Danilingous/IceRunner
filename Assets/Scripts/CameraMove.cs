using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    private void Start()
    {
        transform.parent = null;
    }
    private void LateUpdate()
    {
        if (_playerTransform)
        {
            transform.position = _playerTransform.position;
        }
    }
}
