using UnityEngine;

public class ClickButtonsLogic : MonoBehaviour
{
    [SerializeField] private PlayerTurning _playerTurning;
    [SerializeField] private PlayerForwardMove _playerForwardMove;
    [SerializeField] private PlayerAnimation _playerAnimation;
    [SerializeField] private CanvasesManager _canvasesManager;
    

  
    public void ClickStartPlayButton()
    {
        _canvasesManager.OffStartMenuCanvas();
        _playerForwardMove.enabled = true;
        _playerTurning.enabled = true;
        _playerAnimation.StartRunAnimation();
    }
}
