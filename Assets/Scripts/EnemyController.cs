using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject objective;
    public Vector2 speedReference;
    
    void Update()
    {
        transform.position = Vector2.SmoothDamp(transform.position, objective.transform.position, ref speedReference, 0.5f);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Node") 
        {
            objective = collision.gameObject.GetComponent<NodeController>().SelecRandomAdjancent().gameObject;
        }
    }
}