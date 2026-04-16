using UnityEngine;

public class KeyBehaviour : MonoBehaviour
{
	[SerializeField] private float volumenRecogida = 1f;
	[SerializeField] private float delayDestruccion = 0.09f;

	private void OnTriggerEnter(Collider other)
	{
		if (!other.TryGetComponent(out PirateBehaviour player))
		{
			return;
		}

		player.AddKey();

		AudioSource audioLlave = GetComponent<AudioSource>();
		if (audioLlave != null && audioLlave.clip != null)
		{
			AudioSource.PlayClipAtPoint(audioLlave.clip, transform.position, volumenRecogida);
		}

		Destroy(gameObject, delayDestruccion);
	}
}
