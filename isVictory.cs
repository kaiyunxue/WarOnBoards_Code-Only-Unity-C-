using UnityEngine;
using System.Collections;

public class isVictory : MonoBehaviour {
    private int enemycount;
    public GameObject go;
    // Use this for initialization
    void Start () {
        enemycount = GameObject.FindGameObjectsWithTag("Enemy").Length;
    }
	
	// Update is called once per frame
	void Update () {
        enemycount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        if(enemycount == 0)
        {
            go.SetActive(true);
        }
    }
}
