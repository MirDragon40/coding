using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

// 보간: 시작점과 끝점이 주어졌을 때 두 점 사이의 진행률(비율)에 따라 그 사이의 특정한 지점을 얻는 것
// 진행률(비율) -> 0 ~1 사이의 값
// 뭔가를 "부드럽게" 할 때 사용

// 선형보간(Lerp: Linear Interpolation) ->
// "직선": 균일한 속도로 이동시키거나 회전시킬 때 사용



public class LerpExample : MonoBehaviour
{
    public Transform Start;
    public Transform End;

    public float Duration = 3f;


    private float _progress;   // 진행률: 0 ~ 1

    private bool _isMovingRight = true;     // _startToEnd


    // 교재 188p
    void Update()
    {
        _progress += Time.deltaTime / Duration;

        /*
        if (_isMovingRight)
        {
            _progress += Time.deltaTime / Duration;
            transform.position = Vector3.Lerp(Start.position, End.position, _progress);
            if (_progress >= 1)
            {
                _progress = 1;
                _isMovingRight = false;
            }
        }
        else
        {
            _progress -= Time.deltaTime / Duration;
            transform.position = Vector3.Lerp(Start.position, End.position, _progress);
            if (_progress <= 0)
            {
                _progress = 0;
                _isMovingRight = true;
            }
        }
        */

        if (_isMovingRight )
        {
            transform.position = Vector3.Lerp(Start.position, End.position, _progress);
        }
        else
        {
            transform.position = Vector3.Lerp(End.position, Start.position, _progress);
        }
        if (_progress > 1)
        {
            _progress = 0;
            _isMovingRight = !_isMovingRight;
        }

    }
}