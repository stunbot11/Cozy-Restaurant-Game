using UnityEngine;

public abstract class GameObj : IInteractable
{
    public void OnInteract()
    {
        Debug.LogError("This object does not overide OnInteract");
    }
}
