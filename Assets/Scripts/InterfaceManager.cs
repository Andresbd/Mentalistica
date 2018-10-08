using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceManager : MonoBehaviour
{

	public void LoadGames()
	{
		SceneManager.LoadScene("Games");
	}

	public void LoadScore()
	{
		SceneManager.LoadScene("Score");
	}

	public void LoadOptions()
	{
		SceneManager.LoadScene("Options");
	}

	public void LoadMenu()
	{
		SceneManager.LoadScene("Menu");
	}
}
