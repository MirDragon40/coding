using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTest : MonoBehaviour
{
    

    void Start()
    {
        // UnityEngine.Random 클래스: 난수 생성과 관련있는 클래스
        // 난수: 정의된 범위 내에서 무작위로 추출된 수 ( = 랜덤값 )


        // Debug.Log(UnityEngine.Random.Range(0, 1));
        // 처음 랜덤화를 통해 나온 숫자 ->  시드값
        // 두번째에 계산을 할 때에는 시드값에 알고리즘을 계산한다.
        UnityEngine.Random.InitState(13);
        Debug.Log(UnityEngine.Random.Range(0, 100));
        


    }
}
  