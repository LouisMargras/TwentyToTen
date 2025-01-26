using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour 
{

	[Header("Movement Settings")]
	public float moveSpeed = 5f;

	[Header("health Settings")]
	public int maxHealth = 100;
	private int currentHealth;

	[Header("Attack Settings")]
	public float attackRange = 1.5f;
	public int attackDamage = 10;
	public LayerMask enemyLayer;

	private Vector2 moveInput;
	
	private Rigidbody2D rb;


	Enemy enemy1 = new Enemy();

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		currentHealth = maxHealth;
	}

	void Update()
	{
		MovePlayer();
	}

	void MovePlayer()
	{
		Vector2 moveVector = moveInput * moveSpeed * Time.deltaTime;
		rb.MovePosition(rb.position + moveVector);
	}

	public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

	public void OnAttack(InputAction.CallbackContext context)
	{
		if (context.performed)
		{
			Attack();
		}

	}

	void Attack()
	{
		Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(transform.position, attackRange, enemyLayer);
		foreach (Collider2D enemy in hitEnemies)
		{
			
			enemy1.GetComponent<Enemy>().TakeDamage(attackDamage);
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

	void Die()
	{
		Destroy(gameObject);
	}

	void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position, attackRange);
	}

	public void OnPick(InputAction.CallbackContext context)
	{
		if (context.performed)
		{
			Debug.Log("Pick");
		}
	}
}
