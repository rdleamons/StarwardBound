using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AcornDestroy : MonoBehaviour
{
    public int hitCount = 0;

    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Acorn"))
        {
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

}
