using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AutoBattler : MonoBehaviour
{
    public bool enable;
    NavMeshAgent nav;

    // Start is called before the first frame update
    void Start()
    {
      nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(enable)
        {
          nav.SetDestination(transform.position);
        }
    }
}
