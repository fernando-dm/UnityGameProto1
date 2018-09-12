using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Popup : MonoBehaviour {
    public GameObject LosePopup;
    public GameObject WinPopup;
    public Text FinalGoldWin;
    public Text FinalGoldLose;

    void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Enemy") {
            //SceneManager.LoadScene (0);
            Cursor.visible = true;
            LosePopup.SetActive(true);
            FinalGoldLose.text = "You Collected " + GetComponent<Collection>().gold + " Gold";
            Time.timeScale = 0; // evito que los personajes se muevan
		}
		if (other.tag == "Goal") {
            //SceneManager.LoadScene (0);
            Cursor.visible = true;
            WinPopup.SetActive(true);
            FinalGoldWin.text = "You Collected " + GetComponent<Collection>().gold + " Gold";
            Time.timeScale = 0; // evito que los personajes se muevan
        }
	}
}
