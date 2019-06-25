using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Text countText;

    private Rigidbody rb;
 //   private int count;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Global.tempCount = 0;
        SetCounText();
       
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3  movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            Global.tempCount++;
            SetCounText();
        }
    }

    void SetCounText()
    {
        countText.text = "Count:" + Global.tempCount.ToString();
        
    }
}
