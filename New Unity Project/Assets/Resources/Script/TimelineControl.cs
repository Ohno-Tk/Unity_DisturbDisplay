using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables; //Timelineの制御に必要

public class TimelineControl : MonoBehaviour
{
    [SerializeField]
    private GameObject TimerObject;
    [SerializeField]
    private GameObject Image_CMObject;
    private Timer Time;
    private PlayableDirector Playabledirector;

    // Start is called before the first frame update
    void Start()
    {
        try
        {
            Time = TimerObject.GetComponent<Timer>();
        }
        catch
        {
            Debug.Log("TimelineControl.csでERRORとなりました。");
            UnityEditor.EditorApplication.isPaused = true;
        }

        Playabledirector = GetComponent<PlayableDirector>();
        Playabledirector.stopped += OnPlayableDirectorStopped;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.GetSetStopFlag == true)
        {
            PlayTimeline();
        }
    }

    // TimeLineが終了したら
    private void OnPlayableDirectorStopped(PlayableDirector director)
    {
        if (Playabledirector == director)
        {
            Time.GetSetStopFlag = false;
            //Time.ChangeMinutesTime();
            Image_CMObject.GetComponent<Change_ImageTexture>().RandomReplaceSprite();
            Debug.Log("PlayableDirector named " + director.name + " is now stopped.");
        }
    }

    // タイムラインスタート
    public void PlayTimeline()
    {
        Playabledirector.Play();
    }
}
