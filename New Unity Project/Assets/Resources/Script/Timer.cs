using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private const int SECONDS = 60; // 秒
    [SerializeField]
    private float MaxTime = 1.0f;
    private int MinutesTime = 0;
    private float CountTime = 0; // カウントアップ用の変数
    private bool StopFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        MinutesTime = (int)(MaxTime * SECONDS);
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
        else
        {
            CountTime += Time.deltaTime;

            Debug.Log("タイマー：" + (int)CountTime);
        }
    }

    public void SetStopFlag(bool value)
    {
        StopFlag = value;
    }

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
