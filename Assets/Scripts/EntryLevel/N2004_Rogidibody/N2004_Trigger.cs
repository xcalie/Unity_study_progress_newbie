using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class N2004_Trigger : MonoBehaviour
{

    // 一般情况不会写public
    // 需要子类重写就带上protect或者虚类的关键字

    #region 检测函数

    // 只能由刚体触发

    // 触发开始的函数 当第一次接触时 会自动调用
    private void OnTriggerEnter(Collider other)
    {
        print(this.name + "被" + other.gameObject.name + "触发了");
    }

    // 触发结束的函数 当水乳相容状态结束时 会调用一次
    private void OnTriggerExit(Collider other)
    {
        print(this.name + "被" + other.gameObject.name + "结束触发了");

    }

    // 当两个对象 水乳相容的时候会持续调用
    private void OnTriggerStay(Collider other)
    {
        print(this.name + "和" + other.gameObject.name + "正在水乳相容");
    }

    #endregion

}
