using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour {

	public static float Size
	{
		get { return myTransform.localScale.x; }
	}

	public static float Score
	{
		get { return Size * 63f; }
	}

	private static Transform myTransform;

	public float shrinkSpeed = .05f;

	void Awake ()
	{
		myTransform = transform;
	}

	void Update ()
	{
		transform.localScale *= 1f - shrinkSpeed * Time.deltaTime;
	}

}
