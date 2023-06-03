using UnityEngine;

public class AddCoinLogic : MonoBehaviour
{
    [SerializeField] private CoinCounter _coinCounter;
    [SerializeField] private GameObject _coinEffectPrefab;
    private int _coinValue = 1;
    private void OnTriggerEnter(Collider other)
    {
        _coinCounter.AddCoins(_coinValue);
        Instantiate(_coinEffectPrefab,transform.position,transform.rotation);
        Destroy(gameObject);
    }
}
