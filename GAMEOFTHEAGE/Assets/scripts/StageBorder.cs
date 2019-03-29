using UnityEngine;

public class StageBorder : MonoBehaviour
{
    public float speed = 0.1f;
    public float size = 8f;
    float x;
    float y;
    float z;

    private void Start()
    {

        x = transform.localScale.x;
        y = transform.localScale.y;
        z = transform.localScale.z;

    }

    private void Update()
    {
        transform.localScale = Vector3.MoveTowards(transform.localScale, new Vector3(x, y, z), speed);
    }

    public void nextStage()
    {
        x = size;
        z = size;
    }

}
