using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour {

	public Button start;
	public Button quit;
	public Button info;
	public Button back;

	public GameObject mainscreen;
	public GameObject information;

	// Use this for initialization
	void Start () {
		Button quitbtn = quit.GetComponent<Button>();
		quitbtn.onClick.AddListener(quitOnClick);

		Button startbtn = start.GetComponent<Button>();
		startbtn.onClick.AddListener(startOnClick);

		Button infobtn = info.GetComponent<Button>();
		infobtn.onClick.AddListener(infoOnClick);

		Button backbtn = back.GetComponent<Button>();
		backbtn.onClick.AddListener(backOnClick);
	}

	void startOnClick(){
		 SceneManager.LoadScene("scene_stage1");
	}

	void quitOnClick(){
		Application.Quit();
	}

	void infoOnClick(){
		mainscreen.SetActive(false);
		information.SetActive(true);
	}

	void backOnClick(){
		mainscreen.SetActive(true);
		information.SetActive(false);
	}

}
