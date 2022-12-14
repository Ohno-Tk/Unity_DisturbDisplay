using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugRoomKey : MonoBehaviour
{
    [SerializeField]
    private KeyCode KeyDebug = KeyCode.F2;
    [SerializeField]
    private GameObject DebugUI;
    private bool DebugFlag = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyDebug))
        {
            DebugFlag = !DebugFlag;
            Debug.Log("デバッグフラグ：" + DebugFlag);
        }

        DebugUI.SetActive(DebugFlag);
    }
}
