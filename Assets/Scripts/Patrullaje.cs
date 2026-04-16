using UnityEngine;
using UnityEngine.AI;

public class Patrullaje : MonoBehaviour
{
    NavMeshAgent agente;
    int i;
    public GameObject[] puntosDePatrulla;

    void Start()
    {
        agente = this.GetComponent<NavMeshAgent>();
        i = 0;
    }

    void Update()
    {
        navegar();
    }

    public void navegar()
    {
        agente.SetDestination(this.puntosDePatrulla[i].transform.position);
        float distancia = Vector3.Distance(this.transform.position, this.puntosDePatrulla[i].transform.position);
        if (distancia < 4f)
        {
            i += 1;
            if (i > 1)
            {
                i = 0;
            }
        }
    }
}