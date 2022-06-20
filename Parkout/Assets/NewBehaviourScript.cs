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
        print($@"��v���`�סG{cam.depth}
�y��I�����b�|�G{sphere.radius}
��v�����I���C��G{cam.backgroundColor}
���n��ؤo�G{capsule.transform.localScale}");
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
