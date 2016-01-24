using UnityEngine;
using System.Collections;

public class SubCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if(GameObject.Find("MainCamera"))
			Destroy(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
