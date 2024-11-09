using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N2002_Screen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 静态属性

        #region 常用

        // 当前屏幕分辨率
        Resolution r =Screen.currentResolution;
        print("当前屏幕分辨率  宽" + r.width + "高" + r.height);

        // 当前窗口宽高
        // 这得到的 是当前的 窗口的宽高 不是设备分辨率的宽高
        // 一般写代码用当前宽高 用于做计算
        print(Screen.width);
        print(Screen.height);

        // 屏幕休眠模式
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        // 一般用于手机

        #endregion

        #region 不常用

        // 运行时是否全屏模式
        Screen.fullScreen = true;
        // 窗口模式 一般在发布的时候设置，可以通过代码设置
        // 独占全屏 FullScreenMode.ExclusiveFullScreen
        // 全屏窗口 FullScreenMode.FullScreenWindow
        // 最大化窗口 FullScreenMode.MaximizedWindow
        // 窗口模式 FullScreenMode.Windowed
        Screen.fullScreenMode = FullScreenMode.Windowed;

        #region 移动设备选择屏幕

        // 允许选择到左  home键在左  横向
        Screen.autorotateToLandscapeLeft = true;
        // 允许选择到右  home键在右  横向
        Screen.autorotateToLandscapeRight = true;
        // 允许旋转到下  home键在下  正向
        Screen.autorotateToPortrait = true;
        // 允许旋转到上  home键在上  倒向
        Screen.autorotateToPortraitUpsideDown = true;


        //指定方向
        Screen.orientation = ScreenOrientation.Portrait;
        // Landscape   Left/Right/...

        #endregion


        #endregion

        #endregion

        #region 静态方法

        //设置分辨率 不适用移动设备
        // 第三个 为确定 是否全屏
        Screen.SetResolution(1980, 1080, false);


        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
