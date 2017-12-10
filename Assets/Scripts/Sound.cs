using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sound {

	public string name;

	public AudioClip clip;

	[Range(0f, 1f)]
	public float volume;
	[Range(0f, 1f)]
	public float volumeVariance;

	[Range(-2f, 2f)]
	public float pitch;
	[Range(0f, 1f)]
	public float pitchVariance;

	public bool loop = false;

	[HideInInspector]
	public AudioSource source;

}
