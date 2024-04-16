using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int playerScore;
    public int AIScore;
    [SerializeField]
    private TextMeshProUGUI pScore;
    [SerializeField]
    private TextMeshProUGUI aScore;
    void Start()
    {
        playerScore = 0;
        AIScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerScore == 5)
        {
            SceneManager.LoadScene("Win");
        }
        if (AIScore==5)
        {
            SceneManager.LoadScene("GameOver");
        }
        if(SceneManager.GetActiveScene().name.Equals("SampleScene") && Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("huh");
            SceneManager.LoadScene("Menu");
        }
        if(SceneManager.GetActiveScene().name.Equals("Menu") && Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void playerAddScore()
    {
        playerScore++;
        pScore.text = playerScore.ToString();
        
    }

    public void AIAddScore()
    {
        AIScore++;
        aScore.text = AIScore.ToString();
        
    }
    public void playerSubScore()
    {
        if (playerScore > 0) { 
        playerScore--;
        pScore.text = playerScore.ToString();
    }
    }

    public void AISubScore()
    {
        if (AIScore > 0)
        {
            AIScore--;
            aScore.text = AIScore.ToString();
        }
    }
    
}
