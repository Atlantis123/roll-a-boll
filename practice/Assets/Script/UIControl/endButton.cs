using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endButton : MonoBehaviour
{
    public Image endUI;
    public Button endBtn;

    private int i,j;

    public void OnClick()
    {
        //处理score
        
        for (i = 0; i < 10 ; i++)
        {
            if (Global.tempCount > Global.scoreCount[i])
            {
                for (j = 9; j > i; j--)
                {
                    Global.scoreCount[j] = Global.scoreCount[j - 1];
                }
                Global.scoreCount[i] = Global.tempCount;
                break;
            }
        }
        

        endUI.gameObject.SetActive(true);
        endBtn.gameObject.SetActive(false);

        
        
        
        

    }
}
