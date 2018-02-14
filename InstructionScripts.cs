using UnityEngine;
using System.Collections;

public class InstructionScripts : MonoBehaviour {
    public isVictory isv;
    public GameObject[] go = new GameObject[2];
	// Use this for initialization
	void Start () {
        StartCoroutine(instruct());
	}
	IEnumerator instruct()
    {
        Instructuin.instance.info("Welcome to the War On Boards.");
        yield return new WaitForSeconds(5);
        Instructuin.instance.info("Now drive the tank, kill the enemy and get the score!");
        yield return new WaitForSeconds(3);
        Instructuin.instance.info("Now, press 'W' to move forward.");
        yield return new WaitForSeconds(0.7f);
        StartCoroutine(tryGoforward());
    }
    IEnumerator tryGoforward()
    {
        yield return null;
        if (Input.GetKey(KeyCode.W))
        {
            Instructuin.instance.info("Great!");
            yield return new WaitForSeconds(2);
            Instructuin.instance.info("Now, press 'S' to move forward.");
            yield return new WaitForSeconds(1f);
            StartCoroutine(tryGoBackward());
        }
        else
        {
            StartCoroutine(tryGoforward());
        }

    }
    IEnumerator tryGoBackward()
    {
        yield return null;
        if (Input.GetKey(KeyCode.S))
        {
            Instructuin.instance.info("Great!");
            yield return new WaitForSeconds(2);
            Instructuin.instance.info("Now, press 'A' or 'D' with the 'W' or 'S' to change the move direction.");
            yield return new WaitForSeconds(3);
            Instructuin.instance.info("Great!");
            yield return new WaitForSeconds(1);
            Instructuin.instance.info("Now, click the left mouse button to fire!");
            StartCoroutine(tryClick());
        }
        else
        {
            StartCoroutine(tryGoBackward());
        }
    }
    IEnumerator tryClick()
    {
        yield return null;
        if (Input.GetMouseButton(0))
        {
            Instructuin.instance.info("Great!");
            yield return new WaitForSeconds(2);
            Instructuin.instance.info("Now, press 'V' to change the weapon.");
            yield return new WaitForSeconds(1f);
            StartCoroutine(tryV());
        }
        else
        {
            StartCoroutine(tryClick());
        }
    }
    IEnumerator tryV()
    {
        yield return null;
        if (Input.GetKey(KeyCode.V))
        {
            Instructuin.instance.info("Great!");
            yield return new WaitForSeconds(2);
            Instructuin.instance.info("Now, press 'Q' to show/hide the map.");
            StartCoroutine(tryQ());
        }
        else
        {
            StartCoroutine(tryV());
        }
    }
    IEnumerator tryQ()
    {
        yield return null;
        if (Input.GetKey(KeyCode.Q))
        {
            Instructuin.instance.info("Great!");
            yield return new WaitForSeconds(2);
            Instructuin.instance.info("If you look at the green map on the right, you could see the enemies as the red points.");
            go[1].SetActive(true);
            go[0].SetActive(true);
            isv.enabled = true;
            yield return new WaitForSeconds(3);
            Instructuin.instance.info("Now kill the enemies!");
        }
        else
        {
            StartCoroutine(tryQ());
        }
    }
}
