using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EagleScript : MonoBehaviour
{
    [SerializeField]
    public float jumpFoce = 4f;
    [SerializeField]
    public bool eagleAlive = true;
    private Rigidbody2D rb2D;
    private Animator animator;

    public static EagleScript instance;

    private void Awake()
    {
            instance = this;
    }

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (!eagleAlive)
            return;

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            HandleFlap();

    }

    private void HandleFlap()
    {
        rb2D.velocity = Vector2.up * jumpFoce;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            HandleDie();
        }
    }

    private void HandleDie()
    {
        eagleAlive = false;
        animator.Play("Die");
        animator.SetTrigger("isDeath");
        Invoke("DestroyObject", 5f);
        CoinManager.instance.EndRound();
        ScoreManager.instance.EndRound();
        SceneManager.LoadScene(3);
    }

    void DestroyObject()
    {
        Destroy(gameObject);
    }
}
