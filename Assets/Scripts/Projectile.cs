using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	void Update () {
		transform.Translate (Vector3.forward * Time.deltaTime * 10);
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Enemy") {
			Destroy (other.gameObject);
            Instantiate(Resources.Load("Collectable"), other.transform.position, Quaternion.Euler(-90,0,0));
            Instantiate(Resources.Load("PickupEffect"), other.transform.position, Quaternion.Euler(-90, 0, 0));
            Destroy (gameObject);
		}
	}
}
