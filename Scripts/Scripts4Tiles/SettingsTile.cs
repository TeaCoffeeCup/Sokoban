using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsTile : MonoBehaviour
{
    public GameObject Camera;
    public Transform settings;
    public float speed;
    public GameObject Player1;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Box" || collision.tag == "Player")
        {
            Camera.GetComponent<MainCamera>().Moving = true;
            Camera.GetComponent<MainCamera>().TargetMovingTo = settings;
            Camera.GetComponent<MainCamera>().speed = speed;
            Player1.GetComponent<Player>().canMove = false;
            GameObject.FindGameObjectWithTag("PhoneControls").GetComponent<Canvas>().enabled = false;
        }
    }
}
