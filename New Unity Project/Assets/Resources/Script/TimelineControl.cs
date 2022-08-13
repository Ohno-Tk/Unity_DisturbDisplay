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
            Playabledirector.stopped += OnPlayableDirectorStopped;
        }
        catch
        {
            Debug.Log("TimelineControl.csでERRORとなりました。");
            UnityEditor.EditorApplication.isPaused = true;
        }
    }

    void OnPlayableDirectorStopped(PlayableDirector aDirector)
    {
        if (Playabledirector == aDirector)
        {
            Time.SetStopFlag(false);
            Time.ChangeMinutesTime();
            Debug.Log("PlayableDirector named " + aDirector.name + " is now stopped.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.GetStopFlag() == true)
        {
            PlayTimeline();
        }
    }

    // タイムラインスタート
    public void PlayTimeline()
    {
        Playabledirector.Play();
    }
}
