using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N0002_LifeCycle : MonoBehaviour
{


    // 当对象被创建的时候会触发，出生时只会用一次
    private void Awake()
    {
        // 没继承MonoBehaviour时
        Debug.Log("这是一个Awake中的log");
        // 继承了MonoBehaviour有一个线程
        print("这是一个Awake中的print");
    }


    // 当对象被激活是会被触发一次
    private void OnEnable()
    {
        print("这是一个OnEnable中的print");

    }


    // 当对象第一帧更新前的的操作
    private void Start()
    {
        print("这是一个start中的print");
    }



    //物理帧更新
    private void FixedUpdate()
    {
        print("这是一个FixedUpdate的print");

    }


    //逻辑帧更新
    private void Update()
    {
        print("这是一个Update中的print");

    }


    //在Update之后更新
    private void LateUpdate()
    {
        print("这是一个lateUpdate中的print");

    }

    // 位于帧更新之后的每次激活调用
    private void OnDisable()
    {
        print("这是一个onDisable中的print");

    }


    // 对象销毁前调用
    private void OnDestroy()
    {
        print("这是一个OnDestory中的print");

    }
}
