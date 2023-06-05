using UnityEngine;

public class ClickButtonsLogic : MonoBehaviour
{
    [SerializeField] private PlayerTurning _playerTurning;
    [SerializeField] private PlayerForwardMove _playerForwardMove;
    [SerializeField] private PlayerAnimation _playerAnimation;
    [SerializeField] private CanvasesManager _canvasesManager;
    [SerializeField] private Sceneloader _sceneloader;
    

  
    public void ClickStartPlayButton()
    {
        _canvasesManager.OffStartMenuCanvas();
        _playerForwardMove.enabled = true;
        _playerTurning.enabled = true;
        _playerAnimation.StartRunAnimation();
    }

    public void ClickAgainLevelButton() => _sceneloader.LoadLevelAgain();

    public void ClickNextLevelButton() => _sceneloader.LoadNextLevel();

}
