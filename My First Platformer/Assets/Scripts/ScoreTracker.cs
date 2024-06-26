using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreTracker : MonoBehaviour
{

    public static ScoreTracker instance;

    public TMPro.TextMeshProUGUI uiPuntaje;
    public TMPro.TextMeshProUGUI uiVidas;

    [SerializeField] private int score;
    [SerializeField] private int lifes;

    private int puntajeDeVictoria = 150;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;

        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {
        uiPuntaje.text = score.ToString();
        uiVidas.text = lifes.ToString();

        if (score >= puntajeDeVictoria)
        {
            gameWon(); // Agregado para la victoria
        }
    }

    public int getScore() { return score; }
    public void setScore(int score) { this.score = score; }
    public void addScore(int amount) { this.score += amount; }

    public int getRemainingLifes() { return lifes; }

    public void loseLife(int amount = 1)
    {
        lifes -= amount;


        if (lifes <= 0)
        {
            gameOver();
        }
    }

    public void gameWon()
    {
        SceneManager.LoadScene("Victoria"); // Agregado para la victoria
    }
    public void gameOver()
    {

        SceneManager.LoadScene("Game Over");
    }
}
