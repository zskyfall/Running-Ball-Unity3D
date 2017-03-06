using UnityEngine;
using System.Collections;

public class floorRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (-30, 10, 10) * Time.deltaTime);
	}
}
