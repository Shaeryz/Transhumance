using UnityEngine;
using System.Collections;

public class FallingLeaves : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
		public void OnTriggerEnter(Collider other)
		{
		ParticleSystem ps = GetComponentInChildren<ParticleSystem>();
		ps.Play ();
	}
}
