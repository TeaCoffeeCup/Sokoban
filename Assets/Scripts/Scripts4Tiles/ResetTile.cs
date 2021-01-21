using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetTile : MonoBehaviour
{
    public GameObject Player, Box, Box2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Box" || collision.tag == "Player")
        {
            Player.GetComponent<Player>().RestartLevel(true);
            Box.GetComponent<Crate>().RestartLevel();
            Box2.GetComponent<Crate>().RestartLevel();
        }
    }
}
