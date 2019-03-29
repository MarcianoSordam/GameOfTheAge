using UnityEngine;

public class stageTrigger : MonoBehaviour
{
    public StageBorder border;
    public AudioSource music;
    public float volume = 1f;
    public float time = 0.1f;

    private void Start()
    {
        music.volume = 0f;
    }


    public void OnTriggerEnter(Collider other)
    {
        border.nextStage();
        music.volume = volume;
    }
}
