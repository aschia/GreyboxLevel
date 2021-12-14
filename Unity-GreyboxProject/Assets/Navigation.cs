using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navigation : MonoBehaviour
{
    [SerializeField] Transform target;
    Vector3 origin;
    [SerializeField] NavMeshAgent agent;
    [SerializeField] float updateDelay = .3f;
    [SerializeField] int chaseRange = 20;
    public bool isChase = false;

    // Start is called before the first frame update
    void Reset()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    /*void Update()
    {
        agent.SetDestination(target.position);
    }*/

    private void Start()
    {
        origin = this.transform.position;

        InvokeRepeating("FollowTarget", 0f, updateDelay);
    }

    void FollowTarget()
    {
        if (Vector3.Distance(target.position, this.transform.position) <= chaseRange)
        {
            agent.SetDestination(target.position);
            isChase = true;
        }
        else if (isChase)
        {
            agent.SetDestination(origin);
            isChase = false;
        }
    }
}
