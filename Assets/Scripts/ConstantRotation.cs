using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       // transform.Rotate(0, 50 * Time.deltaTime, 0);
        transform.RotateAroundLocal(Vector3.up, 0.5f * Time.deltaTime);
	}
}
