using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	float time=120f;

	int count;

	private GameObject slider;
	private Slider sl;

	// Use this for initialization
	void Start () {
		slider = GameObject.Find("Slider");
		sl = slider.GetComponent<Slider>();
	}
	
	// Update is called once per frame
	void Update () {
		if(time<=0f) //게임종료화면띄우기
		// 한 프레임 마다 깍아준다
		time -= Time.deltaTime;
		sl.value = time/120f;
	}
}
