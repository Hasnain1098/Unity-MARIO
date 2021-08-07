using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using System.Reflection;

public class Health : MonoBehaviour
{
    float currentHealth;
    float maxHealth = 100f;
    Image healthbar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        GameObject imgObj = GameObject.FindWithTag("hb");
        if (imgObj != null)
            healthbar = imgObj.GetComponent<Image>();


    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Sword"))
        {
            currentHealth--;
            // anim.SetTrigger("IsHurting");
            healthbar.fillAmount = currentHealth / maxHealth;
        }
        else if(collision.gameObject.tag.Equals("Cactus"))
        {
            currentHealth--;
            healthbar.fillAmount = currentHealth / maxHealth;

        }
    }

}

