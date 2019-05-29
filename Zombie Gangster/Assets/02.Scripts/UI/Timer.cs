using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
<<<<<<< HEAD
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour {

	private float time=120f;
=======

public class Timer : MonoBehaviour {

	float time=120f;
>>>>>>> e36660eb007966b6a5a18c4e0c3d16ccf3b67373

	int count;

	private GameObject slider;
	private Slider sl;
<<<<<<< HEAD
	private Animator ani;

	//텍스트용
	public Text timeText;
	//private float time;

=======
>>>>>>> e36660eb007966b6a5a18c4e0c3d16ccf3b67373

	// Use this for initialization
	void Start () {
		slider = GameObject.Find("Slider");
		sl = slider.GetComponent<Slider>();
<<<<<<< HEAD
		ani = GameObject.Find("TimeCheck").GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {		

		//시간 완료 시 게임오버화면
		if(time<=0f) 
		{
			SceneManager.LoadScene("Over");	
		}


		// 한 프레임 마다 깍아준다
		//time -= Time.deltaTime;
		//sl.value = time/120f;

		
		//timeText.text=string.Format("{0:N2}", time);
		//timeText.text=time.ToString();
		//timeText.text=Mathf.Ceil(time).ToString();
		//timeText.text=$"{time:N2}";

		//일정시간 내에 도달하면 색상 변경됨
		if(time<=40f)		
		{			
			ani.SetTrigger("Time");
		}
=======
	}
	
	// Update is called once per frame
	void Update () {
		if(time<=0f) //게임종료화면띄우기
		// 한 프레임 마다 깍아준다
		time -= Time.deltaTime;
		sl.value = time/120f;
>>>>>>> e36660eb007966b6a5a18c4e0c3d16ccf3b67373
	}
}
