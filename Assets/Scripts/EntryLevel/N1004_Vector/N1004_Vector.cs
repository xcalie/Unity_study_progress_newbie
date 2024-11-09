using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N1004_Vector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region Vector3

        // Inspector上做坐标在有父子关系时是相对于父对象的位置
        // Vector3主要用来表示三维坐标系中的一个点或者向量
        // 声明

        Vector3 v1 = new Vector3();
        v1.x = 10;
        v1.y = 10;
        v1.z = 10;

        // 只传x,y时，z默认零
        Vector3 v2 = new Vector3(10, 10);
        // 一步到位
        Vector3 v3 = new Vector3(10, 10, 10);

        // Vector基本计算
        // + - * /
        print(v1 + v2);
        print(v1 - v3);
        print(v2 * 10);
        print(v3 / 10);
        // 向量方向的叠加


        // 常用
        print(Vector3.zero);// 0 0 0 
        print(Vector3.right);// 1 0 0
        print(Vector3.left);// -1 0 0
        print(Vector3.forward);// 0 0 1
        print(Vector3.back);// 0 0 -1
        print(Vector3.up);// 0 1 0
        print(Vector3.down);// 0 -1 0;



        // 两个坐标之间的距离
        print(Vector3.Distance(v1, v2));


        #endregion

        #region transform

        // 相对于世界坐标系
        // this.gameobject.transform
        // 通过position得到位置为时间坐标系的
        //  如果存在父子关系，就会不一样
        print(this.gameObject.transform.position);

        // 为本地坐标，既Inspector上显示的坐标
        print(this.gameObject.transform.localPosition);
        // 当无父对象时两者一致,或者父对象为0 0 0 

        // 位置不能直接改变x y z只能整体改变
        this.transform.position = new Vector3(10, 10, 10);
        this.transform.localPosition = Vector3.up * 10;
        // 如果只想改变一个值要保存x y z一致
        // 直接赋值
        this.transform.position= new Vector3(19 , this.transform.position.y, this.transform.position.z);
        // 先取出来 再赋值
        Vector3 psi = this.gameObject.transform.position;
        psi.x = 22;
        this.gameObject.transform.position = psi;

        
        // 对象当前的正朝向
        // 对象当前的面朝向
        print(this.transform.forward);
        // 对象当前的头顶
        print(this.transform.up);
        // 同理 down back left right就是对应的

        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
