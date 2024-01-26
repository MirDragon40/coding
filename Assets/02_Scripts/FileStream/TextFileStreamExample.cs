using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;   // input, output의 약자

// 파일스트림
// 파일을 다룰 때 데이터가 움직이는 것을 흐름(Stream)으로 비유한 것
// 파일을 다루기 위해서는 System.io 네임스페이스에 있는 FileStream 클래스 사용


public class TextFileStreamExample : MonoBehaviour
{
    // 
    // Start is called before the first frame update
    void Start()
    {
        // <파일을 연다>


        // 매개변수
        // 1. 어떤 파일? (파일의 경로)
        // 2. 어떻게 다룰것인가? (파일의 모드)
        FileStream fs = new FileStream("C:/Users/USER/Desktop/test.txt", FileMode.Create);
        // FileMode.Create: 파일이 없다면 새로 생성해주고, 있으면 덮어씌운다.

        // <텍스트 쓰기>
        // 텍스트 파일을 쓸 때는 "StreamWriter"클래스 사용
        StreamWriter sw = new StreamWriter(fs);
        sw.WriteLine("안녕하세요");
        sw.WriteLine("제 이름은 정수빈입니다..");
        sw.WriteLine("만나서 반가워용");
        sw.Close();    // 파일을 열어서 쓰고나면 다시 닫아주어야 함.

        // <파일 읽기>
        fs = new FileStream("C:/Users/USER/Desktop/test.txt", FileMode.Open);    // 파일을 닫았으니 다시 열어주어야 한다.
        StreamReader sr = new StreamReader(fs);

        while (true)
        {
            string line = sr.ReadLine();
            Debug.Log(line);
            if(line == null)
            {
                break;
            }
        }
        sr.Close();



    }

}
