using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Playercontroller : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpForce;
    public GameObject loseScreenUI;
    public int score;
    public TMPro.TextMeshProUGUI scoreText;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        PlayerJump();
    }

    void PlayerJump()
    {
        if (Input.GetMouseButtonDown(0))
        {
            audioManager.singleton.PlaySound(0);
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("obstacle"))
        {
            PlayerLose();
        }
    }

    void PlayerLose()
    {
        audioManager.singleton.PlaySound(1);
        loseScreenUI.SetActive(true);
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("score"))
        {
            addScore();
        }
    }
    void addScore()
    {
        audioManager.singleton.PlaySound(2);
        score++;
        scoreText.text = score.ToString();
    }
}
