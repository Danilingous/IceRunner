using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneloader : MonoBehaviour
{
    public void LoadNextLevel()
    {
        int nextBuildIndex = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextBuildIndex == SceneManager.sceneCountInBuildSettings) nextBuildIndex = 0;
        SceneManager.LoadScene(nextBuildIndex);
    }

    public void LoadLevelAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
