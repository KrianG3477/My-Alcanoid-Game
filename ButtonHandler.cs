using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    [SerializeField]
    private PlayerManager ctrPlayer;

    public void LeftBtDoun()
    {
        ctrPlayer.IsLeftMove = true;
    }

    public void LeftBtUp()
    {
        ctrPlayer.IsLeftMove = false;
    }
    public void RihtBtDoun()
    {
        ctrPlayer.IsRihtMove = true;
    }

    public void RihtBtUp()
    {
        ctrPlayer.IsRihtMove = false;
    }

}
