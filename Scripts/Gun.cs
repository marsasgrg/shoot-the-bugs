using UnityEngine;

public class Gun : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Bullet()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float speedY = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(0, speedY, 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {

        }
    }
}
