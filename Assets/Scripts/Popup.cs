using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Popup : MonoBehaviour {


	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Enemy") {
			SceneManager.LoadScene (0);
		}
		if (other.tag == "Goal") {
			SceneManager.LoadScene (0);
		}
	}
}
