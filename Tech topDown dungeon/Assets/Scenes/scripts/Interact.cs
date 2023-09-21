using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interact : MonoBehaviour
{
    public GameObject mText;
    public UnityEvent RunCode;
    public bool InRange = false;
    void Start()
    {
        mText.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Submit") && InRange)
        {
            RunCode.Invoke();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            Debug.Log("we enter the trigger");
            mText.SetActive(true);
            InRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("we exit the trigger");
            mText.SetActive(false);
            InRange = false;
        }
    }
}
