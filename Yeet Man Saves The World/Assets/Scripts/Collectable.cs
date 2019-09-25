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
        print("IT HURTS, WHY MELINDA!!!!!!!!!!!!!!");
        Destroy(gameObject);

        }
    
}
