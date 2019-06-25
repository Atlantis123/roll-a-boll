using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class startButton : MonoBehaviour
{
    public Image start;
    public Image socre;
    public Button endBtn;
    public Text countText;
    public GameObject[] PickUp;
   


    public void OnClick()
    {
        start.gameObject.SetActive(false);
        socre.gameObject.SetActive(false);
        endBtn.gameObject.SetActive(true);

        Global.tempCount = 0;
        countText.text = "Count:" + Global.tempCount.ToString();
        foreach (GameObject p in PickUp)
        {
            p.gameObject.SetActive(true);
        }
    }
}
