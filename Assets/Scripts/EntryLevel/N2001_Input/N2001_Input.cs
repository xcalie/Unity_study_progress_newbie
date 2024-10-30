using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N2001_Input : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 输入在update中更新

        #region 鼠标在屏幕的位置

        //print(Input.mousePosition);

        #endregion

        #region 鼠标相关检测

        // 鼠标按下一瞬间进入
        // 左0 右1 中2 
        if (Input.GetMouseButtonDown(0))
        {
            print("鼠标的左键按下来了");
        }


        // 鼠标抬起一瞬间进入
        // 左0 右1 中2 
        if (Input.GetMouseButtonUp(0))
        {
            print("鼠标的左键抬起来了");

        }

        // 抬起 按下都会进入 长按会一直进入
        if (Input.GetMouseButton(1))
        {
            print("右键按住了");
        }


        // 中键滚动
        // 返回值为y的 -1 往下滚   0 没有滚  1 往上滚
        // 它的返回值 是Vector的值 我们鼠标中建的滚动会改变值
        //print(Input.mouseScrollDelta);


        #endregion

        #region 键盘相关检查

        //键盘按下
        if (Input.GetKeyDown(KeyCode.S))
        {
            print("s按下");

        }

        // 传入字符串的重载
        // 这里传入的 字符串 不能是大写的 不建议使用 不好记
        if (Input.GetKeyDown("q"))
        {
            print("q键按下");

        }

        // 抬起
        if (Input.GetKeyUp(KeyCode.Space))
        {
            print("空格抬起");
        }

        if (Input.GetKey(KeyCode.W))
        {
            print("w");
        }



        #endregion

        #region 检测默认轴输入

        // 更方便的控制玩家的 选择 位移

        // AD键 -1~1
        print(Input.GetAxis("Horizontal"));

        // SW键 -1~1
        print(Input.GetAxis("Vertical"));

        // 鼠标横向运动 -1~1 左右
        print(Input.GetAxis("Mouse X"));

        // 鼠标竖向运动 -1~1 下上
        print(Input.GetAxis("Mouse Y"));

        //GetAxis是动态的值
        //GetAxisRaw方法只有-1 0 1三个值，不是动态的

        #endregion
    }
}
