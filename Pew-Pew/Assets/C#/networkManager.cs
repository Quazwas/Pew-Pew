using UnityEngine;
using System.Collections;

public class networkManager : MonoBehaviour {

	public GameObject player;
	int conn = 32;
	public void StartServer(int port, bool bNAT) {
		Network.InitializeServer (conn,port,bNAT);
	}
	public void JoinServer(string ip, int port) {
		Network.Connect (ip,port);
	}

	void OnConnectedToServer() {
		Debug.Log ("Connected");
		spawnPlayer ();
	}
	void OnServerInitialized() {
		Debug.Log ("Created");
		spawnPlayer ();
	}
	void spawnPlayer() {
		GameObject playerClone = Network.Instantiate (player, Vector3.zero,Quaternion.identity,0) as GameObject;
	}
}
