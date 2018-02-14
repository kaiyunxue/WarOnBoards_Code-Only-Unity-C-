using UnityEngine;
using System.Collections;

public class RoundController : MonoBehaviour {
    public void turnToRound(int num)
    {
        Application.LoadLevel(num);
    }
}
