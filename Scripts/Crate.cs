using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate : MonoBehaviour
{
    public GameObject Point;
    public float speed = 2f;
    public GameObject player;
    public Sprite[] SpriteVariants;
    private Transform StartPoint, Recovery, Target;
    private GameObject LastCollidedPlayer;
    private GameObject lastPositionExact, lastPositionUnexact;
    private bool collided = false;
    public bool Moving = false;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<BoxCollider2D>().size = new Vector2(0.5f, 0.5f);
        Target = Instantiate(Point, transform.position, transform.rotation).GetComponent<Transform>();
        Recovery = Instantiate(Point, transform.position, transform.rotation).GetComponent<Transform>();
        StartPoint = Instantiate(Point, transform.position, transform.rotation).GetComponent<Transform>();
        GetComponent<SpriteRenderer>().sprite = SpriteVariants[Random.Range(0, SpriteVariants.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Target.transform.position, speed * Time.deltaTime);
        if (new Vector3(transform.position.x, transform.position.y, 0f) == new Vector3(Target.transform.position.x, Target.transform.position.y, 0f))
        {
            Recovery.position = transform.position;
            Moving = false;
            if (lastPositionUnexact && !collided)
            {
                Destroy(lastPositionExact);
                lastPositionExact = lastPositionUnexact;
                lastPositionUnexact = null;
            }
        }
    }

    public void colided(string side, GameObject player)
    {
        lastPositionUnexact = Instantiate(Point, transform.position, transform.rotation);
        LastCollidedPlayer = player;
        GameObject.FindGameObjectWithTag("SFXPlayer").GetComponent<PlayCrateSound>().CrateSound();
        Recovery.position = transform.position;
        switch (side)
        {
            case "right":
                Target.transform.position = new Vector3(Target.transform.position.x - 1.275f, Target.transform.position.y, Target.transform.position.z);
                Moving = true;
                break;
            case "left":
                Target.transform.position = new Vector3(Target.transform.position.x + 1.275f, Target.transform.position.y, Target.transform.position.z);
                Moving = true;
                break;
            case "bottom":
                Target.transform.position = new Vector3(Target.transform.position.x, Target.transform.position.y + 1.275f, Target.transform.position.z);
                Moving = true;
                break;
            case "top":
                Target.transform.position = new Vector3(Target.transform.position.x, Target.transform.position.y - 1.275f, Target.transform.position.z);
                Moving = true;
                break;
        }
    }
    public void EndMoves(bool Box = false)
    {
        transform.position = Recovery.position;
        Target.transform.position = transform.position;
        if (!Box)
        {
            collided = true;
            LastCollidedPlayer.GetComponent<Player>().ChangeShifts(-1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Box") && Recovery.position != transform.position)
            player.GetComponent<Player>().EndMoves(true);
        if (collision.gameObject.tag == "Wall")
        {
            EndMoves();
        }
        if (collision.gameObject.tag == "Box" && Recovery.position != transform.position)
        {
            EndMoves();
        }
    }
    public void RestartLevel()
    {
        gameObject.transform.position = StartPoint.position;
        Target.transform.position = transform.position;
        Recovery.transform.position = transform.position;
        GetComponent<SpriteRenderer>().sprite = SpriteVariants[Random.Range(0, SpriteVariants.Length)];
    }

    public void OneStepBack()
    {
        if (lastPositionExact)
        {
            transform.position = lastPositionExact.transform.position;
            Target.position = transform.position;
            Recovery.position = transform.position;
            LastCollidedPlayer.GetComponent<Player>().ChangeShifts(-1);
            Destroy(lastPositionExact);
            if (lastPositionUnexact)
                Destroy(lastPositionUnexact);
        }
        else
            Debug.LogWarning("No step back");
    }

    public void ClearLastPositions()
    {
        if(lastPositionExact)
            Destroy(lastPositionExact);
        if(lastPositionUnexact)
            Destroy(lastPositionUnexact);
    }
}
