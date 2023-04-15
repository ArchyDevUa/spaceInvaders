using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementRestriction : MonoBehaviour
{
    
    

    // Update is called once per frame
    void LateUpdate()
    {
        if (transform.position.x > 6.75f)
        {
            transform.position = new Vector2(6.75f, transform.position.y);
        }else if (transform.position.x < -6.75f)
        {
            transform.position = new Vector2(-6.75f, transform.position.y);
        }

        if (transform.position.y > 4.2f)
        {
            transform.position = new Vector2(transform.position.x,4.2f);
        }else if (transform.position.y < -4.2f)
        {
            transform.position = new Vector2(transform.position.x,-4.2f);
        }
    }
}
