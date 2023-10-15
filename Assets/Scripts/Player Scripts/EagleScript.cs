using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EagleScript : MonoBehaviour
{
    [SerializeField]
    public float jumpFoce = 4f;
    public bool isAlive = true;
    private Rigidbody2D rb2D;
    private Animator animator;
    public static EagleScript instance;
    public AudioManagerScript audioManager;

    private void Awake()
    {
        instance = this;
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManagerScript>();
    }

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (!isAlive)
            return;

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            HandleFlap();
            audioManager.PlaySFX(audioManager.fly);
        }

    }

    private void HandleFlap()
    {
        rb2D.velocity = Vector2.up * jumpFoce;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            if (!isAlive)
                return;
            HandleDie();
        }
    }

    private void HandleDie()
    {
        isAlive = false;
        CoinManager.instance.EndRound();
        ScoreManager.instance.EndRound();
        animator.Play("Die");
        animator.SetTrigger("isDeath");
        audioManager.PlaySFX(audioManager.gameOver);
        Invoke("DestroyObject", 3f);
        Invoke("Delay", 3f);
        
    }

    void DestroyObject()
    {
        Destroy(gameObject);
    }

    void Delay()
    {
        SceneManager.LoadScene(2);
    }

}
