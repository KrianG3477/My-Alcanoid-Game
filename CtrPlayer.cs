using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CtrPlayer : MonoBehaviour
{
    [SerializeField]
    Move move;

    private bool isLeftMove = false;
    private bool isRihtMove = false;

    public bool IsLeftMove { get => isLeftMove; set => isLeftMove = value; }
    public bool IsRihtMove { get => isRihtMove; set => isRihtMove = value; }


    void Update()
    {
        // PC 에서의 조작
        move.Direction = new Vector2(0f + ((Input.GetKey(KeyCode.RightArrow) ? 1f : 0f)
            - (Input.GetKey(KeyCode.LeftArrow) ? 1f : 0f)), 0f);

        // 버튼으로의 조작
        move.Direction = new Vector2(0f + (isRihtMove ? 1f : 0f) - (isLeftMove ? 1f : 0f), 0f);
    }


}
