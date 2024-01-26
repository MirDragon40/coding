using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class BinaryFileStreamExample : MonoBehaviour
{
    void Start()
    {
        // <���� ����>
        // 1. � ����? (������ ���)
        // 2. ��� �ٷ���ΰ�? (������ ���)
        FileStream fs = new FileStream("C:/Users/USER/Desktop/test.dat", FileMode.Create);
        // FileMode.Create: ������ ���ٸ� ���� �������ְ�, ������ ������.
        // .dat: ������(data)�� ���� ����ڰ� ������ �����Ͱ� ����ִ� ������ Ȯ����

        // <���� ����>
        // ���̳ʸ� ������ �� ���� "BinaryWriter" Ŭ���� ���
        BinaryWriter bw = new BinaryWriter(fs);
        bw.Write("Hello");   // 72 101 108 108 11
        bw.Write(593);       // 0010 
        bw.Close();

        // ����: ��ǻ�ʹ� �����͸� 0��1 ���� ���̳ʸ� ���·� ó���ϹǷ�
        // Binary�� ����ϸ� �޸𸮸� �� �� ȿ�������� ����ϰ�, �ӵ��� �� ������.

        // <���� �б�>
        // ���̳ʸ� ������ ���� ���� "BinaryRender" Ŭ���� ���
        fs = new FileStream("C:/Users/USER/Desktop/test.dat", FileMode.Open);   // �ٽ� ����
        BinaryReader br = new BinaryReader(fs);
        Debug.Log(br.ReadString());   
        Debug.Log(br.ReadInt32());
        br.Close();
    }
}
