using UnityEngine;

public class FinishLineLogic : MonoBehaviour

{
    [SerializeField] private PlayerTurning _playerTurning;
    [SerializeField] private PlayerForwardMove _playerForwardMove;
    [SerializeField] private PlayerFinishDeceleration _playerFinishDeceleration;
    [SerializeField] private PlayerAnimation _playerAnimation;
    private void OnTriggerEnter(Collider other)
    {
        _playerForwardMove.enabled = false;
        _playerTurning.enabled = false;
        _playerFinishDeceleration.enabled = true;
    }
}
