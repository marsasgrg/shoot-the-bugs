using UnityEngine;

public class Bullet : MonoBehaviour
{
    public bool flying;
    public float speed;
    public void StartFlying()
    {
        this.gameObject.SetActive(true);
        flying = true;
    }
    private void Update()
    {
        if (flying)
        {
            transform.Translate(-speed, 0, 0);
        }
    }
}


