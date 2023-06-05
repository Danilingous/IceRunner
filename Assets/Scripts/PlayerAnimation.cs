using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    public void StartRunAnimation() => _animator.SetBool("Run",true);
}
