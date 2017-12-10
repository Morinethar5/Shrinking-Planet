using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : FauxGravityBody {

	public GameObject explosion;

	public SphereCollider sphereCol;
	public ParticleSystem trail;

	void OnCollisionEnter(Collision col)
	{
		Quaternion rot = Quaternion.LookRotation(transform.position.normalized);
		rot *= Quaternion.Euler(90f, 0f, 0f);
		Instantiate(explosion, col.contacts[0].point, rot);

		sphereCol.enabled = false;
		trail.Stop(true, ParticleSystemStopBehavior.StopEmitting);

		this.enabled = false;
		GetComponent<AudioSource>().Stop();

		Destroy(gameObject, 4f);
	}

}
