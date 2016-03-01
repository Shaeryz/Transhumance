using UnityEngine;
using System.Collections;

public class Lookatplayer : MonoBehaviour {
	private GameObject Player;
	private Transform PNJ;
	public int Range;
	 
	void Start () {
		 Player = GameObject.FindWithTag ("Player");
		PNJ = GetComponent<Transform>();
	}
	// Update is called once per frame
	void Update () {
		if(Player.transform.position.x <= PNJ.position.x + Range 
			&& Player.transform.position.x >= PNJ.position.x - Range 
			&& Player.transform.position.z <= PNJ.position.z + Range 
			&& Player.transform.position.z >= PNJ.position.z - Range){
			PNJ.LookAt(Player.transform);

	}
}
}
