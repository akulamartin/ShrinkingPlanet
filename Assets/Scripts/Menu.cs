using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour {

	public Animator animator;

	public void StartGame ()
	{
		animator.SetTrigger("Start");
		AudioManager.instance.Play("Click");
	}

	public void Quit ()
	{	
		#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
		#else
			Debug.Log("QUITTING");
			AudioManager.instance.Play("Click");
			Application.Quit();
		#endif
	}

	public void Hover ()
	{
		AudioManager.instance.Play("Click");
	}

	public void LoadLevel ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void LoadLeaderBoard(){
		SceneManager.LoadScene("LeaderBoard");
	}
	public void LoadMainMenu(){
		SceneManager.LoadScene("Menu");
	}

}
