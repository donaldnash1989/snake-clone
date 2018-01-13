using UnityEngine;

public class pickup : MonoBehaviour {

    public GameObject segment;

    public AudioClip pickupSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("PlayerHitbox") || other.tag.Equals("PlayerSegment"))
        {
            GameObject seg = Instantiate(segment);
            seg.GetComponent<Segment>().id = Player.GetInstance().GetSegments();
            Player.GetInstance().AddSegment();
            SpawnPoint.nextSpawn = true;
            AudioManager.PlaySoundEffect(pickupSound);
            Destroy(gameObject);
        }
    }
}
