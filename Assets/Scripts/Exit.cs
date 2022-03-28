using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Exit : MonoBehaviour {

    public GameObject textBox;
	public void MainMenuExitClick(){
        textBox.SetActive(false);

		Application.Quit(); 
	}
}