using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InverseCameraRotation : MonoBehaviour {

	public Transform relativeTransform;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float x = relativeTransform.localRotation.x;
		float y = relativeTransform.localRotation.y;
		float z = relativeTransform.localRotation.z;
		float w = relativeTransform.localRotation.w;
		Debug.Log("Relative Rotation: " + x + "; " + y + "; " + z + "; " + w);
		this.transform.localRotation.Set (x, y, z, w);

		x = this.transform.localRotation.x;
		y = this.transform.localRotation.y;
		z = this.transform.localRotation.z;
		w = this.transform.localRotation.w;
		Debug.Log("Logo     Rotation: " + x + "; " + y + "; " + z + "; " + w);

	}
}
