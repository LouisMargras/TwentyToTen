/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat : MonoBehaviour
{
    [Header("Bonus Settings")]
    public int healthBonus = 20;
    public float freezeTimeDuration = 5f;
    public List<string> otherBonus; 

    private bool isCollected = false;

    void OnTriggerEnter2D(Collider2D other)
    {
       if (other.CompareTag("Player") && !isCollected)
        {
           isCollected = true;
           CollectCat(other.gameObject);    
        }
    }

    void CollectCat(GameObject player)
    {
        Debug.Log("Cat Collected");

        //Apply health bonus
        PlayerController playerController = player.GetComponent<PlayerController>();
        if (playerController != null)
        {
            playerController.TakeDamage(-healthBonus); //negative damage means healing
        }

        // Freeze time
        StartCoroutine(FreezeTime());

        foreach (string bonus in otherBonus)
        {
            Debug.Log($"apply {bonus} bonus");
            // Choisir le bonus
        }

        // Destroy the cat object
        Destroy(gameObject);
    }

    IEnumerator FreezeTime()
    {
        Debug.Log("Time frozen!");

        // Disable all time-sensitive mechanics
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(freezeTimeDuration);

        // Re-enable time-sensitive mechanics
        Time.timeScale = 1f;
        Debug.Log("Time unfrozen!");
    }
}
*/