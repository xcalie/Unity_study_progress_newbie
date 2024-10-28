using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N1002_Static : MonoBehaviour
{
    // 准备克隆的对象
    // 1 直接说某个场景上的对象
    // 2 可以是预设体对象
    public GameObject MyObj;


    // Start is called before the first frame update
    void Start()
    {
        #region 单个对象

        // GameObject
        // 创建自带几何体
        // 得到一个对象就可以得到挂载的任何脚本信息
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj.name = "被创建的方块";



        //查找对象相关的知识

        //查找单个对象
        // 两种方法的共同点
        //1 找不到失活的对象只能找激活的对象

        //2 如果存在多个满足条件的对象
        //  则无法确定结果

        //通过对象名查找，效率较低，会通过整个场景去找
        //没有找到返回null
        GameObject obj2 = GameObject.Find("被创建的方块");
        if (obj2 != null)
        {
            print(obj2.name);
        }
        else
        {
            print("没有找到对象");

        }

        // 通过 tag找对象 FindWithTag同样只是名字不一样
        GameObject obj3 = GameObject.FindGameObjectWithTag("Player");
        if (obj3 != null)
        {
            print(obj3.name);
        }
        else
        {
            print("没有找到对象");
        }

        // 1 public
        // 2 API


        #endregion

        #region 多个对象

        // 只能通过tag去找，无法通过名字查找
        // 只能找到激活对象
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Player");
        print(objs.Length);

        // 这个是用的比较少的方法为Object的方法
        // Unity中的Object实在UnityEngine的命名空间里的
        // C#中的object是在System中的
        // 效率更低不仅遍历对象，还会遍历其挂载的脚步

        //N0004_MonoBehaviourSpecial o = GameObject.FindObjectOfType<N0004_MonoBehaviourSpecial>();
        //print(o.gameObject.name);

        #endregion

        #region 实例化对象（克隆）

        // 创建应该克隆化对象
        // 创建应该一模一样的对象
        GameObject obj5 = GameObject.Instantiate(MyObj);

        // 继承了MonoBehavior可以不用写GameObject
        //GameObject obj6 = Instantiate(myObj);


        #endregion

        #region 删除对象

        // 删除，单个变量会直接删除，加上参数延迟删除
        //GameObject.Destroy(obj, 5);
        //GameObject.Destroy(obj5, 2);
        // 可以删除脚本
        //GameObject.Destroy(this.gameObject, 3);

        // destroy不会马上删除,打上删除标记后在下一帧进行删除
        // 有助于避免卡顿

        // 有可以立刻删除的方法
        //GameObject.DestroyImmediate(obj2);


        // 默认情况下 在切换场景式对象都会被自动删除掉
        // 过场景不移除，在过场景填入以下内容不会删除
        GameObject.DontDestroyOnLoad(obj5);
        

        #endregion

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
