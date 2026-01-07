using UnityEngine;

public class ArtPiece : MonoBehaviour
{
    public GameObject currentArt;

    public void ChangePiece(GameObject piece)
    {
        if (currentArt != null) Destroy(currentArt);
        currentArt = Instantiate(piece, transform);
        currentArt.transform.localPosition = Vector3.zero;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, 0.1f);
    }
}
