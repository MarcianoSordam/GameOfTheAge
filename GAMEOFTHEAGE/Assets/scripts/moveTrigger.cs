using UnityEngine;

public class moveTrigger : MonoBehaviour
{
    public string direction = "x";

    public movePad pad;

    public void OnTriggerEnter(Collider other)
    {
        if (direction == "x")
        {
            pad.moveX();
        }

        if (direction == "y")
        {
            pad.moveY();
        }

        if (direction == "z")
        {
            pad.moveZ();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (direction == "x")
        {
            pad.moveBackX();
        }

        if (direction == "y")
        {
            pad.moveBackY();
        }

        if (direction == "z")
        {
            pad.moveBackZ();
        }
    }
}
