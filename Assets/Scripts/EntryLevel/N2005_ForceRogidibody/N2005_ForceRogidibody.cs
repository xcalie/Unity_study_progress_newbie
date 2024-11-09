using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N2005_ForceRogidibody : MonoBehaviour
{

    Rigidbody rgb;

    // Start is called before the first frame update
    void Start()
    {
        #region API

        // 给刚体加力的目的是 使其有一个速度 进行移动

        // 在start上加的只推了一下，持续推需要再update力实现

        // 首先获取刚体组件
        rgb = this.GetComponent<Rigidbody>();

        // 添加力
        // 相对世界坐标
        // 世界坐标系对于z轴施加一个力
        // 加力之后 对象是否移动 是由阻力决定的
        // 如果阻力为0 则不会停止运动
        //rgb.AddForce(Vector3.forward * 100);

        // 对本地坐标系的z方向推一下
        //rgb.AddRelativeTorque(this.transform.forward * 100);


        // 世界扭矩力
        //rgb.AddTorque(Vector3.left * 1000);

        // 本地扭矩力
        //rgb.AddRelativeTorque(this.transform.up * 100);


        // 直接改变速度
        //rgb.velocity = Vector3.forward * 100;


        // 模拟爆炸效果
        // 如果要对其他物体产生影响就给所有对象加上
        rgb.AddExplosionForce(100, Vector3.zero, 10);

        #endregion

        #region 力的几种模式

        // 第二个参数可以给出计算方式
        rgb.AddForce(Vector3.forward * 10, ForceMode.Acceleration);

        // 最好使用force 所有数据都会参与

        // 动量定理
        // Ft = mv
        // v = Ft / m
        // F:力
        // t:时间
        // m:质量
        // v:速度


        // Acceleration
        // 给物体加一个持续的加速度，忽略其质量
        // v = Ft / m
        // F:(0,0,10)
        // t:0.02s
        // m:默认为1
        // v = 10 * 0.02 / 1  = 0.2m/s
        // 每一帧物理帧移动0.2m/s * 0.02 = 0.004m

        // Force
        // 给物体添加一个持续的力，与物体质量相关
        // v = Ft / m
        // F:(0,0,10)
        // t:0.02s
        // m:2kg    
        // v = 10 * 0.02 / 2 = 0.1m/s
        // 每帧移动0.1m/s * 0.02 = 0.002m

        // Impulse
        // 给物体添加一个瞬间的力，与物体质量有关，忽略时间 默认为1
        // v = Ft / m
        // F:(0,0,10)
        // t:默认为1
        // m:2kg
        // v = 10 * 1 / 2 = 5m/s
        // 每帧物理移动5m/s * 0.02 = 0.1m

        // VelocityChange
        // 给物体一个瞬时速度，忽略质量，忽略时间
        // v = Ft / m
        // F:(0,0,10)
        // t:默认为1
        // m:默认为1
        // v = 10 * 1 / 1 = 10m/s
        // 每帧物理帧更新 10m/s * 0.02 = 0.2m


        #endregion

        #region 刚体的休眠

        // 休眠会导致刚体不计算
        // 可以在update中判断是否休眠通过这个形式起床
        if (rgb.IsSleeping())
        {
            rgb.WakeUp();
        }

        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        // 脚本中Constant Force为固定的力输出 更方便添加力
        // 在start上加的只推了一下，持续推需要再update力实现
    }
}
