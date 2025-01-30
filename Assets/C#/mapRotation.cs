/*
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class MapRotation : MonoBehaviour
{
    public float rotationSpeed = 50f; //Vitesse de la rotation
    public CanvasGroup blackScreen;  //Ecran noir
    public string nextSceneName;     
    private bool isRotating = false;

    private Quaternion targetRotation; //Rotation cible (180°)

    void Start()
    {
        if (blackScreen != null)
        {
            blackScreen.alpha = 0f; //Assure que l'écran noir est invisible au départ
        }

        //rotation cible
        targetRotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y + 180, 0);
        
    }

    void Update()
    {
        //Commence la rotation après 10 secondes
        if (Time.time >= 5f && !isRotating)
        {
            isRotating = true;
        }

        //si la rotation est activée, fait tourner la caméra vers la cible
        if (isRotating)
        {
            StartCoroutine(TransitionToNextMap());
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

        }
    }

    IEnumerator TransitionToNextMap()
    {
        //affiche l'écran noir progressivement
        float fadeDuration = 5f;
        float fadeTimer = 0f;

        while (fadeTimer < fadeDuration)
        {
            fadeTimer += Time.deltaTime;
            if (blackScreen != null)
            {
                blackScreen.alpha = Mathf.Clamp01(fadeTimer / fadeDuration); //Assure une valeur entre 0 et 1
            }
            yield return null;
        }

        //Charge la nouvelle scène
        if (!string.IsNullOrEmpty(nextSceneName))
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
*/
