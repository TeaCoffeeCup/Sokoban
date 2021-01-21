using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueTile : MonoBehaviour
{
    public GameObject Camera;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Continue");
        if (collision.tag == "Box" || collision.tag == "Player")
        {
            int recentlyPassed = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Saver>().GetRecentlyPassedLevel();
            switch (recentlyPassed + 1)
            {
                case 1:
                    Camera.GetComponent<LevelSelector>().ChangeTo1();
                    break;
                case 2:
                    Camera.GetComponent<LevelSelector>().ChangeTo2();
                    break;

                case 3:
                    Camera.GetComponent<LevelSelector>().ChangeTo3();
                    break;

                case 4:
                    Camera.GetComponent<LevelSelector>().ChangeTo4();
                    break;

                case 5:
                    Camera.GetComponent<LevelSelector>().ChangeTo5();
                    break;

                case 6:
                    Camera.GetComponent<LevelSelector>().ChangeTo6();
                    break;

                case 7:
                    Camera.GetComponent<LevelSelector>().ChangeTo7();
                    break;

                case 8:
                    Camera.GetComponent<LevelSelector>().ChangeTo8();
                    break;

                case 9:
                    Camera.GetComponent<LevelSelector>().ChangeTo9();
                    break;

                case 10:
                    Camera.GetComponent<LevelSelector>().ChangeTo10();
                    break;

            }
        }
    }
}

