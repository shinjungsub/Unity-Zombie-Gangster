﻿using System.Collections;
using UnityEngine;

public class ManagerClass : MonoBehaviour {
    private static ManagerClass _instance = null;

    public static ManagerClass Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = FindObjectOfType(typeof(ManagerClass)) as ManagerClass;
                if(_instance == null)
                {
                    Debug.LogError("There's no active ManagerClass object");
                }
            }
            return _instance;
        }
    }

    //이곳에 변수나 함수를 퍼플릭으로 선언하면 sendMessage를 안쓰고도 접근 가능
    public int killNum = 0;
    public int maxKillNum = 0;
    public bool playerDie = false;

    public void MaxKillNum()
    {
        if(maxKillNum < killNum)
        {
            maxKillNum = killNum;
        }
    }
}
