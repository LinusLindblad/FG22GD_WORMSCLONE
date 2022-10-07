using System.Collections.Generic;
using UnityEngine;


public class MovingElevator : MonoBehaviour
{
     //private List<Transform> _waypoints;
     private int _currentWaypoint;
     
     [SerializeField] private List<GameObject> _waypoints;
     [SerializeField] private GameObject _platform;
     [SerializeField] private float _moveSpeed = 2f;


     private void Start()
     {
          if (_waypoints.Count > 0)
          {
               _currentWaypoint = 1;
          }
          
          

     }

     private void FixedUpdate()
     {
          HandleMovement();
          Debug.LogWarning(_waypoints.Count);
     }

     private void HandleMovement()
     {
          
          transform.position = Vector3.MoveTowards(_platform.transform.position, _waypoints[_currentWaypoint].transform.position,
               (_moveSpeed * Time.deltaTime));

          if (_platform.transform.position == _waypoints[_currentWaypoint].transform.position)
          {
               Debug.LogWarning("Hit waypoint, reversing");
               _currentWaypoint = 0;    
               _waypoints.Reverse();
          }
     }
}
