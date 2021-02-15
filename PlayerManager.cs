using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField]
    private Move move;

    private float addDirect;

    private bool isLeftMove = false;
    private bool isRihtMove = false;

    public bool IsLeftMove { get => isLeftMove; set => isLeftMove = value; }
    public bool IsRihtMove { get => isRihtMove; set => isRihtMove = value; }


    void Update()
    {
        // PC + 버튼 조작
        move.Direction = new Vector2( AddDirect(), 0f);
    }

    private float AddDirect()
    {
        addDirect = (Input.GetAxisRaw("Horizontal")) + ((isRihtMove ? 1f : 0f) - (isLeftMove ? 1f : 0f));
        return addDirect;
    }
}
