using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreButton : MonoBehaviour
{
    public Image scoreRank;
    public Text[] Rank;
    private int i;

    // Start is called before the first frame update
    public void OnClick()
    {
        scoreRank.gameObject.SetActive(true);
        //Global.scoreCount[0] = 10;
        
       // Rank[0].text = Global.scoreCount[0].ToString();
        
        for (i = 0; i < 10; i++)
        {
            Rank[i].text = Global.scoreCount[i].ToString();
        }
        
    }

    
}
