using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate_Sides : MonoBehaviour
{
    public string side;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameObject.GetComponentInParent<Crate>().colided(side, collision.gameObject);
            collision.GetComponent<Player>().ChangeShifts(1);
            collision.GetComponent<Player>().MovedBox = GetComponentInParent<Crate>();
        }
    }
}
