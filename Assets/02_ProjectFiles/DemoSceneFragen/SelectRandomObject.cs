using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRandomCharacter : MonoBehaviour
{
	
	public GameObject[] Characters; 
	void Awake()
    {
	    Characters = new GameObject[transform.childCount];
	    int children = transform.childCount;
	    for (int i = 0; i < children; ++i){
		    Characters[i] = transform.GetChild(i).gameObject;
	    }
	    int ranCharacter = Random.Range(0,children);
	    Characters[ranCharacter].SetActive(true);
    }
}
    
