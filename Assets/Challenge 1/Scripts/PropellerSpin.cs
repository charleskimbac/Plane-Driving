using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = transform.localEulerAngles;
        //rotation.z += .0001f;
        transform.Rotate(rotation);
        Debug.Log(transform.localEulerAngles);

        //all of this doesn't work xd
        //transform.rotation = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z + 4);
        //transform.Rotate(new Vector3(0, 0, transform.rotation.eulerAngles.z + 4));
    }
}
