using UnityEngine;
using System.Collections;

public class ChangeLookAtTarget : MonoBehaviour {

	public GameObject target; // the target that the camera should look at

	void Start() {
		if (target == null)
		{
			target = this.gameObject;
		}
	}

	// Called when MouseDown on this gameObject
	void OnMouseDown () {
		// change the target of the LookAtTarget script to be this gameobject.
		Debug.Log("here");
		LookAtTarget.target = target;
		Camera.main.fieldOfView = 15; //10*target.transform.localScale.x;
		var listenerTransform = GameObject.FindWithTag("Listener").transform;
		listenerTransform.parent = target.transform;
		listenerTransform.localRotation = Quaternion.identity;
    listenerTransform.localPosition = Vector3.zero;
    listenerTransform.localScale = Vector3.one;
	}
}
