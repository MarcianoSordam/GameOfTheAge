using UnityEngine;

public class LightTurnOn : MonoBehaviour
{

    public Light lightOn;
    public Target target;

    public void Start()
    {
        target.OnHit += TurnOn;
    }

    private void OnDisable()
    {
        target.OnHit -= TurnOn;
    }

    public void TurnOn()
    {
        lightOn.enabled = true;
    }
        
}
