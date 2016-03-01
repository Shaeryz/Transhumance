using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {

	public Transform platform;
	public Transform startTransform;
	public Transform endTransform;
	public float platformSpeed;
	private Rigidbody platformRigidbody;
	bool stop;
	int count;

	Vector3 direction;
	Transform destination;
		
	void Start (){
		
		SetDestination(startTransform);
		platformRigidbody = platform.GetComponent<Rigidbody> ();
		stop = false;
		count = 0;
	}

	void FixedUpdate(){
		if (stop && count >= 400) {
			stop = false;
			count = 0;
		} else if (stop) {
			count++;
		}

		if (stop == false) {
			platformRigidbody.MovePosition (platform.position + direction * platformSpeed * Time.fixedDeltaTime);
		}

		if(Vector3.Distance (platform.position, destination.position) < platformSpeed * Time.fixedDeltaTime){
			stop = true;
			SetDestination(destination == startTransform ? endTransform : startTransform);
		}
	}


	void OnDrawGizmos(){
		Gizmos.color = Color.green;
		Gizmos.DrawWireCube(startTransform.position, platform.localScale);

		Gizmos.color = Color.red;
		Gizmos.DrawWireCube(endTransform.position, platform.localScale);
	}

	void SetDestination(Transform dest){
		destination = dest;
		direction = (destination.position - platform.position).normalized;
	}

}
