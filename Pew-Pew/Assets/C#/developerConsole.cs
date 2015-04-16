using UnityEngine;
using System.Collections;

public class developerConsole : MonoBehaviour {
	public bool bDebug = false;
	networkManager networkManagerComp;
	// Use this for initialization
	void Start () {
		networkManagerComp = GameObject.Find ("NetworkManager").GetComponent<networkManager>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Backslash)) {
			bDebug = !bDebug;
		}
	}
	string command="";
	string ip="";
	string port="2500";
	bool bNAT=false;
	void OnGUI() {
		if (bDebug) {
			GUI.Label(new Rect(10, 10, 100, 20), "Console:");
			command = GUI.TextField (new Rect (70, 10, 200, 20), command, 25);
			GUI.Label(new Rect(10, 30, 100, 20), "Network:");
			GUI.Label(new Rect(30, 50, 100, 20), "IP:");
			ip = GUI.TextField (new Rect (70, 50, 200, 20), ip, 25);
			GUI.Label(new Rect(30, 70, 100, 20), "Port:");
			port = GUI.TextField (new Rect (70, 70, 200, 20), port, 25);
			if(GUI.Button(new Rect(70, 100, 100, 30), "Start Server")) {
				networkManagerComp.StartServer(int.Parse(port),bNAT);
			}
			if(GUI.Button(new Rect(180, 100, 100, 30), "Join Server")) {
				networkManagerComp.JoinServer(ip,int.Parse(port));
			}
		}
	}
}
