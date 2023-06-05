using System.Collections;
using UnityEngine;

public class PlayerFinishDeceleration : MonoBehaviour
{
    private float _decelerationSpeed;
    private float _curentSpeed;
    [SerializeField] private PlayerForwardMove _playerForwardMove;
    [SerializeField] private PlayerAnimation _playerAnimation;
    private float _stoppingDistance = 5f; 
    private void Start()
    {
        _curentSpeed = _playerForwardMove.GetCurrentSpeed();
        _decelerationSpeed = Mathf.Pow(_curentSpeed,2) / (2*_stoppingDistance); // –ассто€ние через разность квадратов скорости
        StartCoroutine(CoroutineDeseleration());
    }

    private IEnumerator CoroutineDeseleration()
    {
        while(_curentSpeed>0)
        {
            _curentSpeed = Mathf.MoveTowards(_curentSpeed,0,Time.deltaTime*_decelerationSpeed);
            transform.position+= new Vector3(0,0,_curentSpeed*Time.deltaTime);
            yield return null;
            
        }
        StartCoroutine(_playerAnimation.CoroutinFinishLine());
    }
}
