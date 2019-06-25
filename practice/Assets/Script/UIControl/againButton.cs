using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class againButton : MonoBehaviour
{
    public Image end;
    public Image start;

    public void OnClick()
    {
        end.gameObject.SetActive(false);
        start.gameObject.SetActive(true);
    }
}
