using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnOnClick : MonoBehaviour {

    public GameObject Prefab;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;
    public Button SpawnButton;

    // Use this for initialization
    void Start ()
    {
        Button btn = SpawnButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
	
	// Update is called once per frame
	void TaskOnClick()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        
        Instantiate(Prefab, spawnPoints[spawnPointIndex].position, 
            spawnPoints[spawnPointIndex].rotation);
    }
}
