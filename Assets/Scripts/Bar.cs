using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour
{
    public int moveSpd = 10;
    float xDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xDirection = Input.GetAxisRaw("Horizontal");
        float moveStep = moveSpd * xDirection * Time.deltaTime;
        if ((transform.position.x >= 8.78F) && xDirection > 0 || (transform.position.x <= -8.78F) && xDirection < 0)
            return;

        transform.position = transform.position + new Vector3(moveStep, 0, 0);
      



    }
}
