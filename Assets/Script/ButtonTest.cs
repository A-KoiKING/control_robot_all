using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ButtonTest : MonoBehaviour
{
    private GameInputs _gameInputs;

    public GameObject _circle;
    public GameObject _cross;
    public GameObject _square;
    public GameObject _triangle;
    public GameObject _up;
    public GameObject _down;
    public GameObject _left;
    public GameObject _right;
    public GameObject _r1;
    public GameObject _r2;
    public GameObject _r3;
    public GameObject _l1;
    public GameObject _l2;
    public GameObject _l3;
    public GameObject _option;
    public GameObject _share;

    public GameObject _R;
    public GameObject _L;

    private Image circle;
    private Image cross;
    private Image square;
    private Image triangle;
    private Image up;
    private Image down;
    private Image right;
    private Image left;
    private Image r1;
    private Image r2;
    private Image r3;
    private Image l1;
    private Image l2;
    private Image l3;
    private Image option;
    private Image share;

    public Sprite[] _arrow;
    public Sprite[] _button;
    public Sprite[] _1;
    public Sprite[] _2;
    public Sprite[] _minibutton;

    [SerializeField] private Vector2 _LeftInputValue;
    [SerializeField] private Vector2 _RightInputValue;

    private void Awake()
    {
        // Actionスクリプトのインスタンス生成
        _gameInputs = new GameInputs();

        _gameInputs.Test.Circle.performed += OnCircleStart;
        _gameInputs.Test.Circle.canceled += OnCircleEnd;
        _gameInputs.Test.Cross.performed += OnCrossStart;
        _gameInputs.Test.Cross.canceled += OnCrossEnd;
        _gameInputs.Test.Square.performed += OnSquareStart;
        _gameInputs.Test.Square.canceled += OnSquareEnd;
        _gameInputs.Test.Triangle.performed += OnTriangleStart;
        _gameInputs.Test.Triangle.canceled += OnTriangleEnd;

        _gameInputs.Test.Up.performed += OnUpStart;
        _gameInputs.Test.Up.canceled += OnUpEnd;
        _gameInputs.Test.Down.performed += OnDownStart;
        _gameInputs.Test.Down.canceled += OnDownEnd;
        _gameInputs.Test.Right.performed += OnRightStart;
        _gameInputs.Test.Right.canceled += OnRightEnd;
        _gameInputs.Test.Left.performed += OnLeftStart;
        _gameInputs.Test.Left.canceled += OnLeftEnd;

        _gameInputs.Test.R1.performed += OnR1Start;
        _gameInputs.Test.R1.canceled += OnR1End;
        _gameInputs.Test.R2.performed += OnR2Start;
        _gameInputs.Test.R2.canceled += OnR2End;
        _gameInputs.Test.R3.performed += OnR3Start;
        _gameInputs.Test.R3.canceled += OnR3End;
        _gameInputs.Test.L1.performed += OnL1Start;
        _gameInputs.Test.L1.canceled += OnL1End;
        _gameInputs.Test.L2.performed += OnL2Start;
        _gameInputs.Test.L2.canceled += OnL2End;
        _gameInputs.Test.L3.performed += OnL3Start;
        _gameInputs.Test.L3.canceled += OnL3End;

        _gameInputs.Test.Options.performed += OnOptionStart;
        _gameInputs.Test.Options.canceled += OnOptionEnd;
        _gameInputs.Test.Share.performed += OnShareStart;
        _gameInputs.Test.Share.canceled += OnShareEnd;

        _gameInputs.Test.RightStick.started += OnRight;
        _gameInputs.Test.RightStick.performed += OnRight;
        _gameInputs.Test.RightStick.canceled += OnRight;
        _gameInputs.Test.LeftStick.started += OnLeft;
        _gameInputs.Test.LeftStick.performed += OnLeft;
        _gameInputs.Test.LeftStick.canceled += OnLeft;

        // Input Actionを機能させるためには、
        // 有効化する必要がある
        _gameInputs.Enable();
    }

    // Start is called before the first frame update
    void Start()
    {
        circle = _circle.GetComponent<Image>();
        cross = _cross.GetComponent<Image>();
        square = _square.GetComponent<Image>();
        triangle = _triangle.GetComponent<Image>();
        up = _up.GetComponent<Image>();
        down = _down.GetComponent<Image>();
        right = _right.GetComponent<Image>();
        left = _left.GetComponent<Image>();
        r1 = _r1.GetComponent<Image>();
        r2 = _r2.GetComponent<Image>();
        r3 = _r3.GetComponent<Image>();
        l1 = _l1.GetComponent<Image>();
        l2 = _l2.GetComponent<Image>();
        l3 = _l3.GetComponent<Image>();
        option = _option.GetComponent<Image>();
        share = _share.GetComponent<Image>();
    }

    private void OnDestroy()
    {
        // 自身でインスタンス化したActionクラスはIDisposableを実装しているので、
        // 必ずDisposeする必要がある
        _gameInputs?.Dispose();
    }

    private void OnCircleStart(InputAction.CallbackContext context)
    {
        circle.sprite = _button[1];
    }
    private void OnCircleEnd(InputAction.CallbackContext context)
    {
        circle.sprite = _button[0];
    }
    private void OnCrossStart(InputAction.CallbackContext context)
    {
        cross.sprite = _button[1];
    }
    private void OnCrossEnd(InputAction.CallbackContext context)
    {
        cross.sprite = _button[0];
    }
    private void OnSquareStart(InputAction.CallbackContext context)
    {
        square.sprite = _button[1];
    }
    private void OnSquareEnd(InputAction.CallbackContext context)
    {
        square.sprite = _button[0];
    }
    private void OnTriangleStart(InputAction.CallbackContext context)
    {
        triangle.sprite = _button[1];
    }
    private void OnTriangleEnd(InputAction.CallbackContext context)
    {
        triangle.sprite = _button[0];
    }
    private void OnUpStart(InputAction.CallbackContext context)
    {
        up.sprite = _arrow[1];
    }
    private void OnUpEnd(InputAction.CallbackContext context)
    {
        up.sprite = _arrow[0];
    }
    private void OnDownStart(InputAction.CallbackContext context)
    {
        down.sprite = _arrow[1];
    }
    private void OnDownEnd(InputAction.CallbackContext context)
    {
        down.sprite = _arrow[0];
    }
    private void OnRightStart(InputAction.CallbackContext context)
    {
        right.sprite = _arrow[1];
    }
    private void OnRightEnd(InputAction.CallbackContext context)
    {
        right.sprite = _arrow[0];
    }
    private void OnLeftStart(InputAction.CallbackContext context)
    {
        left.sprite = _arrow[1];
    }
    private void OnLeftEnd(InputAction.CallbackContext context)
    {
        left.sprite = _arrow[0];
    }
    private void OnR1Start(InputAction.CallbackContext context)
    {
        r1.sprite = _1[1];
    }
    private void OnR1End(InputAction.CallbackContext context)
    {
        r1.sprite = _1[0];
    }
    private void OnR2Start(InputAction.CallbackContext context)
    {
        r2.sprite = _2[1];
    }
    private void OnR2End(InputAction.CallbackContext context)
    {
        r2.sprite = _2[0];
    }
    private void OnR3Start(InputAction.CallbackContext context)
    {
        r3.sprite = _button[1];
    }
    private void OnR3End(InputAction.CallbackContext context)
    {
        r3.sprite = _button[0];
    }
    private void OnL1Start(InputAction.CallbackContext context)
    {
        l1.sprite = _1[1];
    }
    private void OnL1End(InputAction.CallbackContext context)
    {
        l1.sprite = _1[0];
    }
    private void OnL2Start(InputAction.CallbackContext context)
    {
        l2.sprite = _2[1];
    }
    private void OnL2End(InputAction.CallbackContext context)
    {
        l2.sprite = _2[0];
    }
    private void OnL3Start(InputAction.CallbackContext context)
    {
        l3.sprite = _button[1];
    }
    private void OnL3End(InputAction.CallbackContext context)
    {
        l3.sprite = _button[0];
    }
    private void OnOptionStart(InputAction.CallbackContext context)
    {
        option.sprite = _minibutton[1];
    }
    private void OnOptionEnd(InputAction.CallbackContext context)
    {
        option.sprite = _minibutton[0];
    }
    private void OnShareStart(InputAction.CallbackContext context)
    {
        share.sprite = _minibutton[1];
    }
    private void OnShareEnd(InputAction.CallbackContext context)
    {
        share.sprite = _minibutton[0];
    }
    private void OnRight(InputAction.CallbackContext context)
    {
        _RightInputValue = context.ReadValue<Vector2>();
        _RightInputValue *= 5.5f;
        _R.transform.localPosition = _RightInputValue;
    }
    private void OnLeft(InputAction.CallbackContext context)
    {
        _LeftInputValue = context.ReadValue<Vector2>();
        _LeftInputValue *= 5.5f;
        _L.transform.localPosition = _LeftInputValue;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
