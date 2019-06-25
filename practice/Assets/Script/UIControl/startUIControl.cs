using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startUIControl : MonoBehaviour
{
    

    public Image end;
    public Image scoresRank;
    public Button endBtn;
    // Start is called before the first frame update
    void Start()
    {
        end.gameObject.SetActive(false);
        scoresRank.gameObject.SetActive(false);
        endBtn.gameObject.SetActive(false);

        

    }

}
