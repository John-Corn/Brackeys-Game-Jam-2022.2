using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class objects : MonoBehaviour
{

    public GameObject objectBox;
    public GameObject pills;
    public GameObject mark;
    public bool objectActive;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && objectActive)
        {
            if (objectBox.activeInHierarchy)
            {
                objectBox.SetActive(false);
                PlayerMovement.playerControlsEnabled = true;
                pills.SetActive(false);
            }
            else
            {
                objectBox.SetActive(true);
                PlayerMovement.playerControlsEnabled = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            objectActive = true;
            mark.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            objectActive = false;
            objectBox.SetActive(false);
            mark.SetActive(false);
        }
    }
}
