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
        print($@"�Ҧ���v���ƶq�G{Camera.allCamerasCount}
���ε{�������x�G{Application.platform}
�� 9.999 �h�p���I�G{Mathf.Ceil(9.999f)}
���o���I���Z���G{ Vector3.Distance(new Vector3(1, 1, 1), new Vector3(22, 22, 22))}
�ίv�{�ɭȡG{Physics.sleepThreshold}
�ɶ��j�p�G{Time.timeScale}");
        Application.OpenURL("https://unity.com");
        cam.backgroundColor = Color.white;
        capsule.transform.localScale =new Vector3(3,2,1);
        print($@"��v���`�סG{cam.depth}
�y��I�����b�|�G{sphere.radius}
��v�����I���C��G{cam.backgroundColor}
���n��ؤo�G{capsule.transform.localScale}");
        capsule = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        print($@"�O�_��J���N��G{Input.anyKey}
�C���g�L�ɶ��G{Time.timeSinceLevelLoad}
�O�_���U�ť���G{Input.GetKeyDown(KeyCode.Space)}");
        cube.transform.LookAt(sphere.transform.position);
        cube.transform.RotateAround(sphere.transform.position, Vector3.up, 1);
        capsule.AddForce(transform.up);
    }
}
