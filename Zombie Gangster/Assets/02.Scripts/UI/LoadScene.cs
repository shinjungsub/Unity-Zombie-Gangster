using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LoadScene : MonoBehaviour {

	LoadingSceneManager loadName;

	public void LobbySceneSingle()
	{
		LoadingSceneManager.instance.SceneName = "Lobby_Single";
		SceneManager.LoadScene("Loading");								//로딩씬으로 일단 이동하고 간다
	}

	public void LobbySceneMulti()
	{
		LoadingSceneManager.instance.SceneName = "Lobby_Multi";
		SceneManager.LoadScene("Loading");								//로딩씬으로 일단 이동하고 간다
	}

	public void MainScene()
	{
		LoadingSceneManager.instance.SceneName = "Lobby_Multi";	//이동할 씬 위치 이름 알려주기
		SceneManager.LoadScene("Loading");								//로딩씬으로 일단 이동하고 간다
	}


	
	public void PlaySingle()
	{
		LoadingSceneManager.instance.SceneName = "PlaySingle";		//이동할 씬 위치 이름 알려주기
		SceneManager.LoadScene("Loading");								//로딩씬으로 일단 이동하고 간다
	}

		public void PlayMulti()
	{
		LoadingSceneManager.instance.SceneName = "PlayMulti";		//이동할 씬 위치 이름 알려주기
		SceneManager.LoadScene("Loading");								//로딩씬으로 일단 이동하고 간다
	}
}
