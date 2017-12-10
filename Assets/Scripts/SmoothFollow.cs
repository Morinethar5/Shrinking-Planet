using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollow : MonoBehaviour {

	public Transform target;

	public float smoothness = 1f;
	public float rotationSmoothness = .1f;

	public Vector3 offset;

	private Vector3 velocity = Vector3.zero;

	// Update is called once per frame
	void FixedUpdate () {

		if (target == null)
		{
			return;
		}
		
		Vector3 newPos = target.TransformDirection(offset);
		//transform.position = newPos;
		transform.position = Vector3.SmoothDamp(transform.position, newPos, ref velocity, smoothness);

		Quaternion targetRot = Quaternion.LookRotation(-transform.position.normalized, target.up);
		//transform.rotation = targetRot;
		transform.rotation = Quaternion.Lerp(transform.rotation, targetRot, Time.deltaTime * rotationSmoothness);

	}
}
