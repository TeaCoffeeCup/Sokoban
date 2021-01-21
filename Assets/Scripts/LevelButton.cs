using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour
{
    public int levelNum;
    public GameObject Camera;
    // Start is called before the first frame update
    void Start()
    {
        if (Camera.GetComponent<Saver>().GetLevelPassed(levelNum))
            GetComponent<Image>().color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.GetComponent<Saver>().GetLevelPassed(levelNum))
            GetComponent<Image>().color = Color.green;
    }
}
