using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;


public class InitAR : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
	    ARSession session = FindObjectOfType<ARSession>();
	    session.Reset();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
