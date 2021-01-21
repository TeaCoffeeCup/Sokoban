using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject Point;
    public List<Crate> boxes = new List<Crate>();
    private GameObject lastPositionExact, lastPositionUnexact;
    private bool collided = false;
    public Crate MovedBox = null;
    private ArrayList Moves_Order = new ArrayList();
    public float speed;
    private bool EndMove = true;
    private bool Moving = false;
    public bool Moved = false;
    public bool canMove = true;
    public bool Paused = false;
    public AudioClip StepSound;
    private Transform StartPoint, LastPos, targetPoint;
    public int DirectionOnCamera = 4;
    public int steps, shifts;
    private int direction = 2; // 0-right 1-left 2-down 3-up all num+4 - idle
    // Start is called before the first frame update
    void Start()
    {
        targetPoint = Instantiate(Point, transform.position, transform.rotation).GetComponent<Transform>();
        StartPoint = Instantiate(Point, transform.position, transform.rotation).GetComponent<Transform>();
        LastPos = Instantiate(Point, transform.position, transform.rotation).GetComponent<Transform>();
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<LevelSelector>().UpdateShift(0);
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<LevelSelector>().UpdateStep(0);
    }

    // Update is called once per frame
    void Update()
    {
        DirectionOnCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<MainCamera>().ButtonPressed;
        Paused = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Pause>().Paused;
        SetTarget();
        if (transform.position == targetPoint.transform.position)
        {
            if (lastPositionUnexact && !collided)
            {
                Destroy(lastPositionExact);
                lastPositionExact = lastPositionUnexact;
                lastPositionUnexact = null;
                foreach (Crate b in boxes)
                {
                    if (b != MovedBox)
                        b.ClearLastPositions();
                }
            }
            SetOrder(DirectionOnCamera);
            EndMove = true;
            if (Moves_Order.Count == 0)
                Moving = false;
        }
        else
        {
            Moving = true;
            EndMove = false;
        }
        Idle_Check();

        transform.position = Vector3.MoveTowards(transform.position, targetPoint.transform.position, speed * Time.deltaTime);
    }

    public void SetOrder(int Direction)
    {
        if (canMove && !Paused)
        {
            if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow) || Direction == 5)
            {
                Moves_Order.Add(0);
                steps++;
                Moved = true;
                MovedBox = null;
                lastPositionUnexact = Instantiate(Point, transform.position, transform.rotation);
            }
            else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow) || Direction == 1)
            {
                Moves_Order.Add(1);
                steps++;
                Moved = true;
                MovedBox = null;
                lastPositionUnexact = Instantiate(Point, transform.position, transform.rotation);
            }
            else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow) || Direction == 2)
            {
                Moves_Order.Add(2);
                steps++;
                Moved = true;
                MovedBox = null;
                lastPositionUnexact = Instantiate(Point, transform.position, transform.rotation);
            }
            else if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) || Direction == 3)
            {
                Moves_Order.Add(3);
                steps++;
                Moved = true;
                MovedBox = null;
                lastPositionUnexact = Instantiate(Point, transform.position, transform.rotation);
            }
            GameObject.FindWithTag("MainCamera").GetComponent<LevelSelector>().UpdateStep(steps);
        }
    }

    void Idle_Check()
    {
        if (!Moving)
        {
            gameObject.GetComponent<Animator>().SetInteger("State", direction+4);
        }
    }

    void SetTarget()
    {
        if(Moves_Order.Count>0)
            if (EndMove)
            {
                LastPos.position = transform.position;
                switch (Moves_Order[0])
                {
                    case 0:
                        Moving = true;
                        targetPoint.transform.position = new Vector3(targetPoint.transform.position.x + 1.275f, targetPoint.transform.position.y, targetPoint.transform.position.z);
                        gameObject.GetComponent<Animator>().SetInteger("State", 0);
                        direction = 0;
                        break;
                    case 1:
                        Moving = true;
                        targetPoint.transform.position = new Vector3(targetPoint.transform.position.x - 1.275f, targetPoint.transform.position.y, targetPoint.transform.position.z);
                        gameObject.GetComponent<Animator>().SetInteger("State", 1);
                        direction = 1;
                        break;
                    case 2:
                        Moving = true;
                        targetPoint.transform.position = new Vector3(targetPoint.transform.position.x, targetPoint.transform.position.y - 1.275f, targetPoint.transform.position.z);
                        gameObject.GetComponent<Animator>().SetInteger("State", 2);
                        direction = 2;
                        break;
                    case 3:
                        Moving = true;
                        targetPoint.transform.position = new Vector3(targetPoint.transform.position.x, targetPoint.transform.position.y + 1.275f, targetPoint.transform.position.z);
                        gameObject.GetComponent<Animator>().SetInteger("State", 3);
                        direction = 3;
                        break;
                }
                EndMoves();
            }
    }
    public void EndMoves(bool interrupted = false)
    {
        if (interrupted)
        {
            collided = true;
            transform.position = LastPos.position;
            targetPoint.transform.position = transform.position;
            Moves_Order.Clear();
            steps--;
            GameObject.FindWithTag("MainCamera").GetComponent<LevelSelector>().UpdateStep(steps);
        }
        else if (!interrupted)
        {
            collided = false;
            Moves_Order.RemoveAt(0);
        }
        Moving = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            EndMoves(true);
        }
    }

    public void Step()
    {
        GameObject.FindGameObjectWithTag("SFXPlayer").GetComponent<AudioSource>().PlayOneShot(StepSound);
    }

    public void RestartLevel(bool switchedLevel)
    {
        if (!switchedLevel)
            canMove = false;
        gameObject.transform.position = StartPoint.position;
        targetPoint.transform.position = transform.position;
        steps = 0;
        shifts = 0;
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<LevelSelector>().UpdateShift(0);
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<LevelSelector>().UpdateStep(0);
    }

    public void ChangeShifts(int difference)
    {
        shifts += difference;
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<LevelSelector>().UpdateShift(shifts);
    }

    public void OneStepBack()
    {
        if (lastPositionExact)
        {
            transform.position = lastPositionExact.transform.position;
            targetPoint.position = transform.position;
            LastPos.position = transform.position;
            steps--;
            Destroy(lastPositionExact);
            if (lastPositionUnexact)
                Destroy(lastPositionUnexact);
        }
        else
            Debug.LogWarning("No step back");
    }

}
