using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcornController : MonoBehaviour
{
    public Camera cam;
    private float maxWidth;
    public GameObject ball;

    // Use this for initialization
    void Start()
    {
        if (cam == null)
        {
            cam = Camera.main;
            Vector3 upperCorner = new Vector3(Screen.width, Screen.height, 0.0f);
            Vector3 targetWidth = cam.ScreenToWorldPoint(upperCorner);
            float ballWidth = ball.GetComponent<Renderer>().bounds.extents.x;
            maxWidth = targetWidth.x - ballWidth;
            StartCoroutine(Spawn());
        }
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(2.0f);
        
        Vector3 spwanPosition = new Vector3(Random.Range(-maxWidth, maxWidth), transform.position.y, 0.0f);
        Quaternion spawnRotation = Quaternion.identity;
        Instantiate(ball, spwanPosition, spawnRotation);
        yield return new WaitForSeconds(Random.Range(1.0f, 2.0f));
    }
}
