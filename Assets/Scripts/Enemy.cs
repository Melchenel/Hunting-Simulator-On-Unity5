using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Enemy : MonoBehaviour {
    private NavMeshAgent agent;
    public GameObject player;
    private Transform target;
    public Slider slider;
    public int distance = 10;


    private GameObject point;
    public GameObject point1;
    public GameObject point2;
    public GameObject point3;
    public bool f = false;

	void Start () {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindWithTag("Player");
        slider.value = 100; 
	}

    private void Update()
    {   point1.tag = "targetPoint";

        point = GameObject.FindWithTag("targetPoint");
        if ((player.transform.position - agent.transform.position).sqrMagnitude < 100)
        {
            target = player.transform;
            f = true;
        }
        else
        {
            target = point.transform;
        }


        if (f == true)
        {
            agent.SetDestination(target.position);

            if ((player.transform.position - agent.transform.position).sqrMagnitude < distance)
            {
                slider.value -= 2 * Time.deltaTime;
            }
            if (slider.value == 0)
            {
                SceneManager.LoadScene("1");
            }
            f = false;
        }

        if (f == false){
            agent.SetDestination(target.position); 
        }


            if ((point1.transform.position - agent.transform.position).sqrMagnitude <= 5)
            {
                
                point1.tag = "Point1";
                point2.tag = "targetPoint";
                
            }

            if ((point2.transform.position - agent.transform.position).sqrMagnitude <= 5)
            {

                point2.tag = "Point2";
                point3.tag = "targetPoint";
               

            }
            if ((point3.transform.position - agent.transform.position).sqrMagnitude <= 5)
            {

                point3.tag = "Point3";
                point1.tag = "targetPoint";
            }

    }	
}