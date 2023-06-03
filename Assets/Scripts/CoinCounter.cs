using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    private int _countCoins;
    
    void Start()
    {
        _countCoins= Progress.Instance.GetCountCoins();
    }

    public void AddCoins(int count)
    {
        _countCoins += count;
    }
    
}
