using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHeart : MonoBehaviour
{
    private int heart = 3;

    public int Heart { get => heart; set => heart = value; }

    [SerializeField]
    private GameObject hp1Heart;
    [SerializeField]
    private GameObject hp2Heart;
    [SerializeField]
    private GameObject hp3Heart;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
