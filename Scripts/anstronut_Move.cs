using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anstronut_Move : MonoBehaviour
{
   

   // The minimum and maximum values for the character's speed
    public float minSpeed = 1f;
    public float maxSpeed = 5f;

    // The minimum and maximum values for the character's movement direction
    public float minDirection = -1f;
    public float maxDirection = 1f;

    // Update is called once per frame
    void Update()
    {

        // Generate a random speed and direction for the character
        float speed = Random.Range(minSpeed, maxSpeed);
        float directionX = Random.Range(minDirection, maxDirection);
        float directionY = Random.Range(minDirection, maxDirection);

       // Calculate the character's movement
        var step = speed * Time.deltaTime; 
        transform.Translate(new Vector3(directionX, directionY, 0) * step);
    }
}
