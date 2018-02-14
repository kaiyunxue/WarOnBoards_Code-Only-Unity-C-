using UnityEngine;
using System.Collections;

public class IconController : MonoBehaviour {
    public GameObject go;
    Transform[] gos = new Transform[100];
    private void Start()
    {
        int num = go.transform.childCount;
        for (int i = 0; i < num; i++)
            gos[i] = go.transform.GetChild(i);
    }
    public void StartRound(int i)
    {
        IconGettingBit(i);
    }
    private void IconGettingBit(int i)
    {
        StartCoroutine(IconGetBig(i));
    }
    IEnumerator IconGetBig(int i)
    {
        gos[i].transform.localScale = gos[i].localScale * 1.3f;
        yield return null;
        if(gos[i].localScale.x<10000)
            StartCoroutine(IconGetBig(i));
        else
        {
            PlayerPrefs.SetInt("difficulty", i);
            if(i == 0)
            {
                Application.LoadLevel("Main_teaching");
            }
            else
            {
                Application.LoadLevel("Main");
            }
        }
    }
}
