using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class Singleton : MonoBehaviour {
    static Singleton current = null;
    static GameObject container = null;

    public static Singleton Instance
    {
        get{
            if(current == null)
            {
                container = new GameObject();
                container.name = "Singleton";
                current = container.AddComponent(typeof(Singleton)) as Singleton;
                DontDestroyOnLoad(current);
            }
            return current;
        }
    }

    public bool inRoom = false;
    public string playerNickName = "";
}
