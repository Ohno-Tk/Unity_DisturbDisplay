using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Application_Quit : MonoBehaviour
{
    [SerializeField]
    private KeyCode Key = KeyCode.Escape;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(Key))
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE
            UnityEngine.Application.Quit();
#endif
        }
    }
}
