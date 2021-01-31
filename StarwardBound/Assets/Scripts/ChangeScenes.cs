using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    public string sceneName;
    private AudioSource magicSound;

    private void Start()
    {
        magicSound = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            StartCoroutine(ExitDoor());
        }
    }

    IEnumerator ExitDoor()
    {
        magicSound.Play();
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene(sceneName);
    }
}
