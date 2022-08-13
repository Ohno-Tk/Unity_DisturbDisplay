using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private const int SECONDS = 60; // 秒
    [SerializeField]
    private int TimeRangeMin = 4; // ランダム範囲最小値
    [SerializeField]
    private int TimeRangeMax = 7; // ランダム範囲最大値
    [SerializeField]
    private float MaxTime = 0.1f;
    private int MinutesTime = 0; // 分計算用変数
    private float CountTime = 0; // カウントアップ用の変数
    private bool StopFlag = false;

    // Getter/Setter
    public bool GetSetStopFlag
    {
        get{return StopFlag;}
        set{StopFlag = value;}
    }

    // Start is called before the first frame update
    void Start()
    {
        StopFlag = false;
        //MinutesTime = (int)(MaxTime * SECONDS);
        ChangeMinutesTime();
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
        else if(Mathf.Approximately(Time.timeScale, 1f))
        {
            CountTime += Time.deltaTime;

            Debug.Log("タイマー：" + (int)CountTime);
        }
    }

    // ランダム要素で判定用の分タイムを変更する
    public void ChangeMinutesTime()
    {
        MaxTime = Random.Range(TimeRangeMin, TimeRangeMax+1);
        MinutesTime = (int)(MaxTime * SECONDS);

        Debug.Log("タイム判定変数更新したよ～" + (MinutesTime/SECONDS) + "分　" + MinutesTime + "秒");
    }

    // タイマー取得(分)
    public int GetTimeMinutes()
    {
        return (int)(MinutesTime/SECONDS);
    }

    // 現在のタイマー取得
    public int GetNowTime()
    {
        return (int)CountTime;
    }

    // タイマーチェック
    private bool CheckOverTime()
    {
        if( MinutesTime < (int)CountTime)
        {
            Debug.Log("タイム超過したよ～");
            return true;
        }

        return false;
    }
}
