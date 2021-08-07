using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using System.Reflection;

public class NinjaHealth : MonoBehaviour
{
    float currentHealth;
    float maxHealth = 100f;
    Image EnemyHealthbar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        GameObject imgObj = GameObject.FindWithTag("EnemyHealthbar");
        if (imgObj != null)
            EnemyHealthbar = imgObj.GetComponent<Image>();


    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Bullet"))
        {
            currentHealth--;
           
            EnemyHealthbar.fillAmount = currentHealth / maxHealth;
        }
    }

}

