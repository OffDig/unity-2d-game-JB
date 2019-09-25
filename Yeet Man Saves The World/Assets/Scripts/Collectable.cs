using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        HandleCollected();
    }
 
    // Update is called once per frame
        void HandleCollected()
        {
        CollectableManger.Instance.HandleCoinCollected();
        print("Hello darkness, my old friend I've come to talk with you again");
        Destroy(gameObject);

        }
    
}
