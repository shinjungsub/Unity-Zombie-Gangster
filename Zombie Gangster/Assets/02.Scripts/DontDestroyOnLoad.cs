using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


public class DontDestroyOnLoad : MonoBehaviour {

 //   private bool inRoom;
    
 //   [SerializeField]
 //   private GameObject currentRoomCanvas;

	//private void Awake()
 //   {
 //       DontDestroyOnLoad(gameObject);
 //   }

 //   void Update()
 //   {
 //       if(SceneManager.GetActiveScene().buildIndex == 0)
 //       {
 //           currentRoomCanvas = GameObject.Find("CurrentRoomCanvas");
 //           if (PhotonNetwork.InRoom)
 //               inRoom = true;
 //           else
 //               inRoom = false;
 //           if (inRoom)
 //               currentRoomCanvas.SetActive(true);
 //           else
 //               currentRoomCanvas.SetActive(false);
 //       }
 //   }
}
