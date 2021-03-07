using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    private bool isUseSound = true;

    [SerializeField]
    private GameObject soundOn;
    [SerializeField]
    private GameObject soundOff;

    public bool IsUseSound { get => isUseSound;}

    void Start()
    {

    }

    void Update()
    {
        
    }

    public void TouchSoundButton()
    {
        isUseSound = !isUseSound;

        if (isUseSound)
        {
            soundOn.SetActive(true);
            soundOff.SetActive(false);
        }
        else
        {
            soundOn.SetActive(false);
            soundOff.SetActive(true);
        }
    }


}
