using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TierraCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "apple")
        {
            Destroy(collision.gameObject);
        }
    }
}
