using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N1007_ScaleTool : MonoBehaviour
{
    public Transform lookAtObj;

    // Start is called before the first frame update
    void Start()
    {
        #region 缩放

        // 相对世界坐标系
        print(this.transform.lossyScale);

        // 相对本地坐标系
        print(this.transform.localScale);

        //注意：
        // 缩放不能只改xyz 只能一起改(相对于世界坐标系的缩放大小只能得 不能该)
        // 一般改缩放大小 只能改相对于 父对象的 缩放大小 localScale
        this.transform.localScale = new Vector3(3, 3, 3);


        // Unity没有缩放的API
        // 之前的旋转 位移 都提供的对应的API 但是 缩放没有
        // 如果要让 缩放 变化必须自己写

        #endregion

    }

    // Update is called once per frame
    void Update()
    {
        // Unity没有缩放的API
        // 之前的旋转 位移 都提供的对应的API 但是 缩放没有
        // 如果要让 缩放 变化必须自己写

        //this.transform.localScale += Vector3.one * Time.deltaTime;



        #region 看向

        // 让一个物体看向某一个物体 对象
        // 看向一个点为 相对于世界坐标系的
        //this.transform.LookAt(Vector3.zero);

        // 看向一个对象 就传入的 Transform 的对象
        this.transform.LookAt(lookAtObj);

        #endregion
    }
}
