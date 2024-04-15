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
        
    }

    public void playerAddScore()
    {
        playerScore++;
        pScore.text = playerScore.ToString();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }

    public void AIAddScore()
    {
        AIScore++;
        aScore.text = AIScore.ToString();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
