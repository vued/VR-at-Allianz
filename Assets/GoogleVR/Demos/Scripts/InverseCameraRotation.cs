using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InverseCameraRotation : MonoBehaviour {

	public Vector3 fixedRotation;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {

		// reorientate to a fixed direction
		fixedRotation.Normalize ();
		this.transform.rotation = Quaternion.LookRotation(fixedRotation);

	}
}
