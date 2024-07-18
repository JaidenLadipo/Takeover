using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score;
    public GameObject winScreen;
    public GameObject pickupParent;
    [SerializeField]private int pickupTotal;
    public static GameManager Instance{get;private set;}
    // Start is called before the first frame update
    void Awake()
    {
        if(Instance==null)
        {
            Instance=this;

        }
        else
        {
            Destroy(this.gameObject);

        }
    }
    void Start()
    {
        score=0;
        UpdateUI();
        winScreen.SetActive(false);
        pickupTotal=pickupParent.transform.childCount;
    }
    public void UpdateUI()
    {
        scoreText.text=score.ToString();
    }
    public void WinGame()
    {
        winScreen.SetActive(true);
    }
    public void UpdateScore(int amount)
    {
        score+=amount;
        UpdateUI();
        if(score>=pickupTotal)
        {
            WinGame();
            foreach(UnityEngine.AI.NavMeshAgent enemy in FindObjectsOfType<UnityEngine.AI.NavMeshAgent>()) enemy.enabled = false;
        }
    }
    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
