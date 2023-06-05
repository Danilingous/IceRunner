using UnityEngine;

public class CanvasesManager : MonoBehaviour
{
    [SerializeField] private GameObject _startMenuCanvas;
    [SerializeField] private GameObject _endGameLoseCanvas;
    [SerializeField] private GameObject _endGameWinCanvas;



    public void OffStartMenuCanvas()=> _startMenuCanvas.SetActive(false);

    public void OnEndGameLoseCanvas() => _endGameLoseCanvas.SetActive(true);

    public void OnEndGameWinCanvas() => _endGameWinCanvas.SetActive(true);
}
