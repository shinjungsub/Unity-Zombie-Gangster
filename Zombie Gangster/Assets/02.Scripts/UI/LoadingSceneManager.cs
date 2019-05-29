using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

<<<<<<< HEAD
public class LoadingSceneManager : MonoBehaviour {	
	
	//싱글톤 맨듬
	// public static LoadingSceneManager instance;
	// public static LoadingSceneManager GetInstance()
	// {
	// 	if(!instance)
	// 	{
	// 		instance=FindObjectOfType(typeof(LoadingSceneManager))as LoadingSceneManager;
	// 		//as: 프리팹을 인스턴스화시켜준답디다
    //
	// 		if(!instance) Debug.LogError("없어");			
	// 	}
	//
	// 	return instance;
	// }
	//============================================
=======
public class LoadingSceneManager : MonoBehaviour {
>>>>>>> e36660eb007966b6a5a18c4e0c3d16ccf3b67373

	public Slider slider;
	bool IsDone=false;
	float fTime=0f;
<<<<<<< HEAD
	AsyncOperation async_operation;		
	//public string SceneName;


	//안터지게 함
	void Awake()
	{		
		// if(instance==null)
		// {
		// 	instance=this;	
		// }
		// else if(instance!=this)
		// {
		// 	Destroy(gameObject);
		// }
		// DontDestroyOnLoad(gameObject);
=======
	AsyncOperation async_operation;	
	public string SceneName;
	
	
	//============================================
	//싱글톤 맨듬
	public static LoadingSceneManager instance;
	public static LoadingSceneManager GetInstance()
	{
		if(!instance)
		{
			instance=FindObjectOfType(typeof(LoadingSceneManager))as LoadingSceneManager;
			//as:프리팹을 인스턴스화시켜준답디다

			if(!instance) Debug.LogError("없어");					
		}
		
		return instance;
	}

	//안터지게 함
	void Awake()
	{
		if(instance==null)
		{
			instance=this;	
		}
		else if(instance!=this)
		{
			Destroy(gameObject);
		}
		DontDestroyOnLoad(gameObject);
>>>>>>> e36660eb007966b6a5a18c4e0c3d16ccf3b67373
	}

	//============================================
	void Start()
	{	
<<<<<<< HEAD
		StartCoroutine(StartLoad(SceneName.instance.Name));
=======
		StartCoroutine(StartLoad(SceneName));
>>>>>>> e36660eb007966b6a5a18c4e0c3d16ccf3b67373
	}


	//============================================
	void Update()
	{
		fTime+=Time.deltaTime;
		slider.value=fTime;

		if(fTime>=5)
		{
			async_operation.allowSceneActivation=true;
			
		}
	}

	//============================================
	public IEnumerator StartLoad(string strSceneName)
	{
		async_operation=SceneManager.LoadSceneAsync(strSceneName);
		//async_operation=Application.LoadLevelAsync(strSceneName);
		async_operation.allowSceneActivation=false;

		if(IsDone==false)
		{
			IsDone=true;

			while(async_operation.progress<0.9f)
			{
				slider.value=async_operation.progress;
				yield return true;
			}
		}
	}


}
