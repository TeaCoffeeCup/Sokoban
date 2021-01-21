using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetTileScript : MonoBehaviour
{
    public bool boxed = false;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Box")
        {
            if (!collision.GetComponent<Crate>().Moving)
            {
                collision.GetComponent<SpriteRenderer>().color = new Color(0.7f, 0.7f, 0.7f);
                boxed = true;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Box")
        {
            collision.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);
            boxed = false;
        }
    }
}
