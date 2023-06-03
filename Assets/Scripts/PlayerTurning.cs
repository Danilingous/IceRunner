using UnityEngine;

public class PlayerTurning : MonoBehaviour
{
    private float _targetX;

    private bool _rightMove; 
    private bool _leftMove;

    void Update()
    {
       
        RightMove();
        LeftMove();
        
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                CheckAvaliableLeftMove();

            }
            if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                CheckAvaliableRightMove();

            }
        
    }



    public void CheckAvaliableLeftMove() //  С телефона вызываем этот метод ,когда касание в левой части экрана
    {
        if (transform.position.x == 0f)
        {
            _targetX = -2f;
            _leftMove = true;
        }
        if (transform.position.x == 2f)
        {
            _targetX = 0f;
            _leftMove = true;
        }
    }

    public void CheckAvaliableRightMove()   //  С телефона вызываем этот метод ,когда касание в правой части экрана
    {
        if (transform.position.x == 0f)
        {
            _targetX = 2f;
            _rightMove = true;
        }
        if (transform.position.x == -2f)
        {
            _targetX = 0f;
            _rightMove = true;
        }
    }

    private void RightMove()
    {
        if (_rightMove == true)
        {
            transform.eulerAngles = new Vector3(0, 30f, 0);
            float curentX = Mathf.MoveTowards(transform.position.x, _targetX, Time.deltaTime * 18f);
            transform.position = new Vector3(curentX, 0, transform.position.z);
        }
        if (transform.position.x == _targetX)
        {
            _rightMove = false;
            transform.eulerAngles = Vector3.zero;
        }


    }

    private void LeftMove()
    {
        if (_leftMove == true)
        {
            transform.eulerAngles = new Vector3(0, -30f, 0);
            float curentX = Mathf.MoveTowards(transform.position.x, _targetX, Time.deltaTime * 18f);
            transform.position = new Vector3(curentX, 0, transform.position.z);
        }
        if (transform.position.x == _targetX)
        {
            _leftMove = false;
            transform.eulerAngles = Vector3.zero;
        }
    }
}
