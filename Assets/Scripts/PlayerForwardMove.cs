using UnityEngine;

public class PlayerForwardMove : MonoBehaviour
{
    [SerializeField] private float _baseSpeed = 20f;
    [SerializeField] private float _currentSpeed; // ”брать атрибут после проверки скорости с бонусом
    private void Start()
    {
        _currentSpeed = _baseSpeed + Progress.Instance.GetPermomentSpeedBonus();
    }
    private void Update()
    {
        ForwardMove();
    }

    private void ForwardMove()
    {
        transform.position += new Vector3(0, 0, _currentSpeed * Time.deltaTime);
    }
}
