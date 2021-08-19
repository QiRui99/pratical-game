using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenGems : MonoBehaviour
{
    GameController gc;
    int gemValue = 20;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
            gc.changeScore(gemValue);

            Destroy(this.gameObject);
            Debug.Log("Enter Collider Gen");
        }
    }
}
