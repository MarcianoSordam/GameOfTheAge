using UnityEngine;

public class Target : MonoBehaviour
{
    public AudioSource Instrument;
    // makes an audio scource

    public System.Action OnHit;
    // makes a function that is called on hit

    public float size = 1f;
    public float time = 0.1f;

    private void Update()
    {
        transform.localScale = Vector3.MoveTowards(transform.localScale, new Vector3(size, size, size),time);
    }

    /*
    public void TakeDamage()
    {
        if(OnHit != null)
        {
            OnHit.Invoke();
            Instrument.volume = 1f;
            Instrument.maxDistance = 500f;
            size += 1f;
        }

    }
    */

}