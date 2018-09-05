using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	private Vector3 goal;
	private UnityEngine.AI.NavMeshAgent agent;
	//public GameObject cameraParent;

	void Start () {
		Cursor.visible = false;

		goal = transform.position;
		agent = GetComponent<UnityEngine.AI.NavMeshAgent> ();
	}

	void Update () {
		goal = transform.position
                        + Vector3.right * Input.GetAxis("Horizontal")
                        + Vector3.forward * Input.GetAxis("Vertical");
  //      + cameraParent.transform.right * Input.GetAxis ("Horizontal") 
		//+ cameraParent.transform.forward * Input.GetAxis ("Vertical");
		
		agent.destination = goal;
	}
}
