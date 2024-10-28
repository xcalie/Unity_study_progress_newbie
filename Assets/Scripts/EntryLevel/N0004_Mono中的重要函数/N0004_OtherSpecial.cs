using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N0004_OtherSpecial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 重要方法

        // 获取自己挂载的单个脚本，无则返回空
        N0004_OtherSpecial n0004 = this.GetComponent("N0004_OtherSpecial") as N0004_OtherSpecial;
        print(n0004);

        // 根据typeof获取
        n0004 = this.GetComponent(typeof(N0004_OtherSpecial)) as N0004_OtherSpecial;
        print(n0004);

        // 根据泛型获取,最好的不用二次转换
        n0004 = this.GetComponent<N0004_OtherSpecial>();
        print(n0004);



        // 多个脚本
        N0004_OtherSpecial[] array = this.GetComponents<N0004_OtherSpecial>();
        print(array.Length);


        List<N0004_OtherSpecial> list = new List<N0004_OtherSpecial>();
        this.GetComponents<N0004_OtherSpecial>(list);
        print(list.Count);



        // 会从自身开始遍历！！！

        // 对到子对象挂载的脚本
        // 默认为false子对象失活不会寻找
        // true如果子对象失活也会寻找
        N0004_MonoBehaviourSpecial n0004Son = this.GetComponentInChildren<N0004_MonoBehaviourSpecial>(true);
        print(n0004Son);

        // 包含检查自身！！
        N0004_OtherSpecial[] n0004Sons = this.GetComponentsInChildren<N0004_OtherSpecial>(true);
        print(n0004Sons.Length);


        // 对到父对象挂的脚本
        N0004_OtherSpecial n0004Fa = this.GetComponentInParent<N0004_OtherSpecial>(true);
        print(n0004Fa);


        // 尝试获取某个脚本，更加安全
        N0004_OtherSpecial n0004Save;
        if (this.TryGetComponent<N0004_OtherSpecial>(out n0004Save))
        {
            print(n0004Save);
        }

        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
