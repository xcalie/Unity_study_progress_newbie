using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N1009_addressChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 世界坐标系转本地坐标

        print(Vector3.forward);
        //世界坐标系的点 转换为相对本地坐标系的点
        //受到缩放影响
        print("转换后的点" + this.transform.InverseTransformPoint(Vector3.forward));

        //时间坐标系的点 转换为相对本地坐标系的点
        //不受到缩放影响
        print("转换后的方向" + this.transform.InverseTransformDirection(Vector3.forward));


        #endregion


        #region 本地坐标转为世界坐标

        //本地坐标系的点 转为 世界坐标的点 受到缩放影响
        print("本地 转 世界 的 点" + this.transform.TransformPoint(Vector3.forward));

        //本地 转 世界 坐标系的点 不受缩放影响
        print("本地 转 世界 的 方向" + this.transform.TransformDirection(Vector3.forward));

        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
