using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N1008_FatherSon : MonoBehaviour
{
    public Transform son;

    // Start is called before the first frame update
    void Start()
    {
        #region 设置断绝父对象

        // 获取父对象
        //print(this.transform.parent.name);
        // 设置父对象 断绝父子关系
        //this.transform.parent = null;
        // 设置父对象认父
        //this.transform.parent = GameObject.Find("N1008_Father2").transform;



        // 通过API获取
        //this.transform.SetParent(null);  //断绝父子关系
        //this.transform.SetParent(GameObject.Find("N1008_Father2").transform);

        // 子对象： 自身 +(*) 父对象的相关数值

        //参数一 ： 我的父亲
        //参数二 ： 是否保留世界坐标系数值
        //this.transform.SetParent(GameObject.Find("N1008_Father2").transform, true);
        //true会保留时间坐标的状态 通过对父对象的计算得到结果 

        //this.transform.SetParent(GameObject.Find("N1008_Father2").transform, false);
        //false直接保留转态 在结果上会再加一次父对象的内容


        #endregion

        #region 抛妻弃子

        //只能断绝和子对象的关系， 不能断绝儿子和孙子间的关系
        //this.transform.DetachChildren();

        #endregion

        #region 获取子对象

        //按名字查找儿子
        //找到儿子的transform返回
        //Find方法能够找到失活的儿子！！ gameObject不能找到失活的儿子！！
        //print(this.transform.Find("N1008_Son").name);
        //找不到孙子
        //print(this.transform.Find("N1008_GrandSon").name);


        //遍历儿子
        //失活的儿子也会算数量
        //找不到孙子 所以孙子不会算数量
        print(this.transform.childCount);

        //通过索引号 去得到自己的儿子
        //如果编号 超出自己儿子的数量范围 会直接报错的
        // 返回值 是 transform 可以得到儿子的相关信息
        // 儿子超出范围会报错
        this.transform.GetChild(0);

        for (int i = 0; i < this.transform.childCount; i++)
        {
            print(  i + " 儿子的名字：" + this.transform.GetChild(i));

        }


        #endregion

        #region 儿子的操作

        //判断儿子的父亲是谁
        if (son.IsChildOf(this.transform))
        {
            print("是我的儿子");

        }
        else
        {
            print("不是我的儿子");

        }

        //得到自己儿子的编号
        print(son.GetSiblingIndex());

        //把自己设置为第一个儿子
        //son.SetAsFirstSibling();

        //把自己设置为最后一个儿子
        //son.SetAsLastSibling();

        //把自己设在某个索引号下，不能超出
        son.SetSiblingIndex(2);

        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
