using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AcornDestroy : MonoBehaviour
{
    public int hitCount = 0;
    public GameObject hitTextPrefab;
    public PlayerController player;

    public Health health;
    private AudioSource acornSound;

    private void Start()
    {
        acornSound = GetComponent<AudioSource>();
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Acorn"))
        {
            acornSound.Play();
            if(hitTextPrefab)
            {
                ShowHitText();
            }

            health.health--;
            hitCount++;
            Debug.Log("Hit");
            Destroy(col.gameObject);
        }
    }

    private void Update()
    {
        if(hitCount >= 3)
        {
            Debug.Log("Restart");
            SceneManager.LoadScene("Main");
        }
    }

    void ShowHitText()
    {
        if(player.transform.localScale.x < 0)
        {
            GameObject hitText = Instantiate(hitTextPrefab, transform.position, transform.rotation, transform);
            hitText.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            GameObject hitText = Instantiate(hitTextPrefab, transform.position, transform.rotation, transform);
        }
    }

}
