
using UnityEngine;

public class ClosePortal : MonoBehaviour
{
    [SerializeField] private Animator portalE;
    [SerializeField] private GameObject portal;
    [SerializeField] private GameObject invisibilty;
    private bool done;

    private void FixedUpdate()
    {
        if (portalE.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f && done == false)
        {
            done = true;
            Deactivate();
        }
    }

    private void Deactivate()
    {
        portal.SetActive(false);
        invisibilty.SetActive(false);
    }
}
