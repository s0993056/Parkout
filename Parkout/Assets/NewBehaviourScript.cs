using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    /*int i = 0;
    float t = 0;*/
    // Start is called before the first frame update
    void Start()
    {
         Physics.sleepThreshold=10;
         Time.timeScale= 0.5f;
        print($@"所有攝影機數量：{Camera.allCamerasCount}
應用程式的平台：{Application.platform}
對 9.999 去小數點：{Mathf.Ceil(9.999f)}
取得兩點的距離：{ Vector3.Distance(new Vector3(1, 1, 1), new Vector3(22, 22, 22))}
睡眠臨界值：{Physics.sleepThreshold}
時間大小：{Time.timeScale}");
        Application.OpenURL("https://unity.com");
    }

    // Update is called once per frame
    void Update()
    {
        /*i++;
        t += Time.deltaTime;
		if (t>1)
		{
        Debug.Log(i);
            i = 0;
            t = 0;
		}*/
        print($@"是否輸入任意鍵：{Input.anyKey}
遊戲經過時間：{Time.timeSinceLevelLoad}
是否按下空白鍵：{Input.GetKeyDown(KeyCode.Space)}");

    }
}
