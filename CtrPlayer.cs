using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CtrPlayer : MonoBehaviour
{
    [SerializeField]
    Move move;
    // Update is called once per frame
    void Update()
    {
        move.Direction = new Vector2(0f + ((Input.GetKey(KeyCode.RightArrow) ? 1f : 0f)
            - (Input.GetKey(KeyCode.LeftArrow) ? 1f : 0f)), 0f);
    }
}
