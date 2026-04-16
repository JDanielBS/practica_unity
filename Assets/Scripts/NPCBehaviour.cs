using UnityEngine;

public class Npc :MonoBehaviour
{
    void Start()
    {
        
    }

    private void Update()
    {
        
    }

    private void deteccionPlayer()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            this.GetComponent<Animator>().SetBool("Pelear", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            this.GetComponent<Animator>().SetBool("Pelear", false);
        }
    }
}