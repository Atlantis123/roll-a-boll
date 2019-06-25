using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour
{
    public static int[] scoreCount = new int[10];
    public static int tempCount;
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        for (i = 0; i < 10; i++)
        {
            scoreCount[i] = 0;
        }

        tempCount = 0;
    }
}

