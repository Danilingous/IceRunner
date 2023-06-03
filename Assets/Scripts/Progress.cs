using System.Collections.Generic;
using UnityEngine;
public class PlayerInfo
{
    public float PermomentSpeedBonus=0f;
    public int SpeedLevel = 1;
    public int CountOfCoin = 0;
    public List<int> BestScoreEachLevel = new List<int>();
    public int TotalScore;
    public bool FullAuthorization;
    public bool Mute;
}

public class Progress : MonoBehaviour
{
    private PlayerInfo PlayerInfo = new(); // Убрать инициализацию, когда добавлю загрузку информации с SDK
    public static Progress Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            transform.parent = null;
            DontDestroyOnLoad(gameObject);
            //LoadExtern();

        }
        else Destroy(gameObject);
    }

    public float GetPermomentSpeedBonus() => PlayerInfo.PermomentSpeedBonus;
    

}
