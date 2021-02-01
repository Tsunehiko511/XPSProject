using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float inputX;
    float inputZ;

    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputZ = Input.GetAxis("Vertical");
        transform.position += (transform.forward * inputZ + transform.right * inputX)*Time.deltaTime;

        animator.SetFloat("inputX", inputX);
        animator.SetFloat("inputZ", inputZ);

        animator.SetFloat("speed", Mathf.Abs(inputX)+ Mathf.Abs(inputZ));
    }
}
