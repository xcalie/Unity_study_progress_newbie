using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N3001_Music : MonoBehaviour
{
    AudioSource audioSource;

    public GameObject Obj;

    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();

        #region 播放

        // 1 直接挂载播放

        // 2 实例化播放
        // 用的较少
        //Instantiate(Obj);

        // 3 用一个AudioSource来控制播放不同的音效
        AudioSource aus = this.gameObject.GetComponent<AudioSource>();
        aus.clip = clip;
        aus.Play();

        // 一个GameObject可以挂载多个音效脚本
        // 需要去管理

        #endregion

    }

    // Update is called once per frame
    void Update()
    {
        #region 代码控制播放与停止

        if (Input.GetKeyDown(KeyCode.P))
        {
            // 播放
            audioSource.Play();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            // 延迟播放4秒
            audioSource.PlayDelayed(4);
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            // 停止
            audioSource.Stop();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 暂停
            audioSource.Pause();
        }

        if (Input.GetKeyDown (KeyCode.LeftShift))
        {
            //停止暂停 和 暂停后Play效果相同
            audioSource.UnPause();
        }

        #endregion

        #region 检查应用是否处于播放

        // 只能在update中检测
        if (audioSource.isPlaying)
        {
            print("正在播放");
        }
        else
        {
            print("不在播放");

        }

        #endregion
    }
}
