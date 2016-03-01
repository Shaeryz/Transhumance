using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	GameObject Player; 
	Transform t;

	// Use this for initialization
	void Start () {
		Player = GameObject.FindWithTag ("Player");
		t = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		t.position =  new Vector3(Player.transform.position.x,Player.transform.position.y,Player.transform.position.z);

	
	}
}
