using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;

public class N2001_Input2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #region 任意键

        if (Input.anyKey)
        {
            //print("任意键按住");

        }

        if (Input.anyKeyDown)
        {
            print(Input.inputString + "任意键按下");
        }

        // 这一帧的输入键
        //print(Input.inputString);

        #endregion

        #region 手柄输入

        //得到连接手柄的关键字
        string[] strs = Input.GetJoystickNames();

        //某一个手柄键长安
        if (Input.GetButton("Jump"))
        {

        }
        //某一个手柄键按下
        if (Input.GetButtonDown("Jump"))
        {

        }
        //某一个手柄键抬起
        if (Input.GetButtonUp("Jump"))
        {

        }

        #endregion

        #region 移动设备相关

        //触点检查
        if (Input.touchCount > 0)
        {
            Touch t1 = Input.touches[0];

            //位置
            print(t1.position);
            //相对上次位置的变化 滑动检查
            print(t1.deltaPosition);

        }

        // 是否启用多点触控
        Input.multiTouchEnabled = false;



        #endregion

        #region 陀螺仪相关

        //必须开启陀螺仪 才能使用
        Input.gyro.enabled = true;

        //重量加速度向量
        print(Input.gyro.gravity);

        //旋转速度
        print(Input.gyro.rotationRate);

        //陀螺仪 当前的旋转四元数
        // 比如 用这个角度信息 来控制 场景上的一个3D物体受到的重力影响
        // 手机怎么动 它怎么动
        print(Input.gyro.attitude);


        #endregion
    }
}
