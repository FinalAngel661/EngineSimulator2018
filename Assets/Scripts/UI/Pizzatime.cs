using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pizzatime : MonoBehaviour
{

    public GameObject Prefab;
    public AudioClip pizzatime;
    private AudioSource source;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;
    public Button SpawnButton;


    // Use this for initialization
    void Start()
    {
        Button btn = SpawnButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        source.PlayOneShot(pizzatime);
        Instantiate(Prefab, spawnPoints[spawnPointIndex].position,
            spawnPoints[spawnPointIndex].rotation);
    }
}
