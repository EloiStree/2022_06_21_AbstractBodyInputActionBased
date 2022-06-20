using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.InputSystem.XR;

[System.Serializable]
public class TrackedHandsInfo<T>
{
    public T leftPinkyTip;
    public T leftRingTip;
    public T leftMiddleTip;
    public T leftIndexTip;
    public T leftThumbTip;
    public T leftPinkyStart;
    public T leftRingStart;
    public T leftMiddleStart;
    public T leftIndexStart;
    public T leftThumbStart;
    public T leftWristAtThumbSide;
    public T leftWristAtPinkySide;
    public T leftArmAtPinkyElbowSide;
    public T leftArmAtThumbElbowSide;
    public T rightPinkyTip;
    public T rightRingTip;
    public T rightMiddleTip;
    public T rightIndexTip;
    public T rightThumbTip;
    public T rightPinkyStart;
    public T rightRingStart;
    public T rightMiddleStart;
    public T rightIndexStart;
    public T rightThumbStart;
    public T leftPinkyMiddleTip;
    public T leftRingMiddleTip;
    public T leftMiddleMiddleTip;
    public T leftIndexMiddleTip;
    public T leftThumbMiddleTip;
    public T leftPinkyMiddleStart;
    public T leftRingMiddleStart;
    public T leftMiddleMiddleStart;
    public T leftIndexMiddleStart;
    public T leftThumbMiddleStart;
    public T rightPinkyMiddleTip;
    public T rightRingMiddleTip;
    public T rightMiddleMiddleTip;
    public T rightIndexMiddleTip;
    public T rightThumbMiddleTip;
    public T rightPinkyMiddleStart;
    public T rightRingMiddleStart;
    public T rightMiddleMiddleStart;
    public T rightIndexMiddleStart;
    public T rightThumbMiddleStart;
    public T rightWristAtThumbSide;
    public T rightWristAtPinkySide;
    public T rightArmAtPinkyElbowSide;
    public T rightArmAtThumbElbowSide;
    public T GetInfoOfHand(in AbstractBodyInputUtility.HandType handType, in AbstractBodyInputUtility.FingerName finger, in AbstractBodyInputUtility.FingerPart part)
    { return AbstractBodyInputUtility.GetInfoOfHand<T>(this, in handType, in finger, in part); }
    public void SetInfoOfHand(in T info, in AbstractBodyInputUtility.HandType handType, in AbstractBodyInputUtility.FingerName finger, in AbstractBodyInputUtility.FingerPart part)
    => AbstractBodyInputUtility.SetInfoOfHand<T>(this, in info, in handType, in finger, in part);
}


[System.Serializable]
public class TrackedHandInfo<T>
{
    public T pinkyTip;
    public T ringTip;
    public T middleTip;
    public T indexTip;
    public T thumbTip;
    public T pinkyStart;
    public T ringStart;
    public T middleStart;
    public T indexStart;
    public T thumbStart;
    public T wristAtThumbSide;
    public T wristAtPinkySide;
    public T armAtPinkyElbowSide;
    public T armAtThumbElbowSide;
    public T pinkyMiddleTip;
    public T ringMiddleTip;
    public T middleMiddleTip;
    public T indexMiddleTip;
    public T thumbMiddleTip;
    public T pinkyMiddleStart;
    public T ringMiddleStart;
    public T middleMiddleStart;
    public T indexMiddleStart;
    public T thumbMiddleStart;
    public T GetInfoOfHand( in AbstractBodyInputUtility.FingerName finger, in AbstractBodyInputUtility.FingerPart part)
    { return AbstractBodyInputUtility.GetInfoOfHand<T>(this,  in finger, in part); }
    public void SetInfoOfHand(in T info, in AbstractBodyInputUtility.FingerName finger, in AbstractBodyInputUtility.FingerPart part)
    => AbstractBodyInputUtility.SetInfoOfHand<T>(this, in info,  in finger, in part);
}

[System.Serializable]
public class TrackedHandInfoTransform : TrackedHandInfo<Transform> { }

[System.Serializable]
public class TrackedHandInfoVector3 : TrackedHandInfo<Vector3> { }
[System.Serializable]
public class TrackedHandInfoBool : TrackedHandInfo<bool> { }


[System.Serializable]
public class TrackedHandsInfoTransform : TrackedHandsInfo<Transform> { }

[System.Serializable]
public class TrackedHandsInfoVector3 : TrackedHandsInfo<Vector3> { }
[System.Serializable]
public class TrackedHandsInfoBool : TrackedHandsInfo<bool> { }



public struct FakeTrackedHandDeviceStateLeft : IInputStateTypeInfo
{
    public FourCC format => new FourCC('F', 'H', 'T', 'L');
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 pinkyTip;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 ringTip;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 middleTip;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 indexTip;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 thumbTip;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 pinkyStart;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 ringStart;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 middleStart;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 indexStart;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 thumbStart;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 wristAtThumbSide;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 wristAtPinkySide;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 armAtPinkyElbowSide;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 armAtThumbElbowSide;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 pinkyMiddleTip;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 ringMiddleTip;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 middleMiddleTip;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 indexMiddleTip;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 thumbMiddleTip;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 pinkyMiddleStart;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 ringMiddleStart;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 middleMiddleStart;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 indexMiddleStart;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 thumbMiddleStart;
}



public struct FakeTrackedHandDeviceStateRight : IInputStateTypeInfo
{
    public FourCC format => new FourCC('F', 'H', 'T', 'R');
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 pinkyTip;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 ringTip;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 middleTip;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 indexTip;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 thumbTip;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 pinkyStart;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 ringStart;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 middleStart;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 indexStart;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 thumbStart;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 wristAtThumbSide;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 wristAtPinkySide;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 armAtPinkyElbowSide;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 armAtThumbElbowSide;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 pinkyMiddleTip;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 ringMiddleTip;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 middleMiddleTip;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 indexMiddleTip;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 thumbMiddleTip;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 pinkyMiddleStart;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 ringMiddleStart;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 middleMiddleStart;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 indexMiddleStart;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3 thumbMiddleStart;
}


[InputControlLayout(displayName = "Fake Hand Tracked Left", stateType = typeof(FakeTrackedHandDeviceStateLeft), isGenericTypeOfDevice = true)]
public class FakeTrackedHandDeviceLeft : FakeTrackedHandDevice
{ }
[InputControlLayout(displayName = "Fake Hand Tracked Right", stateType = typeof(FakeTrackedHandDeviceStateRight), isGenericTypeOfDevice = true)]
public class FakeTrackedHandDeviceRight : FakeTrackedHandDevice
{ }
//[InputControlLayout(displayName = "Fake Hand Tracked Device", stateType = typeof(FakeTrackedHandDeviceState), isGenericTypeOfDevice = true)]
public class FakeTrackedHandDevice : InputDevice
{
    //[InputControl(name = "Pinky Tip", noisy = true, dontReset = true)]
    public Vector3Control pinkyTip { get; set; }
    public Vector3Control ringTip { get; set; }
    public Vector3Control middleTip { get; set; }
    public Vector3Control indexTip { get; set; }
    public Vector3Control thumbTip { get; set; }
    public Vector3Control pinkyStart { get; set; }
    public Vector3Control ringStart { get; set; }
    public Vector3Control middleStart { get; set; }
    public Vector3Control indexStart { get; set; }
    public Vector3Control thumbStart { get; set; }
    public Vector3Control wristAtThumbSide { get; set; }
    public Vector3Control wristAtPinkySide { get; set; }
    public Vector3Control armAtPinkyElbowSide { get; set; }
    public Vector3Control armAtThumbElbowSide { get; set; }
    public Vector3Control pinkyMiddleTip { get; set; }
    public Vector3Control ringMiddleTip { get; set; }
    public Vector3Control middleMiddleTip { get; set; }
    public Vector3Control indexMiddleTip { get; set; }
    public Vector3Control thumbMiddleTip { get; set; }
    public Vector3Control pinkyMiddleStart { get; set; }
    public Vector3Control ringMiddleStart { get; set; }
    public Vector3Control middleMiddleStart { get; set; }
    public Vector3Control indexMiddleStart { get; set; }
    public Vector3Control thumbMiddleStart { get; set; }

#if UNITY_EDITOR
    [UnityEditor.MenuItem("Tools/Add My hand Device")]
    public static void InitilizedFromMenu()
    {
        CheckThatDeviceIsRegistered();
    }
#endif
    protected override void FinishSetup()
    {
        base.FinishSetup();
        pinkyTip = GetChildControl<Vector3Control>("pinkyTip");
        ringTip = GetChildControl<Vector3Control>("ringTip");
        middleTip = GetChildControl<Vector3Control>("middleTip");
        indexTip = GetChildControl<Vector3Control>("indexTip");
        thumbTip = GetChildControl<Vector3Control>("thumbTip");
        pinkyStart = GetChildControl<Vector3Control>("pinkyStart");
        ringStart = GetChildControl<Vector3Control>("ringStart");
        middleStart = GetChildControl<Vector3Control>("middleStart");
        indexStart = GetChildControl<Vector3Control>("indexStart");
        thumbStart = GetChildControl<Vector3Control>("thumbStart");
        wristAtThumbSide = GetChildControl<Vector3Control>("wristAtThumbSide");
        wristAtPinkySide = GetChildControl<Vector3Control>("wristAtPinkySide");
        armAtPinkyElbowSide = GetChildControl<Vector3Control>("armAtPinkyElbowSide");
        armAtThumbElbowSide = GetChildControl<Vector3Control>("armAtThumbElbowSide");
        pinkyMiddleTip = GetChildControl<Vector3Control>("pinkyMiddleTip");
        ringMiddleTip = GetChildControl<Vector3Control>("ringMiddleTip");
        middleMiddleTip = GetChildControl<Vector3Control>("middleMiddleTip");
        indexMiddleTip = GetChildControl<Vector3Control>("indexMiddleTip");
        thumbMiddleTip = GetChildControl<Vector3Control>("thumbMiddleTip");
        pinkyMiddleStart = GetChildControl<Vector3Control>("pinkyMiddleStart");
        ringMiddleStart = GetChildControl<Vector3Control>("ringMiddleStart");
        middleMiddleStart = GetChildControl<Vector3Control>("middleMiddleStart");
        indexMiddleStart = GetChildControl<Vector3Control>("indexMiddleStart");
        thumbMiddleStart = GetChildControl<Vector3Control>("thumbMiddleStart");
    }

    static FakeTrackedHandDevice()
    {
        CheckThatDeviceIsRegistered();

    }
    private static bool m_wasInitialized=false;
    private static FakeTrackedHandDeviceLeft left;
    private static FakeTrackedHandDeviceRight right;
    private static void CheckThatDeviceIsRegistered()
    {
        //Debug.Log("Device count:" + InputSystem.devices.Count);
        //FakeTrackedHandDevice[] devices = InputSystem.devices.Where(k => k is FakeTrackedHandDevice).Select(k => (FakeTrackedHandDevice)k).ToArray();
        //Debug.Log("Device F count:" + devices.Length);
        //Debug.Log("Device L count:" + devicesLeft.Length);
        //Debug.Log("Device R count:" + devicesRight.Length);


        if (m_wasInitialized)
            return;

        FakeTrackedHandDeviceLeft[] devicesLeft = InputSystem.devices.Where(k => k is FakeTrackedHandDeviceLeft).Select(k => (FakeTrackedHandDeviceLeft)k).ToArray();
        FakeTrackedHandDeviceRight[] devicesRight = InputSystem.devices.Where(k => k is FakeTrackedHandDeviceRight).Select(k => (FakeTrackedHandDeviceRight)k).ToArray();
        
        InputSystem.RegisterLayout<FakeTrackedHandDeviceLeft>(
           matches: new InputDeviceMatcher()
           .WithInterface("FakeTrackedHandDeviceLeft"));

        InputSystem.RegisterLayout<FakeTrackedHandDeviceRight>(
                matches: new InputDeviceMatcher()
                .WithInterface("FakeTrackedHandDeviceRight"));

        // FakeTrackedHandDevice [] devices = InputSystem.devices.Cast<FakeTrackedHandDevice>().ToArray();
      
        if (devicesLeft.Length< 1)
        {
            left = (FakeTrackedHandDeviceLeft) InputSystem.AddDevice(new InputDeviceDescription()
            {
                interfaceName = "FakeTrackedHandDeviceLeft",
                product = "Hands Mockup Left"
            });
            //if (left == null) throw new System.Exception("Puuufh A");
        }
        if (devicesRight.Length < 1)
        {
           right= (FakeTrackedHandDeviceRight) InputSystem.AddDevice(new InputDeviceDescription()
            {
                interfaceName = "FakeTrackedHandDeviceRight",
                product = "Hands Mockup Right"
            });
            //if (right == null) throw new System.Exception("Puuufh B");
        }



        //left = devicesLeft[0];
        //right = devicesRight[0];

        //if (left == null) throw new System.Exception("Puuufh AAAA");
        //if (right == null) throw new System.Exception("Puuufh BBBB");
        InputSystem.QueueStateEvent(left, new FakeTrackedHandDeviceStateLeft() { });
        InputSystem.QueueStateEvent(right, new FakeTrackedHandDeviceStateRight() { });
        m_wasInitialized = true;
    }

    [RuntimeInitializeOnLoadMethod]
    public static void Initialize()
    {
        CheckThatDeviceIsRegistered();
    }

    public static FakeTrackedHandDeviceLeft GetLeftDevice()
    {


        if (left == null) CheckThatDeviceIsRegistered();
        return left;
    }
    public static FakeTrackedHandDeviceRight GetRightDevice()
    {
        if (right == null) CheckThatDeviceIsRegistered();
        return right;
    }

}