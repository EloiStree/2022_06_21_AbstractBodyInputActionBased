
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
public class TrackedBodyInfo<T>
{


    public T nose;
    public T upperNeck;
    public T lowerNeck;
    public T spineChestUp;
    public T spineNavalMiddle;
    public T spinePelvisDown;
    public T leftEye;
    public T leftEar;
    public T leftClavicle;
    public T leftShoulder;
    public T leftElbow;
    public T leftWrist;
    public T leftHand;
    public T leftHandThumb;
    public T leftHandTip;
    public T leftHip;
    public T leftKnee;
    public T leftAnkle;
    public T leftFoot;
    public T rightEye;
    public T rightEar;
    public T rightClavicle;
    public T rightShoulder;
    public T rightElbow;
    public T rightWrist;
    public T rightHand;
    public T rightHandThumb;
    public T rightHandTip;
    public T rightHip;
    public T rightKnee;
    public T rightAnkle;
    public T rightFoot;






    public T GetInfoOfBody(in AbstractBodyInputUtility.BodyAnchor anchor)
    { return AbstractBodyInputUtility.GetInfoOfBody<T>(this, in anchor); }
    public void SetInfoOfHand(in T info, in AbstractBodyInputUtility.BodyAnchor anchor)
    => AbstractBodyInputUtility.SetInfoOfBody<T>(this, in info, in anchor);
}


[System.Serializable]
public class TrackedBodyInfoTransform : TrackedBodyInfo<Transform> { }

[System.Serializable]
public class TrackedBodyInfoVector3 : TrackedBodyInfo<Vector3> { }
[System.Serializable]
public class TrackedBodyInfoBool : TrackedBodyInfo<bool> { }



public struct FakeTrackedBodyDeviceState : IInputStateTypeInfo
{
    public FourCC format => new FourCC('F', 'H', 'T', 'B');
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3  nose;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3  upperNeck;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3  lowerNeck;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3  spineChestUp;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3  spineNavalMiddle;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3  spinePelvisDown;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3  leftEye;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3  leftEar;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3  leftClavicle;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3  leftShoulder;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3  leftElbow;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3  leftWrist;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3  leftHand;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3  leftHandThumb;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3  leftHandTip;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3  leftHip;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3  leftKnee;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3  leftAnkle;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3  leftFoot;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3  rightEye;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3  rightEar;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3  rightClavicle;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3  rightShoulder;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3  rightElbow;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3  rightWrist;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3  rightHand;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3  rightHandThumb;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3  rightHandTip;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3  rightHip;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3  rightKnee;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3  rightAnkle;
    [InputControl(noisy = true, dontReset = true, layout = "Vector3")] public Vector3  rightFoot;

}





[InputControlLayout(displayName = "Fake Body Tracked", stateType = typeof(FakeTrackedBodyDeviceState), isGenericTypeOfDevice = true)]
public class FakeTrackedBodyDevice : InputDevice
{
    public Vector3Control   nose               { get; set; }
    public Vector3Control   upperNeck              { get; set; }
    public Vector3Control   lowerNeck              { get; set; }
    public Vector3Control   spineChestUp                 { get; set; }
    public Vector3Control   spineNavalMiddle                    { get; set; }
    public Vector3Control   spinePelvisDown                    { get; set; }
    public Vector3Control   leftEye            { get; set; }
    public Vector3Control   leftEar            { get; set; }
    public Vector3Control   leftClavicle                 { get; set; }
    public Vector3Control   leftShoulder                 { get; set; }
    public Vector3Control   leftElbow              { get; set; }
    public Vector3Control   leftWrist              { get; set; }
    public Vector3Control   leftHand             { get; set; }
    public Vector3Control   leftHandThumb                  { get; set; }
    public Vector3Control   leftHandTip                { get; set; }
    public Vector3Control   leftHip            { get; set; }
    public Vector3Control   leftKnee             { get; set; }
    public Vector3Control   leftAnkle              { get; set; }
    public Vector3Control   leftFoot             { get; set; }
    public Vector3Control   rightEye             { get; set; }
    public Vector3Control   rightEar             { get; set; }
    public Vector3Control   rightClavicle                  { get; set; }
    public Vector3Control   rightShoulder                  { get; set; }
    public Vector3Control   rightElbow               { get; set; }
    public Vector3Control   rightWrist               { get; set; }
    public Vector3Control   rightHand              { get; set; }
    public Vector3Control   rightHandThumb                   { get; set; }
    public Vector3Control   rightHandTip                 { get; set; }
    public Vector3Control   rightHip             { get; set; }
    public Vector3Control   rightKnee              { get; set; }
    public Vector3Control   rightAnkle               { get; set; }
    public Vector3Control   rightFoot              { get; set; }
  

#if UNITY_EDITOR
    [UnityEditor.MenuItem("Tools/Add My body device")]
    public static void InitilizedFromMenu()
    {
        CheckThatDeviceIsRegistered();
    }
#endif
    protected override void FinishSetup()
    {
        base.FinishSetup();

        nose                = GetChildControl<Vector3Control>("nose");
        upperNeck           = GetChildControl<Vector3Control>("upperNeck");
         lowerNeck          = GetChildControl<Vector3Control>("lowerNeck");
         spineChestUp       = GetChildControl<Vector3Control>("spineChestUp");
         spineNavalMiddle   = GetChildControl<Vector3Control>("spineNavalMiddle");
         spinePelvisDown    = GetChildControl<Vector3Control>("spinePelvisDown");
         leftEye            = GetChildControl<Vector3Control>("leftEye");
         leftEar            = GetChildControl<Vector3Control>("leftEar");
         leftClavicle       = GetChildControl<Vector3Control>("leftClavicle");
         leftShoulder       = GetChildControl<Vector3Control>("leftShoulder");
         leftElbow          = GetChildControl<Vector3Control>("leftElbow");
         leftWrist          = GetChildControl<Vector3Control>("leftWrist");
         leftHand           = GetChildControl<Vector3Control>("leftHand");
         leftHandThumb      = GetChildControl<Vector3Control>("leftHandThumb");
         leftHandTip        = GetChildControl<Vector3Control>("leftHandTip");
         leftHip            = GetChildControl<Vector3Control>("leftHip");
         leftKnee           = GetChildControl<Vector3Control>("leftKnee");
         leftAnkle          = GetChildControl<Vector3Control>("leftAnkle");
         leftFoot           = GetChildControl<Vector3Control>("leftFoot");
         rightEye           = GetChildControl<Vector3Control>("rightEye");
         rightEar           = GetChildControl<Vector3Control>("rightEar");
         rightClavicle      = GetChildControl<Vector3Control>("rightClavicle");
         rightShoulder      = GetChildControl<Vector3Control>("rightShoulder");
         rightElbow         = GetChildControl<Vector3Control>("rightElbow");
         rightWrist         = GetChildControl<Vector3Control>("rightWrist");
         rightHand          = GetChildControl<Vector3Control>("rightHand");
         rightHandThumb     = GetChildControl<Vector3Control>("rightHandThumb");
         rightHandTip       = GetChildControl<Vector3Control>("rightHandTip");
         rightHip           = GetChildControl<Vector3Control>("rightHip");
         rightKnee          = GetChildControl<Vector3Control>("rightKnee");
         rightAnkle         = GetChildControl<Vector3Control>("rightAnkle");
         rightFoot          = GetChildControl<Vector3Control>("rightFoot");


    }

    static FakeTrackedBodyDevice()
    {
        CheckThatDeviceIsRegistered();

    }
    private static bool m_wasInitialized = false;
    private static FakeTrackedBodyDevice body;
    private static void CheckThatDeviceIsRegistered()
    {
        //Debug.Log("Device  count:" + InputSystem.devices.Count);
        FakeTrackedBodyDevice[] devices = InputSystem.devices.Where(k => k is FakeTrackedBodyDevice).Select(k => (FakeTrackedBodyDevice)k).ToArray();
        // Debug.Log("Device Body count:" + devices.Length);

        if (m_wasInitialized)
            return;

        InputSystem.RegisterLayout<FakeTrackedBodyDevice>(
           matches: new InputDeviceMatcher()
           .WithInterface("FakeTrackedBodyDeviceState"));

        if (devices.Length < 1)
        {
            body = (FakeTrackedBodyDevice) InputSystem.AddDevice(new InputDeviceDescription()
            {
                interfaceName = "FakeTrackedBodyDeviceState",
                product = "Body Tracked Mockup"
            });
            //     if (body == null) throw new System.Exception("Puuufh BA");
        }
        // if (body == null) throw new System.Exception("Puuufh BAAAA");
        InputSystem.QueueStateEvent(body, new FakeTrackedBodyDeviceState() { });
        m_wasInitialized = true;
    }

    [RuntimeInitializeOnLoadMethod]
    public static void Initialize()
    {
        CheckThatDeviceIsRegistered();
    }

    public static FakeTrackedBodyDevice GetBodyDevice()
    {
        if (body == null) CheckThatDeviceIsRegistered();
        return body;
    }
}