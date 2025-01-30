using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Mouvement")]
    public float moveSpeed = 5f;
    private Vector2 moveInput;
    private Rigidbody2D rb;
    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>(); //Lis l'entrée du joueur
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //Vérifie qu'on récupère bien le Rigidbody2D
    }

    void FixedUpdate()

    {
        MovePlayer();
    }

    void MovePlayer()
    {
        rb.linearVelocity = moveInput * moveSpeed; //Applique la vitesse
    }
}





/*
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
	 [Header("Movement Settings")]
    public float moveSpeed = 5f;

    [Header("Health Settings")]
    public int maxHealth = 100;
    private int currentHealth;

    [Header("Attack Settings")]
    public float attackRange = 1.5f;
    public int attackDamage = 10;
    public LayerMask enemyLayer;

    private Vector2 moveInput;
    private Rigidbody2D rb;


    private PlayerControls controls;

    void Awake()
    {
        controls = new PlayerControls(); //Active le système d'inputs
    }

    void OnEnable()
    {
        controls.Player.Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
        controls.Player.Move.canceled += ctx => moveInput = Vector2.zero;
        controls.Enable();
    }

    void OnDisable()
    {
        controls.Disable();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.linearVelocity = moveInput * moveSpeed;
    }
	
	void Die(){
		if (currentHealth <= 0)
		{
			//Destroy(gameObject);
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}

	public void TakeDamage(int damage)
{
    currentHealth -= damage;
    if (currentHealth <= 0)
    {
        Die();
    }
}
}
*/