using UnityEngine;

public class BarrierLogic : MonoBehaviour
{
    [SerializeField] private GameObject _crashEffectPrefab;
    [SerializeField] private PlayerTurning _playerTurning;
    [SerializeField] private PlayerForwardMove _playerForwardMove;
    [SerializeField] private PlayerAnimation _playerAnimation;

    private void OnTriggerEnter(Collider other)
    {
        _playerForwardMove.enabled = false;
        _playerTurning.enabled = false;
        GameObject player = other.attachedRigidbody.gameObject;
        Instantiate(_crashEffectPrefab, player.transform.position+new Vector3(0,1,0), player.transform.rotation);
        _playerAnimation.StartCrashAnimation();
       
    }
}
