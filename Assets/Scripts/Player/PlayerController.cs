using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;
    private Vector2 curMovementInput;
    public float jumpForce;
    public float superJumpForce;

    public LayerMask groundLayerMask;
    public LayerMask jumpzoneLayerMask;

    [Header("Look")]
    public Transform cameraContainer;
    public float minXLook;
    public float maxXLook;
    private float camCurXRot;
    public float lookSensitivity;

    private Vector2 mouseDelta;

    [HideInInspector]
    public bool canLook = true;

    private Rigidbody rigidbody;
    public Action inventory;


    private Coroutine coroutine;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        CharacterManager.Instance.Player.condition.onBuff += BuffSpeed;
        CharacterManager.Instance.Player.condition.onBuff += BuffJump;
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void LateUpdate()
    {
        if (canLook)
        {
            CameraLook();
        }
    }

    public void OnLookInput(InputAction.CallbackContext context)
    {
        mouseDelta = context.ReadValue<Vector2>();
    }

    public void OnMoveInput(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            curMovementInput = context.ReadValue<Vector2>();
        }
        else if (context.phase == InputActionPhase.Canceled)
        {
            curMovementInput = Vector2.zero;
        }
    }

    public void OnJumpInput(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started && IsGrounded())
        {
            rigidbody.AddForce(Vector2.up * jumpForce, ForceMode.Impulse);
        }
    }

    private void Move()
    {
        Vector3 dir = transform.forward * curMovementInput.y + transform.right * curMovementInput.x;
        dir *= moveSpeed;
        dir.y = rigidbody.velocity.y;

        rigidbody.velocity = dir;

        if(IsJumpZone())
        {
            rigidbody.AddForce(Vector2.up * superJumpForce, ForceMode.Impulse);
        }
    }

    void CameraLook()
    {
        camCurXRot += mouseDelta.y * lookSensitivity;
        camCurXRot = Mathf.Clamp(camCurXRot, minXLook, maxXLook);
        cameraContainer.localEulerAngles = new Vector3(-camCurXRot, 0, 0);

        transform.eulerAngles += new Vector3(0, mouseDelta.x * lookSensitivity, 0);
    }

    bool IsGrounded()
    {
        Ray[] rays = new Ray[4]
        {
            new Ray(transform.position + (transform.forward * 0.05f) + (transform.up * 0.05f), Vector3.down),
            new Ray(transform.position + (-transform.forward * 0.05f) + (transform.up * 0.05f), Vector3.down),
            new Ray(transform.position + (transform.right * 0.05f) + (transform.up * 0.05f), Vector3.down),
            new Ray(transform.position + (-transform.right * 0.05f) +(transform.up * 0.05f), Vector3.down)
        };

        for (int i = 0; i < rays.Length; i++)
        {
            if (Physics.Raycast(rays[i], 0.2f, groundLayerMask))
            {
                return true;
            }
        }
        
        return false;
    }
    bool IsJumpZone()
    {
        Ray[] rays = new Ray[4]
        {
            new Ray(transform.position + (transform.forward * 0.05f) + (transform.up * 0.05f), Vector3.down),
            new Ray(transform.position + (-transform.forward * 0.05f) + (transform.up * 0.05f), Vector3.down),
            new Ray(transform.position + (transform.right * 0.05f) + (transform.up * 0.05f), Vector3.down),
            new Ray(transform.position + (-transform.right * 0.05f) +(transform.up * 0.05f), Vector3.down)
        };

        for (int i = 0; i < rays.Length; i++)
        {
            if (Physics.Raycast(rays[i], 0.1f, jumpzoneLayerMask))
            {
                return true;
            }
        }

        return false;
    }

    public void OnInventoryButton(InputAction.CallbackContext callbackContext)
    {
        if (callbackContext.phase == InputActionPhase.Started)
        {
            inventory?.Invoke();
            ToggleCursor();
        }
    }

    void ToggleCursor()
    {
        bool toggle = Cursor.lockState == CursorLockMode.Locked;
        Cursor.lockState = toggle ? CursorLockMode.None : CursorLockMode.Locked;
        canLook = !toggle;
    }

    public void BuffSpeed(float additionalSpeed)
    {
        coroutine = StartCoroutine(IncreaseMoveSpeed(additionalSpeed));
    }
    public void BuffJump(float additionalJump)
    {
        coroutine = StartCoroutine(IncreaseJump(additionalJump));
    }
    private IEnumerator IncreaseMoveSpeed(float alpha)
    {
        float curSpeed = moveSpeed;

        moveSpeed *= alpha;

        yield return new WaitForSeconds(5f);

        moveSpeed /= alpha;
    }

    private IEnumerator IncreaseJump(float alpha)
    {
        float curJumpPower= jumpForce;

        jumpForce *= alpha;

        yield return new WaitForSeconds(5f);

        jumpForce /= alpha;
    }
}