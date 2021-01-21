using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTile : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Box" || collision.tag == "Player")
        {
            print("Bye!");
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Saver>().Exit();
        }
    }
}
