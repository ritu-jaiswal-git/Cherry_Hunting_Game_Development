using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
private void OnTriggerEnter2D(Collision2D collision)
    {
         if (collision.gameObject.name == "Player")
        {
        collision.gameObject.transform.SetParent(transform);
        }
    }
    
private void OnTriggerExit2D(Collision2D collision)
    {
         if (collision.gameObject.name == "Player")
        {
        collision.gameObject.transform.SetParent(null);
        }
    }

}