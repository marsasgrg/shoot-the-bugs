using UnityEngine;

public class Gun : MonoBehaviour
{
    public float speed;
    public GameObject bullet;
    // Start is called before the first frame update
    void Bullet()
    {
        GameObject newbull = Instantiate(bullet);
        newbull.transform.position = new Vector3(System.Convert.ToSingle(-0.566), System.Convert.ToSingle(this.transform.position.y + 0.071));
        newbull.GetComponent<Bullet>().StartFlying();
    }

    // Update is called once per frame
    void Update()
    {
        float speedY = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(0, speedY, 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Bullet();
        }
    }
}
