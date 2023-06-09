using System.Collections;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] GameObject _deathEffectCrashPrefab;
    [SerializeField] GameObject _WinSoundPrefab;
    [SerializeField] private CanvasesManager _canvasesManager;


    public void StartRunAnimation() => _animator.SetBool("Run",true);


    public void StartCrashAnimation()
    {
        _animator.SetBool("Fall", true);
        StartCoroutine(CoroutineCrash());
    }

    private IEnumerator CoroutineCrash()
    {
        yield return new WaitForSeconds(2f);
        Instantiate(_deathEffectCrashPrefab, transform.position - new Vector3(0, 0, 1f), transform.rotation);
        yield return new WaitForSeconds(1.5f);
        _canvasesManager.OnEndGameLoseCanvas();
        Destroy(gameObject);
    }

    public IEnumerator CoroutinFinishLine()
    {
        Instantiate(_WinSoundPrefab,transform.position,transform.rotation);
        _animator.SetBool("Victory", true);
        yield return new WaitForSeconds(2);
        _canvasesManager.OnEndGameWinCanvas();

    }
}
