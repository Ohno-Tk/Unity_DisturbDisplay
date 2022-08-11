using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables; //Timelineの制御に必要

public class TimelineControl : MonoBehaviour
{
    [SerializeField]
    private GameObject TimerObject;
    private Timer Time;
    private PlayableDirector Playabledirector;

    // Start is called before the first frame update
    void Start()
    {
        try
        {
            Time = TimerObject.GetComponent<Timer>();
            Playabledirector = GetComponent<PlayableDirector>();
        }
        catch
        {
            Debug.Log("TimelineControl.csでERRORとなりました。");
            UnityEditor.EditorApplication.isPaused = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.GetStopFlag() == true) {

            PlayTimeline();

        }
    }

    public void PlayTimeline()
    {
        Playabledirector.Play();
    }
}
