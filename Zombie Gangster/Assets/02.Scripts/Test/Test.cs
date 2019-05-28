using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.Realtime;

public class Test : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            Singleton.Instance.inRoom = true;
            PhotonNetwork.LoadLevel(0);
        }
	}
}
