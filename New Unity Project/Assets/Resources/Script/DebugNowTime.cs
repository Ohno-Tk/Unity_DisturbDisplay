using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugNowTime : MonoBehaviour
{
    [SerializeField]
    private GameObject TimerObject;

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = "現在の時間： " + TimerObject.GetComponent<Timer>().GetNowTime() + "秒";
    }
}
