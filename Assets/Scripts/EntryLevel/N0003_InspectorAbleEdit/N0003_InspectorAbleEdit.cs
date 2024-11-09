using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;


public enum E_TestEnum
{
    normal,
    player,
    monster,
}


[System.Serializable]
public class Myclass
{
    public int age;
    public int sex;
}


[System.Serializable]
public struct Mystruct
{
    public int age;
    public int sex;
}



public class N0003_InspectorAbleEdit : MonoBehaviour
{
    //Inspector可以在操作面板来操作
    // 私有和保护的无法显示编辑
    private int private1int;
    protected string protected1str;


    // 私有和保护的也可以显示
    // 加上强制序列化特性
    [SerializeField]
    private int private2int;
    [SerializeField]
    private string protected2str;


    // 公共的可以显示编辑
    public int public1int;
    public string public3str;


    // 公共的可以隐藏不能被编辑
    [HideInInspector]
    public int public2int;
    [HideInInspector]
    public string public2str;


    // 大部分类型都有显示编辑
    public int[] array;
    public List<int> list;
    public E_TestEnum type;
    public GameObject Gameobj;


    // 字典不能被显示编辑
    public Dictionary<int, string> dic;

    //自定义变量类型不能显示编辑
    //加上强制序列化就可以编辑[System.Serializable]
    public Mystruct mystruct;
    public Myclass myclass;


    #region 辅助特性

    [Header("基础属性")]
    public int act1;
    public int def1;

    [Header("战斗属性")]
    public int act2;
    public int def2;

    // 空一行
    [Space()]
    // 浮标
    [Tooltip("闪避")]
    public int miss;

    // 滑条
    [Range(10, 100)]
    public int lucky;


    //多行显示字符串,不写默认3行
    [Multiline(5)]
    public string str1;


    //最少显示3行最多显示4行超过4行显示滚动条
    [TextArea(3,4)]
    public string str2;


    //为变量添加快捷方式ContextMenuItem
    //参数 1 按钮名
    //参数 2 对象名
    [ContextMenuItem("重置钱", "Test")]
    public int money;
    private void Test()
    {
        money = 99;
    }


    // 为方法添加的特性能够在Inspector中执行
    //[ContextMenu("参数函数")]
    [ContextMenu("哈哈哈哈")]


    // 为方法添加的特性能够在Inspector中执行
    //[ContextMenu("参数函数")]
    private void TestFun()
    {
        print("测试方法");

    }


    #endregion


    public int i = 200;
    // 为默认值，在挂载后不会在重置
    // 记录脚本测试过程的数值只能copy


    private void Start()
    {
        print(private2int);
        print(protected2str);
        print(public1int);
        print(public3str);

    }
}
