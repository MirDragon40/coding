using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example39 : MonoBehaviour
{
    // 값에 의한 전달 (Call by Value)
    // - 변수나 상수로부터 값을 복사해서 전달.

    // 참조에 의한 전달 (Call by Reference)
    // - 값을 복사하는 것이 아닌 원본 변수를 참조(비추어 보다.)
    // - 원본 변수를 참조 중이므로 값을 변경하면 원본 변수의 값도 변경된다.
    // - 사용 방법: 매개 변수 앞에 ref 키워드 사용.
    void Swap(ref int num1, ref int num2)
    {
        int tempNum = num1;
        num1 = num2;
        num2 = tempNum;

    }
    
    // ref 키워드는 함수 내부에서 원본 변수의 값을 수정하지 않아도 되지만
    // out 키워드는 함수 내부에서 원본 변수의값을 수정해야 한다.
    // out은 ref와 비슷하지만 개발자의 실수를 줄여준다. -> 어떤 경우에?

    void Test(out int num)   // 실수를 줄여준다.
    {
       num = 3;
    }

    void Start()
    {
        int num1 = 3;
        int num2 = 9;

        Debug.Log($"바뀌기 전: num1 = {num1}, num2 = {num2}");

        Swap(ref num1, ref num2);  // reference(참조하다) 에서 따온 'ref'
                                   
                                   // 'ref'는 값을 가지고있는 것이 아니라 다른 값을 참조.
                                   // C언어에서는 ref를  point라고 부른다.


        //int[] nums = { num1, num2 };
        //num1 = nums[1];
        //num2 = nums[0];

        Debug.Log($"바뀐 후: num1 = {num1}, num2 = {num2}");

        Test(out num1);
    }

}
