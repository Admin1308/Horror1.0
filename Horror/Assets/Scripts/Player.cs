using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    [Header("Mooving Speed Player")]
    public float speed = 2f;
    public float speedrun = 4f;
    public float timeReset = 100;
    public float startspeed = 0f;
    private float onfoot = 1.4f;

   void FixedUpdate()
    {
        GetInput();
        Stamina();
    }
    private void GetInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += -transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += -transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W) &&  && Input.GetKey(KeyCode.LeftShift))
        {    
          transform.localPosition += transform.forward * speedrun * Time.deltaTime; 
        }      
    }
    private void Stamina()
    {
        if (timeReset < 0) timeReset = 0;
        if (timeReset < 100)
        {
            timeReset += 15 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {
            timeReset -= 50 * Time.deltaTime;
        }
        if (timeReset <= 0)
        {
            speedrun = startspeed;
            speed = onfoot;
            transform.localPosition += transform.forward * startspeed * Time.deltaTime;
            Debug.Log("Кончилась выносливость");  
        }
        if (timeReset>50)
        {
            speedrun = 4f;
            speed = 2f;
        }
    }
}  



