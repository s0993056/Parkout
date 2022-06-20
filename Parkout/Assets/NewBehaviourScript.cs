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
        cube.transform.LookAt(sphere.transform.position);
        cube.transform.RotateAround(sphere.transform.position, Vector3.up, 1);
        capsule.AddForce(transform.up);
    }
}
