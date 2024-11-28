using UnityEngine;

public class DoorBeh : MonoBehaviour
{
    public Animator doorAnimator;
    public bool isOpen = false;

    void Start()
    {
        // Get the Animator component attached to the door GameObject
        doorAnimator = GetComponent<Animator>();
        if (doorAnimator == null)
        {
            Debug.LogError("Animator component missing on this door!");
        }
    }

    // Method to open the door
    public void OpenDoor()
    {
        if (!isOpen && doorAnimator != null)
        {
            isOpen = true;


            this.gameObject.GetComponent<MeshCollider>().enabled = false;

            doorAnimator.SetBool("isOpen", true);
            doorAnimator.SetBool("character_nearby", true);
        }
    }

    // Method to close the door
    public void CloseDoor()
    {
        if (isOpen && doorAnimator != null)
        {
            isOpen = false;
            doorAnimator.SetBool("isOpen", false);
        }
    }

    // Toggle door state
    public void ToggleDoor()
    {
        if (isOpen)
            CloseDoor();
        else
            OpenDoor();
    }



    //need something like, when i hit the door

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Player")
        {
            ToggleDoor();


        }

    }

}