using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{
//	Object to move
    public GameObject Player;

//    start position
    private Vector3 _startPos;

//  end position
    private Vector3 _endPos;

//  distance
    private readonly float distance = 30f;

//  duration
    private readonly float duration = 5;

//    this will update lerp time
    private float _currentLerpTime = 0;


    // Use this for initialization
    private void Start()
    {
        _startPos = Player.transform.position;
        _endPos = Player.transform.position + Vector3.left * distance;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _currentLerpTime += Time.deltaTime;
            if (_currentLerpTime >= duration)
            {
                _currentLerpTime = duration;
            }
//            var Perc = _currentLerpTime / duration;
            Player.transform.position = Vector3.Lerp(_startPos, _endPos, duration);
        }
    }
}