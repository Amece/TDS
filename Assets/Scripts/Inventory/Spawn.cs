using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    private Transform playerPos;
    public GameObject item;

    private void Start()
    {
       playerPos = GameObject.FindGameObjectWithTag("PlayerPos").GetComponent<Transform>();
    }

    public void SpawnDroppedItem() {
        Instantiate(item, playerPos.position, Quaternion.identity);
    }
}
