using UnityEngine;
using System.Collections;

public class platformSpawnScript : MonoBehaviour {

	public GameObject obj;
	private Vector3 target;

	// Use this for initialization
	void Start () {
	}

	void Update(){
		if (Input.GetMouseButtonDown (0)) {
			target = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			target.z = 0;
			Instantiate (obj, target, Quaternion.identity);
		}
	}


}
