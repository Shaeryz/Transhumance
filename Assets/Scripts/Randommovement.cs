using UnityEngine;
using System.Collections;

public class Randommovement : MonoBehaviour
{
	Rigidbody rigidBody;
	public float speed;
	Vector3 direction;

	void Awake ()
	{
		rigidBody = GetComponent<Rigidbody> ();
		StartCoroutine (NewHeading ());
	}

	void Update ()
	{
		var vector = rigidBody.position + direction * speed * Time.fixedDeltaTime;
		rigidBody.MovePosition (vector);
		transform.LookAt (vector);
	}

	IEnumerator NewHeading ()
	{
		while (true) {
			direction = new Vector3 (Random.Range (-1f, 1f), 0, Random.Range (-1f, 1f));
			yield return new WaitForSeconds(Random.Range(1f, 3f));
			direction = Vector3.zero;
			yield return new WaitForSeconds(Random.Range(2f,5f));
		}
	}
}