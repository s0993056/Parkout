using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Camera cam;
    GameObject cube;
    SphereCollider sphere;
    Rigidbody capsule;
    // Start is called before the first frame update
    void Start()
    {
        Physics.sleepThreshold = 10;
        Time.timeScale = 0.5f;
        print($@"所有攝影機數量：{Camera.allCamerasCount}
應用程式的平台：{Application.platform}
對 9.999 去小數點：{Mathf.Ceil(9.999f)}
取得兩點的距離：{ Vector3.Distance(new Vector3(1, 1, 1), new Vector3(22, 22, 22))}
睡眠臨界值：{Physics.sleepThreshold}
時間大小：{Time.timeScale}");
        Application.OpenURL("https://unity.com");
        cam.backgroundColor = Color.white;
        capsule.transform.localScale =new Vector3(3,2,1);
        print($@"攝影機深度：{cam.depth}
球體碰撞器半徑：{sphere.radius}
攝影機的背景顏色：{cam.backgroundColor}
膠囊體尺寸：{capsule.transform.localScale}");
        capsule = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        print($@"是否輸入任意鍵：{Input.anyKey}
遊戲經過時間：{Time.timeSinceLevelLoad}
是否按下空白鍵：{Input.GetKeyDown(KeyCode.Space)}");
        cube.transform.LookAt(sphere.transform.position);
        cube.transform.RotateAround(sphere.transform.position, Vector3.up, 1);
        capsule.AddForce(transform.up);
    }
}
