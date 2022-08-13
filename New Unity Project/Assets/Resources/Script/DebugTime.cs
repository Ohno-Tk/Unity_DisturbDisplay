using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugTime : MonoBehaviour
{
    [SerializeField]
    private GameObject TimerObject;

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = "ランダム時間(分)： " + TimerObject.GetComponent<Timer>().GetTimeMinutes() + "分";
    }
}
