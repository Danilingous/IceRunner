using UnityEngine;

public class CanvasesManager : MonoBehaviour
{
    [SerializeField] private GameObject _startMenuCanvas;
    [SerializeField] private GameObject _endGameLoseCanvas;

    public void OffStartMenuCanvas()=> _startMenuCanvas.SetActive(false);

    public void OnEndGameLoseCanvas() => _endGameLoseCanvas.SetActive(true);
}
