using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Example29 : MonoBehaviour
{

    private void Start()
    {
        int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };

        // arr 배열에 있는 모든 값을 for 반복문을 이용해서 출력하고 싶다.
        for (int j = 0; j < arr.Length; j++)
        {
            Debug.Log(arr[j]);
        }

        // foreach 반복문
        /**
            foreach (자료형 변수명 in 배열)
            {
                // 변수를 사용하는 코드
            }
         **/

        // foreach: 인덱스나 반복 횟수 신경 쓸 필요 없이 배열의 모든 요소에 접근할 수 있다.
        // 장점: 코드가 줄어든다. -> 가독성 향상
        // 단점:  각 요소의 값을 수정할 수 없다.

        foreach (int num in arr)
        {
            Debug.Log(num);
        }

        int i = 0;
        foreach (int num in arr)
        {
            Debug.Log(i);
            Debug.Log(num);
            i++;
        }
    }

}
