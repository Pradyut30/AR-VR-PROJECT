using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class playercontroller : MonoBehaviour
{
    public float speed;

    Rigidbody rb;

    float xinput;
    float yinput;

    int score = 0;
    public int winscore;
    public GameObject wintext;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

    }
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -5f)
        {
            SceneManager.LoadScene("Game");
        }
    }



    private void FixedUpdate()
    {
        xinput = Input.GetAxis("Horizontal");
        yinput = Input.GetAxis("Vertical");

        rb.AddForce(xinput * speed, 0, yinput * speed);


    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="coin")
        {
            other.gameObject.SetActive(false);

            score++;

            if(score>=winscore)
            {
                wintext.SetActive(true);
            }
        }
    }
}
