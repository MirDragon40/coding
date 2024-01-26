using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;   // input, output�� ����

// ���Ͻ�Ʈ��
// ������ �ٷ� �� �����Ͱ� �����̴� ���� �帧(Stream)���� ������ ��
// ������ �ٷ�� ���ؼ��� System.io ���ӽ����̽��� �ִ� FileStream Ŭ���� ���


public class TextFileStreamExample : MonoBehaviour
{
    // 
    // Start is called before the first frame update
    void Start()
    {
        // <������ ����>


        // �Ű�����
        // 1. � ����? (������ ���)
        // 2. ��� �ٷ���ΰ�? (������ ���)
        FileStream fs = new FileStream("C:/Users/USER/Desktop/test.txt", FileMode.Create);
        // FileMode.Create: ������ ���ٸ� ���� �������ְ�, ������ ������.

        // <�ؽ�Ʈ ����>
        // �ؽ�Ʈ ������ �� ���� "StreamWriter"Ŭ���� ���
        StreamWriter sw = new StreamWriter(fs);
        sw.WriteLine("�ȳ��ϼ���");
        sw.WriteLine("�� �̸��� �������Դϴ�..");
        sw.WriteLine("������ �ݰ�����");
        sw.Close();    // ������ ��� ������ �ٽ� �ݾ��־�� ��.

        // <���� �б�>
        fs = new FileStream("C:/Users/USER/Desktop/test.txt", FileMode.Open);    // ������ �ݾ����� �ٽ� �����־�� �Ѵ�.
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
