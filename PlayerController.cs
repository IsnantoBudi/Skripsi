using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{

    public InteracTable focus;
    public LayerMask movementMask;
    Camera cam;

    PlayerMotor motor;

    void Start()
    {
        cam = Camera.main;
        motor = GetComponent<PlayerMotor>();
    }

    // Update is called once per frame
    void Update()
    {
     

        // tekan layar untuk menentukan lokasi yang akan dituju 
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = cam.ScreenPointToRay(Input.touches[0].position);  
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100, movementMask))
            {
                // player bergerak kearah click mouse
                motor.MoveToPoint(hit.point);

                RemoveFocus();

            }
            // mengecek apakah object yang di klik  memicu class interactable
            if (Physics.Raycast(ray, out hit, 100))
            {
                InteracTable interactable = hit.collider.GetComponent<InteracTable>();
                if (interactable != null)                                               
                {
                    SetFocus(interactable);
                }

            }
        }

     /*  // bagian untuk pakai mouse
        // Klik kiri
       if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100, movementMask))
            {
                // player bergerak kearah click mouse
                motor.MoveToPoint(hit.point);

                RemoveFocus();

            }
        }

        //klik kanan
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                InteracTable interactable = hit.collider.GetComponent<InteracTable>();
                if (interactable != null)
                {
                    SetFocus(interactable);
                }

            }
        }
        */


    }
    void SetFocus(InteracTable newFocus)
    {
        if (newFocus != focus)
        {
            if (focus != null)
                focus.OnDefocused();

            focus = newFocus;
            motor.FollowTarget(newFocus);
        }
       
        newFocus.OnFocused(transform);
        
    }
    void RemoveFocus()
    {
        if(focus != null)
            focus.OnDefocused();
        
        focus = null;
        motor.StopFollowingTarget();
    }
}
