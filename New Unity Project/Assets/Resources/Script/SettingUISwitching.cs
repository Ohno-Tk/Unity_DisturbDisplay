using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingUISwitching : MonoBehaviour
{
    [SerializeField]
    private KeyCode Key = KeyCode.F1;
    private bool SettingUIDisplay = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(Key))
        {
            SettingUIDisplay = !SettingUIDisplay;
            Debug.Log("設定画面表示非表示：" + SettingUIDisplay);
        }
    }
}
