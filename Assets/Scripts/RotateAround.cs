using UnityEngine;
using System.Collections;

public class RotateAround : MonoBehaviour {

	public Transform target; // the object to rotate around
	public float duration; // the duration of rotation
	public float speed = 1.0f;

	void Start() {
		if (target == null)
		{
			target = this.gameObject.transform;
			Debug.Log ("RotateAround target not specified. Defaulting to parent GameObject");
		}
	}

	// Update is called once per frame
	void Update () {
		if (duration == 0)
		  return;
		// RotateAround takes three arguments, first is the Vector to rotate around
		// second is a vector that axis to rotate around
		// third is the degrees to rotate, in this case the speed per second
		transform.RotateAround(target.transform.position,target.transform.up, Time.deltaTime / duration * speed);
	}
}
