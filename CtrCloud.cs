using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CtrCloud : MonoBehaviour
{
    [SerializeField]
    Move move;
    // Update is called once per frame
    void Update()
    {
        move.Direction = new Vector3(1f,0f,0f);
    }
}
