using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.UIElements;
public class GameManager : MonoBehaviour {

	public static GameManager instance;

	public GameObject gameOverUI;

	public Text scoreText;
    public Text highScoreText, newHighScore;
    public Text gameOverScoreText;

	public float gameScore = 0f;
    private float highscore;

	
	
	void Start() {
		highscore = PlayerPrefs.GetFloat("Highscore", 0f);
		UpdateScore(0f);
	}

	void Awake ()
	{
		instance = this;
	}

	public void EndGame ()
	{
		gameOverUI.SetActive(true);
		GameOver();
	}

	public void Restart ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void UpdateScore(float score)
    {
		gameScore += score;
		if(scoreText != null)
        {
            scoreText.text = gameScore.ToString("0.#") + "m";
        }
		if(gameScore > highscore)
        {
            highscore = gameScore;
        }

        highScoreText.text = highscore.ToString("0.#") + "m";
	}

	public void GameOver()
    {
		gameOverScoreText.text = "d = <i><b>"+ gameScore.ToString("0.#")+ "</b>m</i>";
		 highScoreText.text = "d = <i><b>" + PlayerPrefs.GetFloat("Highscore", 0f).ToString() + "</b>m</i>";
        if(highscore > PlayerPrefs.GetFloat("Highscore",0f))
        {
            PlayerPrefs.SetFloat("Highscore", highscore);
            newHighScore.gameObject.SetActive(true);
            
        }
        else
        {
            
        }
	}
}
