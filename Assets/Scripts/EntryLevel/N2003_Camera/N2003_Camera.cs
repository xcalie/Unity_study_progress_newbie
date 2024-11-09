using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N2003_Camera : MonoBehaviour
{
    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        #region 静态参数

        // 获取摄像机
        
        // 主摄像机，场景上必须有一个标签为 MainCamera 的摄像机
        print(Camera.main.name);
        // 获取数量
        print(Camera.allCamerasCount);
        // 得到所有摄像机
        Camera[] cameras = Camera.allCameras;
        print(cameras.Length);

        // 渲染相关委托
        // 摄像机剔除处理之前的委托函数
        Camera.onPreCull += (c) =>
        {

        };
        // 渲染前处理的委托
        Camera.onPreRender += (c) =>
        {

        };
        // 渲染后处理的委托
        Camera.onPostRender += (c) =>
        {

        };


        #endregion

        #region 重要成员

        // 界面上的参数 都可以在 camera中获取到
        // 如下
        Camera.main.depth = 10;

        // 世界坐标系转屏幕坐标系 x,y对应屏幕的坐标  z 对应3D物品在摄像机有多远
        Vector3 v = Camera.main.WorldToScreenPoint(this.transform.position);
        print(v);
        
        // 屏幕坐标转世界坐标
        // 在update写

        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        // 屏幕坐标转世界坐标
        // print(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        Vector3 v = Input.mousePosition;
        v.z = 5;
        obj.transform.position = Camera.main.ScreenToWorldPoint(v);
    }
}
