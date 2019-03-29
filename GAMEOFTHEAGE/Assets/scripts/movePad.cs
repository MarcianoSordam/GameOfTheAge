using UnityEngine;

public class movePad : MonoBehaviour
{
    public float time = 0.1f;
    float x;
    float y;
    float z;
    public float move = 1f;

    private void Start()
    {
        x = transform.position.x;
        y = transform.position.y;
        z = transform.position.z;
        
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(x, y, z), time);
    }

    public void moveX()
    {
        x = x + move;
    }
    public void moveBackX()
    {
        x = x - move;
    }
    
    public void moveY()
    {
        y = y + move;
    }

    public void moveBackY()
    {
        y = y - move;
    }

    public void moveZ()
    {
        z = z + move;
    }

    public void moveBackZ()
    {
        z = z - move;
    }


}
