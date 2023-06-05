using UnityEngine;

public class ClickButtonsLogic : MonoBehaviour
{
    [SerializeField] private PlayerTurning _playerTurning;
    [SerializeField] private PlayerForwardMove _playerForwardMove;
    [SerializeField] private PlayerAnimation _playerAnimation;
    [SerializeField] private GameObject _startPlayCanvas;

  
    public void ClickStartPlayButton()
    {
        _startPlayCanvas.SetActive(false);
        _playerForwardMove.enabled = true;
        _playerTurning.enabled = true;
        _playerAnimation.StartRunAnimation();
    }
}
