using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AcornDestroy : MonoBehaviour
{
    public int hitCount = 0;
    public GameObject hitTextPrefab;
    public Health health;

    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Acorn"))
        {
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
        Instantiate(hitTextPrefab, transform.position, transform.rotation, transform);
    }

}
