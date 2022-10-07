using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_OmniController : TurnBasedObject
{
    //--- PLAYER ACTIONS ---\\\
    [HideInInspector] public Player_Movement PMove = new Player_Movement();
    [HideInInspector] public Player_Jump PJump = new Player_Jump();
    [HideInInspector] public Player_Look PLook = new Player_Look();
    [HideInInspector] public Player_InventoryControl PInventory = new Player_InventoryControl();
    [HideInInspector] public Player_Aim PAim = new Player_Aim();
    [HideInInspector] public Player_Health PHealth = new Player_Health();
    [HideInInspector] public Player_Freeze PFreeze = new Player_Freeze();

    //--- COMPONENTS ---\\\
    [HideInInspector] public Rigidbody rb;
    [HideInInspector] public TurnController TurnController;

    //--- PUBLIC VARIABLES ---\\\
    [Range(1f, 10f)] public float Speed;
    [Range(0.01f, 5f)] public float LookSensitivityHorizontal;
    [Range(0.01f, 5f)] public float LookSensitivityVertical;
    public Transform HeadCam;
    public GameObject PickupHolder;
    public GameObject DefaultPickup;
    public Transform ManHolder;

    [HideInInspector] public Camera MainCamera;

    //--- PRIVATE VARIABLES ---\\\
    private bool _active = false;

    void Start()
    {
        MainCamera = Camera.main;
        TurnController = FindObjectOfType<TurnController>();
        rb = gameObject.GetComponent<Rigidbody>();
        PInventory.OnStart(this);
        PLook.OnStart(this);
    }

    void Update()
    {
        if (_active == true)
        {
            PInventory.UpdateState(this);
        }
    }

    private void FixedUpdate()
    {
        if(_active == true)
        {
            PMove.UpdateState(this);
            PFreeze.UpdateState(this);
        }
    }

    private void LateUpdate()
    {
        if(_active == true)
        {
            PLook.UpdateState(this);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(_active == true)
        {
            PInventory.OnCollisionEnter(this, other);
            PFreeze.OnCollisionEnter(this, other);
        }
    }

    public override Transform ObjectCamera()
    {
        return HeadCam;
    }

    public override bool AffectedByTimer()
    {
        return true;
    }

    public override void StartTurn() 
    {
        _active = true;
        PFreeze.OnStartTurn(this);
    }

    public override void EndTurn()
    {
        _active = false;
        PMove.OnReset(this);
        PLook.OnReset(this);
        PInventory.OnReset(this);

        if(PFreeze.IsInSafeZone == true)
        {
            PHealth.Heal(10f, this);
        }

        TurnController.NextTurn();
    }
}
