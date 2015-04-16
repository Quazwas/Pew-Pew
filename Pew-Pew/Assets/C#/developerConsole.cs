using UnityEngine;
using System.Collections;

public class developerConsole : MonoBehaviour {
	public bool bDebug = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Backslash)) {
			bDebug = !bDebug;
		}
	}
	string command="";
	void OnGUI() {
		if (bDebug) {
			command = GUI.TextField (new Rect (10, 10, 200, 20), command, 25);
		}
	}
}
