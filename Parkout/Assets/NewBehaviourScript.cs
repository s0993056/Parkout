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
        print($@"�Ҧ���v���ƶq�G{Camera.allCamerasCount}
���ε{�������x�G{Application.platform}
�� 9.999 �h�p���I�G{Mathf.Ceil(9.999f)}
���o���I���Z���G{ Vector3.Distance(new Vector3(1, 1, 1), new Vector3(22, 22, 22))}
�ίv�{�ɭȡG{Physics.sleepThreshold}
�ɶ��j�p�G{Time.timeScale}");
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
        print($@"�O�_��J���N��G{Input.anyKey}
�C���g�L�ɶ��G{Time.timeSinceLevelLoad}
�O�_���U�ť���G{Input.GetKeyDown(KeyCode.Space)}");

    }
}
