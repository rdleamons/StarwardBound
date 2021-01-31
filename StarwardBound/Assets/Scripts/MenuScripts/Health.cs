using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    private void Update()
    {
        if (health < 1)
        {
            hearts[0].gameObject.SetActive(false);
        }
        else if (health < 2)
        {
            hearts[1].gameObject.SetActive(false);
        }
        else if (health < 3)
        {
            hearts[2].gameObject.SetActive(false);
        }


        if(health > numOfHearts)
        {
            health = numOfHearts;
        }
    }
}
