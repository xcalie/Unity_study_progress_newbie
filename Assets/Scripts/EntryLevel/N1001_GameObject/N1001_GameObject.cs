using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N1001_GameObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        #region 查询本脚本挂载的名

        //名字
        print(this.gameObject.name);
        this.gameObject.name = "N10001更名";
        print(this.gameObject.name);
        //是否激活
        print(this.gameObject.activeSelf);
        //是否是静态
        print(this.gameObject.isStatic);
        //层级
        print(this.gameObject.layer);
        //标签
        print(this.gameObject.tag);
        //transform
        //this.transform通过Mono得到依附的GameObject的位置信息
        //得到的信息是一样的
        print(this.gameObject.transform.position);

        #endregion

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
