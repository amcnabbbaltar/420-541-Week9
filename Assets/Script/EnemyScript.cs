using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
public class EnemyScript : MonoBehaviour
{
    public GameObject player;
    public bool isPlayerInAttackRange;
    public NavMeshAgent agent;
    public float maxAngle = 45;
    public float maxDistance = 10;
    public float timer = 1.0f;
    public float visionCheckRate = 1.0f;
    public Transform[] points;
    private int destPoint = 0;
    private Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    
    // Update is called once per frame
    void Update()
    { 

    }

    void GotoNextPoint() {

        
    }

    public bool SeePlayer()
    {
       return false;
    }
    
    public bool HasReachedDestination()
    {

		return false;
    }

    private void OnTriggerEnter(Collider col)
    {
        
    }
    
    private void OnTriggerExit(Collider col)
    {

        
    }
    public void StopMovement()
    {
        
    }
    public void ResumeMovement()
    {
        
    }
    public void HitPlayer()
    {

        
        
    }
}
