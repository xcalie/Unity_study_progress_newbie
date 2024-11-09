using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N2004_Rogidbody : MonoBehaviour
{

    // 发生碰撞时会自动执行这个函数
    private void OnCollisionEnter(Collision collision)
    {
        // collision包含被碰撞的对象碰撞器的信息

        // 接触的碰撞器的信息
        // collision.collider 

        // 碰撞对象所依附的对象
        // collision.gameObject

        // 碰撞对象的位置信息
        // collision.transform

        // 碰撞点数相关
        // collision.contactCount
        // 接触点的具体坐标
        // ContactPoint[] pos = collision.contacts;

        print(this.name + "被" + collision.collider.name + "撞到了");
    }

    // 碰撞结束分离时 会自动执行的函数
    private void OnCollisionExit(Collision collision)
    {
        print(this.name + "与" + collision.collider.name + "分离了");

    }

    //两个物体相互摩擦的时候会调用的函数
    //静止不会发生
    private void OnCollisionStay(Collision collision)
    {
        print(this.name + "与" + collision.collider.name + "一直接触");

    }
}
