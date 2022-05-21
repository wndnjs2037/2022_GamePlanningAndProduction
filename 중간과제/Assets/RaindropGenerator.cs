using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaindropGenerator : MonoBehaviour
{
    public GameObject raindropPrefab;
    float span = 0.5f;
    float delta = 0;

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(raindropPrefab) as GameObject;
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 10, 0);
        }
    }
}