using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeToSceneOnClick : MonoBehaviour
{
    
	private Vector2 touchPosition = default;
	//public GameObject Maus; 
	
	[Header("Allows you to jump to a scene when clicking on an object in AR")] 
	[Tooltip("Name of the Scene to jump to ")]
	[SerializeField]
	private string SceneName;
 
	private void Start() {
			}
 
	void Update() {
		/*if (Input.GetKeyDown(KeyCode.Space)){
			Maus.GetComponent<Animator>().SetTrigger("Running");
		}*/

		if(Input.touchCount > 0) {
			Touch touch = Input.GetTouch(0);
			touchPosition = touch.position;
 
 
				if (touch.phase == TouchPhase.Began) {
					Ray ray = Camera.main.ScreenPointToRay(touchPosition);
					RaycastHit hitObject;
 
					if (Physics.Raycast(ray, out hitObject)) {
 
						if(hitObject.transform.CompareTag(this.gameObject.tag)){
							SceneManager.LoadScene(SceneName, LoadSceneMode.Single);

						}
					}
				}
			
		}
	}
 
}
