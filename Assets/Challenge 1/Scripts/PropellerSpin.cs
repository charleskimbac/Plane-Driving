using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    public GameObject propeller;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        propeller.transform.rotation = Quaternion.Euler(0, 0, propeller.transform.rotation.eulerAngles.z + 4);
        Debug.Log(Quaternion.Euler(0, 0, propeller.transform.rotation.eulerAngles.z).eulerAngles);
        Debug.Log(propeller.transform.rotation.x);
    }
}
