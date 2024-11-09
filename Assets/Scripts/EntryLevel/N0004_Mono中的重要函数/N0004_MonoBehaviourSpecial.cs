using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class N0004_MonoBehaviourSpecial : MonoBehaviour
{

    public N0004_OtherSpecial otherN0004;

    // Start is called before the first frame update
    void Start()
    {
        #region 重要成员

        // 获取挂载的gameObject
        print(this.gameObject.name);
        // 获取依附的GameObject的位置信息
        print(this.transform.position);//位置
        print(this.transform.eulerAngles);//角度
        print(this.transform.lossyScale);//缩放大小


        // 获取脚本是否激活
        //this.enabled = false;
        //这里将脚本失活以下生命周期函数都不会进行


        print(otherN0004.gameObject.name);
        print(otherN0004.transform.position);


        #endregion


        #region 其他方法


        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
