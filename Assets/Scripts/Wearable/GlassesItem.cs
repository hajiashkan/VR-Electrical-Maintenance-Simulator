using UnityEngine;

public class GlassesItem : MonoBehaviour
{
    private bool takeAble;
    public void TakeItem()
    {
        if (takeAble)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hand")
        {
            takeAble = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Hand")
        {
            takeAble = false;
        }
    }

}
