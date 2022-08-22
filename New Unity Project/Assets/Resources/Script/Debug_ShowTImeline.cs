using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables; //Timelineの制御に必要

public class Debug_ShowTImeline : MonoBehaviour
{
    [SerializeField]
    private KeyCode KeyDebug = KeyCode.F3;

    [SerializeField]
    private GameObject TimelineObject;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyDebug))
        {
            TimelineObject.GetComponent<TimelineControl>().PlayTimeline();
        }
    }
}
