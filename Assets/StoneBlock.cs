using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneBlock : MonoBehaviour
{
    public int score;
    LevelManager level;
    // Start is called before the first frame update
    void Start()
    {
        level = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Triggered");
        if (collision.gameObject.tag.Equals("Player"))
        {
            score++;
            level.CountStoneBlock(score);
            Sound.PlaySound("picked_StoneBlock");
            Destroy(gameObject);
        }
    }
}
