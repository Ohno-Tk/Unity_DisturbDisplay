using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingUISwitching : MonoBehaviour
{
    [SerializeField]
    private GameObject SettingUI;
    [SerializeField]
    private KeyCode KeySetting = KeyCode.F1;
    private bool PauseFlag = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeySetting))
        {
            PauseFlag = !PauseFlag;
            SettingUI.SetActive(PauseFlag);
            Debug.Log("ポーズフラグ：" + PauseFlag);

        }

        if(PauseFlag == true)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
}
