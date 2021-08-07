using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelManager : MonoBehaviour
{
    public int numberofStoneBlock;
    public Text StoneBlock;

    // Start is called before the first frame update
    void Start()
    {
        StoneBlock.text = "StoneBlock: " + numberofStoneBlock;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void CountStoneBlock(int score)
    {
        numberofStoneBlock += score;
        StoneBlock.text = "StoneBlock: " + numberofStoneBlock;
        Debug.Log(numberofStoneBlock);
    }
}
