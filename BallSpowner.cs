using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallSpowner : MonoBehaviour
{
    [SerializeField]
    private GameObject ball;

    [SerializeField]
    private GameObject ballSpownButton;

    public void MakeBall()
    {
        Instantiate(ball, new Vector3(0, 0, 0), Quaternion.identity);
        ballSpownButton.SetActive(false);
    }


}
