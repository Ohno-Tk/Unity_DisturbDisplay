using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private const int SECONDS = 60; // 秒
    private float CountTime = 0; // カウントアップ用の変数
    private int MaxTime = 1;
    private int MinutesTime = 0;
    private bool StopFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        MinutesTime = MaxTime * SECONDS;
    }

    // Update is called once per frame
    void Update()
    {
        if(StopFlag){return;}

        if(CheckOverTime())
        {
            CountTime = 0;
            StopFlag = true;
            return;
        }

        CountTime += Time.deltaTime;

        Debug.Log("タイマー：" + (int)CountTime);
    }

    //
    public bool GetStopFlag()
    {
        return StopFlag;
    }

    // タイマーチェック
    private bool CheckOverTime()
    {
        if( MinutesTime < (int)CountTime)
        {
            Debug.Log("上限超えたよ～");
            return true;
        }

        return false;
    }
}
