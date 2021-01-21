using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoHome : MonoBehaviour
{
    public GameObject Camera, Player;
    public Transform MainMenu;
    public float speed;
    void Start()
    {
        transform.position = new Vector3(MainMenu.position.x, MainMenu.position.y, transform.position.z);
    }
    public void Home()
    {
        Camera.GetComponent<MainCamera>().Moving = true;
        Camera.GetComponent<MainCamera>().TargetMovingTo = MainMenu;
        Camera.GetComponent<MainCamera>().speed = speed;
        Player.GetComponent<Player>().canMove = true;
        gameObject.GetComponent<Pause>().HideAll();
        GameObject.FindGameObjectWithTag("PhoneControls").GetComponent<Canvas>().enabled = true;
    }
}
