using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LoadScene : MonoBehaviour {

<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 4119fad09803c011d708b32e6c4e764d4b241121
	public void GoLobby()
	{
        //SceneName.instance.Name="Rooms";
        //SceneManager.LoadScene("Loading");	
        SceneManager.LoadScene("SimpleTown_DemoScene");
    }

	public void GoMain()
	{
        //SceneName.instance.Name="Main";
        //SceneManager.LoadScene("Loading");	
        SceneManager.LoadScene("Main");
	}

	public void GoPlay()
	{				
		SceneName.instance.Name="Play";
		SceneManager.LoadScene("Loading");	
	}


	//로딩없이 발생
	public void GoRanking()
	{				
		SceneName.instance.Name="Over_Ranking";
		SceneManager.LoadScene("Over_Ranking");	
	}

	public void GoKill()
	{				
		SceneName.instance.Name="GoKill";
		SceneManager.LoadScene("GoKill");	
	}

<<<<<<< HEAD
=======
=======
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
>>>>>>> e36660eb007966b6a5a18c4e0c3d16ccf3b67373
>>>>>>> 4119fad09803c011d708b32e6c4e764d4b241121
}
