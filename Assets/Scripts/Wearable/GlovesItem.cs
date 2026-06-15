using UnityEngine;

public class GlovesItem : MonoBehaviour
{
    [SerializeField] private SkinnedMeshRenderer LeftHandMeshRenderer;
    [SerializeField] private SkinnedMeshRenderer rightHandMeshRenderer;
    [SerializeField] private Material gloveMatreal;
    private bool changeAble;
    public void TakeItem()
    {
        if (changeAble)
        {
            ChangeGloves();
            Destroy(gameObject);
        }
    }
    private void ChangeGloves()
    {
        LeftHandMeshRenderer.material = gloveMatreal;
        rightHandMeshRenderer.material = gloveMatreal;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hand")
        {
            changeAble = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Hand")
        {
            changeAble = false;
        }
    }

}
