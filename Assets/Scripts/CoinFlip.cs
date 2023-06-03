using UnityEngine;

public class CoinFlip : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed = 120f;
   
    void Update()
    {
        transform.eulerAngles += new Vector3(0,_rotateSpeed*Time.deltaTime, 0);
    }
}
