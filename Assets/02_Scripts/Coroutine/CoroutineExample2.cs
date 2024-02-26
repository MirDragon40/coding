using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineExample2 : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Timer_Coroutine(3));

    }

    // 코루틴을 너무 많이쓰면 추적이 어려워진다. 
    private IEnumerator Timer_Coroutine(float delayTime)
    {
        int count = 10;

        // 주어진 시간만큼 대기
        // while 정해진 횟수가 정확하지 않을 때.
        while (true)
        {
            yield return new WaitForSeconds(delayTime);

            Debug.Log("딩동댕동");

            count--;

            if (count <= 0)
            {
                yield break;
            }

        }


    }
}
