
using UnityEngine;
using Mirror;

public class SwitchMusicTrigger : MonoBehaviour
{
    public AudioClip newTrack;
    private GameManager gameManager;

    void Start()
    {
		gameManager = FindObjectOfType<GameManager>();
	}


    private void OnTriggerEnter2D(Collider2D other)
	{

		if(other.gameObject.CompareTag("Player"))
		{
			if (newTrack != null)
				if (gameManager == null)
				{
					gameManager = FindObjectOfType<GameManager>();
					gameManager.ChangeBGM(newTrack);
				}else
					gameManager.ChangeBGM(newTrack);
			if (newTrack == null)
				gameManager.ChangeBGM(newTrack);
		}
	}
}
