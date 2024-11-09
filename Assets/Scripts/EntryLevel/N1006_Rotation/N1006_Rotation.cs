using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N1006_Rotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 角度相关

        // 相对于世界坐标的角度
        print(this.transform.eulerAngles);
        
        // 相对于自身坐标的角度
        print(this.transform.localEulerAngles);


        // 注意：设置和角度位置一样 不能单独xyz 要一起设置
        // 如果我们希望改变的 角度 是面板上的内容 那一点改变 相对父对象的角度

        //this.transform.eulerAngles = new Vector3(10, 10, 10);
        print(this.transform.localEulerAngles);

        #endregion

    }

    // Update is called once per frame
    void Update()
    {

        #region 旋转相关

        // 自行计算 和 位置同理

        // API计算
        // 自传
        // 第一个参数 相当于 是选择的角度 每一帧
        // 第二个参数 默认不填 就是相对于自己的坐标系 进行的旋转
        //this.transform.Rotate(new Vector3(0, 10, 0) * Time.deltaTime, Space.Self);
        //this.transform.Rotate(new Vector3(0, 10 , 0) * Time.deltaTime, Space.World);


        //相对于某个轴 转多少度 
        // 参数一：是相对哪个轴进行转动
        // 参数二：是转动的 角度 是多少
        // 参数三：默认不填就是相对于自己的坐标系 进行选择
        //        如果填可以填写相对于 世界坐标系进行选择

        //this.transform.Rotate(Vector3.right, 10 * Time.deltaTime);
        //this.transform.Rotate(Vector3.right, 10 * Time.deltaTime, Space.World);

        //相对于某一个点转
        //参数一：相对于哪一个点 转圈圈
        //参数二：相对于那个点的 哪一个轴转
        //参数三：转动角度 * 速度 * 时间 
        this.transform.RotateAround(Vector3.zero, Vector3.up, 10 * Time.deltaTime);


        #endregion
    }
}
