using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelM : MonoBehaviour
{
	public string sceneToLoad = "ItsjustaGame";


	public void LoadGame()
	{
		SceneManager.LoadScene(sceneToLoad);
	}
}
