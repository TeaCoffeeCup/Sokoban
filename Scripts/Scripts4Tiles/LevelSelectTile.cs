using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LevelSelectTile : MonoBehaviour
{
    public GameObject Camera, Player;
    public Transform levelSelect;
    public float speed;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Box" || collision.tag == "Player")
        {
            Camera.GetComponent<MainCamera>().Moving = true;
            Camera.GetComponent<MainCamera>().TargetMovingTo = levelSelect;
            Camera.GetComponent<MainCamera>().speed = speed;
            Player.GetComponent<Player>().canMove = false;
            GameObject.FindGameObjectWithTag("PhoneControls").GetComponent<Canvas>().enabled = false;
        }
    }
}
