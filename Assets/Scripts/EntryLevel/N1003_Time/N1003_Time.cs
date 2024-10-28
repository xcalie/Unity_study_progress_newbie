using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N1003_Time : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        #region 时间缩放比例

        // 不动
        //Time.timeScale = 0;
        // 一倍速
        Time.timeScale = 1;
        // 二倍速
        //Time.timeScale = 2;

        #endregion

        #region 帧间隔时间


        //帧间隔时间:最近一帧用了多长时间（秒）
        // 常常用于计算位移
        // 路程 = 时间*速度
        // 如果希望 游戏暂停时不移动用deltaTime
        // 如果希望 游戏暂停时移动用unscaledDeltaTime

        // 受Scale影响
        print("帧间隔时间受Scale影响" + Time.deltaTime);
        print("帧间隔时间不受Scale影响" + Time.unscaledDeltaTime);

        #endregion

        #region 游戏开始到现在的时间

        // 它主要用来计时
        // 受scale影响
        print("游戏开始到现在的时间" + Time.time);
        // 不受scale影响
        print("不受scale影响游戏开始到现在的时间" + Time.unscaledDeltaTime);

        #endregion

        #region 物理帧间隔时间 FixedUpdate

        // 受scale影响
        print(Time.fixedDeltaTime);
        // 不受scale影响
        print(Time.fixedUnscaledDeltaTime);
        // 可以在Project Setting中的time设置物理帧

        #endregion

        #region

        // 从开始到现在游戏跑了多少帧
        print(Time.frameCount);

        #endregion
    }
}
