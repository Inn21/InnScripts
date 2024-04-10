using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class GPU_Inctancing_Activator : MonoBehaviour
{
    private void Awake()
    {
        MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.SetPropertyBlock(materialPropertyBlock);
    }
}
