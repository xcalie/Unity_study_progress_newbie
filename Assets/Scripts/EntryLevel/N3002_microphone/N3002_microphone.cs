using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N3002_microphone : MonoBehaviour
{
    AudioClip clip;


    // Start is called before the first frame update
    void Start()
    {
        #region 获取麦克风信息

        string[] strs = Microphone.devices;
        for (int i = 0; i < strs.Length; i++)
        {
            print(strs[i]);

        }

        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        #region 开始录制

        // 参数一：设备名 传空用默认设备
        // 参数二：超过录制长度后是否重头录制
        // 参数三：录制时长
        // 参数四：采样率
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("开始录制");

            clip = Microphone.Start(null, false, 10, 44100);

        }



        #endregion


        #region 结束录制

        if (Input.GetKeyUp(KeyCode.Space))
        {
            print("结束录制");

            Microphone.End(null);
            // 第一次去获取没有才添加
            AudioSource s = this.GetComponent<AudioSource>();

            if (s == null)
            {
                s = this.gameObject.AddComponent<AudioSource>();
            }
            s.clip = clip;
            s.Play();

            #region 存储音频

            // 规则 用于储存数组数据的长度 是 声道数 * 剪辑长度
            float[] f = new float[clip.channels * clip.samples];
            clip.GetData(f, 0);
            print(f.Length);

            #endregion

        }

        #endregion
    }
}
