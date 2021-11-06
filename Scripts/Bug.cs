using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug : MonoBehaviour
{
    public float speedX;
    bool dup1;
    bool dup2;
    bool dup3;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(speedX,0 , 0);
        if (transform.position.x > -5){
            if (!dup1){
                Instantiate(this);
            }
            else if (transform.position.x > -1)
            {
                if (!dup2)
                {
                    Instantiate(this);
                }
                else if (transform.position.x > 3)
                {
                    if (!dup3)
                    {
                        Instantiate(this);
                    }
                }
            }
        }
    }
    private void Awake()
    {
        dup1 = false;
        dup2 = false;
        dup3 = false;
        double result;
        System.Random rd = new System.Random();
        result = rd.NextDouble();
        result *= 7;
        result -= 3.5;
        transform.position = new Vector3(-7, System.Convert.ToSingle(result), 0);
    }
}
