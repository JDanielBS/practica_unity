using UnityEngine;

public class Giro : MonoBehaviour
{
    [SerializeField] private float velocidadGiro = 50f;
    [SerializeField] private bool girarEnX = true;
    [SerializeField] private bool girarEnY = true;
    [SerializeField] private bool girarEnZ = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float giroX = girarEnX ? velocidadGiro * Time.deltaTime : 0f;
        float giroY = girarEnY ? velocidadGiro * Time.deltaTime : 0f;
        float giroZ = girarEnZ ? velocidadGiro * Time.deltaTime : 0f;

        transform.Rotate(giroX, giroY, giroZ);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!GetComponent<AudioSource>().isPlaying) {
            GetComponent<AudioSource>().Play();
        }
    }
}
