using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Instructuin : MonoBehaviour {
    public static Instructuin instance;
    private void Awake()
    {
        instance = this;
    }
    public void info(string i)
    {
        this.gameObject.GetComponent<Text>().text = i;
    }
}
