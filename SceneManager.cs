using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Manager = UnityEngine.SceneManagement.SceneManager;


public class SceneManager : MonoBehaviour
{
    //���̵� ���.
    public void GoToScene(int n) 
    {
        Manager.LoadScene(n);
    }
}
