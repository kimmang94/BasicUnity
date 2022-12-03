using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    void Awake()
    {
        Debug.Log("Awake 함수 실행!");
    }

    void OnEnable()
    {
        Debug.Log("OnEnable 함수 실행!");
    }

    void Start()
    {
        Debug.Log("Start 함수 실행!");
    }
    
    
    void Update()
    {
        Debug.Log("Update 함수 실행!");
    }
    void FixedUpdate()
    {
        Debug.Log("FixedUpdate 함수 실행!");
    }

    void LateUpdate()
    {
        Debug.Log("LateUpdate 함수 실행!");
    }

    void OnDisable()
    {
        Debug.Log("OnDisable 함수 실행!");
    }
}
