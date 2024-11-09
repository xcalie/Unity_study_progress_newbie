using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N1005_Transform : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        #region 位移

        // 自行计算
        // 用当前的位置 + 移动的距离 = 最终所在的位置
        
        // 用了forward就会朝着对应的方向去移动
        //this.transform.position += this.transform.forward * 1 * Time.deltaTime;

        // API
        // 参数一 表示位移多少 路程 = 方向 * 速度 * 时间
        // 参数二 表示相对坐标系 默认 该参数是相对于自己的坐标系移动

        // 相对于世界坐标系的 Z轴移动
        //this.transform.Translate(Vector3.forward * 1 * Time.deltaTime, Space.World);

        // 相对于世界坐标 自己的面朝去动
        this.transform.Translate(this.transform.forward * 1 * Time.deltaTime, Space.World);

        // 相对于自己坐标系下 自己的面朝方向去动（不会使用）
        //this.transform.Translate(this.transform.forward * 1 * Time.deltaTime, Space.Self);

        // 相对于自己坐标系下的 下的Z轴正方向移动 始终朝自己的朝向移动
        //this.transform.Translate(Vector3.forward * 1 * Time.deltaTime, Space.Self);



        #endregion
    }
}
