using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables; //Timelineの制御に必要

public class TimelineControl : MonoBehaviour
{
    private PlayableDirector Playabledirector;

    // Start is called before the first frame update
    void Start()
    {
        Playabledirector = GetComponent<PlayableDirector>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.RightArrow)) {

            PlayTimeline();

        }
    }

    public void PlayTimeline()
    {
        Playabledirector.Play();
    }
}
