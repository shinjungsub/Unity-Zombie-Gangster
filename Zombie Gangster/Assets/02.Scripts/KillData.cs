using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class KillData : MonoBehaviour {

    int killData = 0;
    private void Update()
    {
        killData = ManagerClass.Instance.maxKillNum;
    }
    public void SaveKillDataToJson()
    {
        string jsonData = JsonUtility.ToJson(killData);
        string path = Path.Combine(Application.dataPath, "killData.json");
        File.WriteAllText(path, jsonData);
    }
    public void LoadKillDataToJson()
    {
        string path = Path.Combine(Application.dataPath, "killData.json");
        string jsonData = File.ReadAllText(path);
        ManagerClass.Instance.maxKillNum = JsonUtility.FromJson<int>(jsonData);
    }
}
