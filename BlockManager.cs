using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    [SerializeField]
    private Transform myTransform;
    [SerializeField]
    private float goDown = 5f;

    private Vector3 targetPosition = Vector3.zero ;

    public void GoDown()
    {
        targetPosition =
            new Vector3(myTransform.position.x, myTransform.position.y - goDown, myTransform.position.z);

        StartCoroutine(MoveDown());
    }
    private IEnumerator MoveDown()
    {
        int count = 0;

        while (true)
        {
            count++;

            myTransform.position = new Vector3
                (0f, Mathf.Lerp(myTransform.position.y, targetPosition.y, Time.deltaTime * 3f), 0f);

            // 1000프레임이 지나면 탈출
            if (count > 1000)
                break;
            // 1프레임 넘김
            yield return null;
        }

        myTransform.position = targetPosition;
    }
}
