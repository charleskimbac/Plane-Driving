using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    public float spinSpeed = 4f;

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, spinSpeed));
        //Debug.Log(transform.localEulerAngles);

        //3 attempts at using Quaternions :(
        /*
        Vector3 rotation = transform.localEulerAngles;
        //rotation.z += .0001f;
        transform.Rotate(rotation);
        Debug.Log(transform.localEulerAngles);
        */
        //transform.rotation = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z + 4);
        //transform.Rotate(new Vector3(0, 0, transform.rotation.eulerAngles.z + 4));
    }
}
