using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;


public class ResetAR : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
	    LoaderUtility.Deinitialize();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
