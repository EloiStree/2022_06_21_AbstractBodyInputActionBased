//using System.Collections;      
//using System.Collections.Generic;      
//using System.Linq;      
//using UnityEngine;      
//using UnityEngine.InputSystem;      
//using UnityEngine.InputSystem.Controls;      
//using UnityEngine.InputSystem.Layouts;      
//using UnityEngine.InputSystem.LowLevel;      
//using UnityEngine.InputSystem.Utilities;      
//using UnityEngine.InputSystem.XR;      




//public class FakeStaticTrackedHandDeviceInstance
//{
//    static FakeStaticTrackedHandDeviceInstance() {
//        leftPinkyTip = new Vector3Control();
//        leftRingTip = new Vector3Control();
//        leftMiddleTip = new Vector3Control();
//        leftIndexTip = new Vector3Control();
//        leftThumbTip = new Vector3Control();
//        leftPinkyStart = new Vector3Control();
//        leftRingStart = new Vector3Control();
//        leftMiddleStart = new Vector3Control();
//        leftIndexStart = new Vector3Control();
//        leftThumbStart = new Vector3Control();
//        leftWristAtThumbSide = new Vector3Control();
//        leftWristAtPinkySide = new Vector3Control();
//        leftArmAtPinkyElbowSide = new Vector3Control();
//        leftArmAtThumbElbowSide = new Vector3Control();
//        rightPinkyTip = new Vector3Control();
//        rightRingTip = new Vector3Control();
//        rightMiddleTip = new Vector3Control();
//        rightIndexTip = new Vector3Control();
//        rightThumbTip = new Vector3Control();
//        rightPinkyStart = new Vector3Control();
//        rightRingStart = new Vector3Control();
//        rightMiddleStart = new Vector3Control();
//        rightIndexStart = new Vector3Control();
//        rightThumbStart = new Vector3Control();
//        rightWristAtThumbSide = new Vector3Control();
//        rightWristAtPinkySide = new Vector3Control();
//        rightArmAtPinkyElbowSide = new Vector3Control();
//        rightArmAtThumbElbowSide = new Vector3Control();
//    }

//    public static Vector3Control leftPinkyTip            =new Vector3Control();                            
//    public static Vector3Control leftRingTip             =new Vector3Control();                            
//    public static Vector3Control leftMiddleTip           =new Vector3Control();                     
//    public static Vector3Control leftIndexTip            =new Vector3Control();                      
//    public static Vector3Control leftThumbTip            =new Vector3Control();                      
//    public static Vector3Control leftPinkyStart          =new Vector3Control();                      
//    public static Vector3Control leftRingStart           =new Vector3Control();                      
//    public static Vector3Control leftMiddleStart         =new Vector3Control();                      
//    public static Vector3Control leftIndexStart          =new Vector3Control();                      
//    public static Vector3Control leftThumbStart          =new Vector3Control();                      
//    public static Vector3Control leftWristAtThumbSide    =new Vector3Control();                      
//    public static Vector3Control leftWristAtPinkySide    =new Vector3Control();                      
//    public static Vector3Control leftArmAtPinkyElbowSide =new Vector3Control();                      
//    public static Vector3Control leftArmAtThumbElbowSide =new Vector3Control();                      
//    public static Vector3Control rightPinkyTip           =new Vector3Control();                      
//    public static Vector3Control rightRingTip            =new Vector3Control();                      
//    public static Vector3Control rightMiddleTip          =new Vector3Control();                      
//    public static Vector3Control rightIndexTip           =new Vector3Control();                      
//    public static Vector3Control rightThumbTip           =new Vector3Control();                      
//    public static Vector3Control rightPinkyStart         =new Vector3Control();                      
//    public static Vector3Control rightRingStart          =new Vector3Control();                      
//    public static Vector3Control rightMiddleStart        =new Vector3Control();                      
//    public static Vector3Control rightIndexStart         =new Vector3Control();                      
//    public static Vector3Control rightThumbStart         =new Vector3Control();                      
//    public static Vector3Control rightWristAtThumbSide   =new Vector3Control();                      
//    public static Vector3Control rightWristAtPinkySide   =new Vector3Control();                      
//    public static Vector3Control rightArmAtPinkyElbowSide=new Vector3Control();                      
//    public static Vector3Control rightArmAtThumbElbowSide=new Vector3Control();                    
//}

//[InputControlLayout(displayName = "Fake Static Hand Tracked Device",  isGenericTypeOfDevice = true)]
//public class FakeStaticTrackedHandDevice : InputDevice {

//    //[InputControl(name = "Pinky Tip", noisy = true, dontReset = true)]
//    [InputControl(noisy = true, dontReset = true, layout = "Vector3")]
//    public Vector3Control leftPinkyTip                {get{return FakeStaticTrackedHandDeviceInstance.leftPinkyTip ;  } }
//    [InputControl(noisy = true, dontReset = true, layout = "Vector3")]
//    public Vector3Control leftRingTip                 {get{return FakeStaticTrackedHandDeviceInstance.leftRingTip ;  } }
//    [InputControl(noisy = true, dontReset = true, layout = "Vector3")]
//    public Vector3Control leftMiddleTip               {get{return FakeStaticTrackedHandDeviceInstance.leftMiddleTip ;  } }
//    [InputControl(noisy = true, dontReset = true, layout = "Vector3")]
//    public Vector3Control leftIndexTip                {get{return FakeStaticTrackedHandDeviceInstance.leftIndexTip ;  } }
//    [InputControl(noisy = true, dontReset = true, layout = "Vector3")]
//    public Vector3Control leftThumbTip                {get{return FakeStaticTrackedHandDeviceInstance.leftThumbTip ;  } }
//    [InputControl(noisy = true, dontReset = true, layout = "Vector3")]
//    public Vector3Control leftPinkyStart              {get{return FakeStaticTrackedHandDeviceInstance.leftPinkyStart ;  } }
//    [InputControl(noisy = true, dontReset = true, layout = "Vector3")]
//    public Vector3Control leftRingStart               {get{return FakeStaticTrackedHandDeviceInstance.leftRingStart ;  } }
//    [InputControl(noisy = true, dontReset = true, layout = "Vector3")]
//    public Vector3Control leftMiddleStart             {get{return FakeStaticTrackedHandDeviceInstance.leftMiddleStart ;  } }
//    [InputControl(noisy = true, dontReset = true, layout = "Vector3")]
//    public Vector3Control leftIndexStart              {get{return FakeStaticTrackedHandDeviceInstance.leftIndexStart ;  } }
//    [InputControl(noisy = true, dontReset = true, layout = "Vector3")]
//    public Vector3Control leftThumbStart              {get{return FakeStaticTrackedHandDeviceInstance.leftThumbStart ;  } }
//    [InputControl(noisy = true, dontReset = true, layout = "Vector3")]
//    public Vector3Control leftWristAtThumbSide        {get{return FakeStaticTrackedHandDeviceInstance.leftWristAtThumbSide ;  } }
//    [InputControl(noisy = true, dontReset = true, layout = "Vector3")]
//    public Vector3Control leftWristAtPinkySide        {get{return FakeStaticTrackedHandDeviceInstance.leftWristAtPinkySide ;  } }
//    [InputControl(noisy = true, dontReset = true, layout = "Vector3")]
//    public Vector3Control leftArmAtPinkyElbowSide     {get{return FakeStaticTrackedHandDeviceInstance.leftArmAtPinkyElbowSide ;  } }
//    [InputControl(noisy = true, dontReset = true, layout = "Vector3")]
//    public Vector3Control leftArmAtThumbElbowSide     {get{return FakeStaticTrackedHandDeviceInstance.leftArmAtThumbElbowSide ;  } }
//    [InputControl(noisy = true, dontReset = true, layout = "Vector3")]
//    public Vector3Control rightPinkyTip               {get{return FakeStaticTrackedHandDeviceInstance.rightPinkyTip ;  } }
//    [InputControl(noisy = true, dontReset = true, layout = "Vector3")]
//    public Vector3Control rightRingTip                {get{return FakeStaticTrackedHandDeviceInstance.rightRingTip ;  } }
//    [InputControl(noisy = true, dontReset = true, layout = "Vector3")]
//    public Vector3Control rightMiddleTip              {get{return FakeStaticTrackedHandDeviceInstance.rightMiddleTip ;  } }
//    [InputControl(noisy = true, dontReset = true, layout = "Vector3")]
//    public Vector3Control rightIndexTip               {get{return FakeStaticTrackedHandDeviceInstance.rightIndexTip ;  } }
//    [InputControl(noisy = true, dontReset = true, layout = "Vector3")]
//    public Vector3Control rightThumbTip               {get{return FakeStaticTrackedHandDeviceInstance.rightThumbTip ;  } }
//    [InputControl(noisy = true, dontReset = true, layout = "Vector3")]
//    public Vector3Control rightPinkyStart             {get{return FakeStaticTrackedHandDeviceInstance.rightPinkyStart ;  } }
//    [InputControl(noisy = true, dontReset = true, layout = "Vector3")]
//    public Vector3Control rightRingStart              {get{return FakeStaticTrackedHandDeviceInstance.rightRingStart ;  } }
//    [InputControl(noisy = true, dontReset = true, layout = "Vector3")]
//    public Vector3Control rightMiddleStart            {get{return FakeStaticTrackedHandDeviceInstance.rightMiddleStart ;  } }
//    [InputControl(noisy = true, dontReset = true, layout = "Vector3")]
//    public Vector3Control rightIndexStart { get { return FakeStaticTrackedHandDeviceInstance.rightIndexStart; } }
//    [InputControl(noisy = true, dontReset = true, layout = "Vector3")]
//    public Vector3Control rightThumbStart             {get{return FakeStaticTrackedHandDeviceInstance.rightThumbStart ;  } }
//    [InputControl(noisy = true, dontReset = true, layout = "Vector3")]
//    public Vector3Control rightWristAtThumbSide       {get{return FakeStaticTrackedHandDeviceInstance.rightWristAtThumbSide ;  } }
//    [InputControl(noisy = true, dontReset = true, layout = "Vector3")]
//    public Vector3Control rightWristAtPinkySide       {get{return FakeStaticTrackedHandDeviceInstance.rightWristAtPinkySide ;  } }
//    [InputControl(noisy = true, dontReset = true, layout = "Vector3")]
//    public Vector3Control rightArmAtPinkyElbowSide    {get{return FakeStaticTrackedHandDeviceInstance.rightArmAtPinkyElbowSide ;  } }
//    [InputControl(noisy = true, dontReset = true, layout = "Vector3")]
//    public Vector3Control rightArmAtThumbElbowSide    {get{return FakeStaticTrackedHandDeviceInstance.rightArmAtThumbElbowSide;  }  }


//#if UNITY_EDITOR
//    [UnityEditor.MenuItem("Tools/Add My hand Device")]
//    public static void Initilized() {
//        //var d = InputSystem.AddDevice<FakeStaticTrackedHandDevice>();  
//        MakeSureRegisterExist();
//    }
//#endif

//    protected override void FinishSetup()
//    {
//        base.FinishSetup();  
//    }

//    static FakeStaticTrackedHandDevice()
//    {
//        MakeSureRegisterExist();
//    }

//    private static void MakeSureRegisterExist()
//    {
//        InputSystem.RegisterLayout<FakeStaticTrackedHandDevice>(
//           matches: new InputDeviceMatcher()
//           .WithInterface("FakeStaticTrackedHandDevice"));

//        if (!InputSystem.devices.Any(x => x is FakeStaticTrackedHandDevice))
//        {
//            var d = InputSystem.AddDevice(new InputDeviceDescription() { interfaceName = "FakeStaticTrackedHandDevice", product = "What Ever 2" });
//        }
//    }

//    [RuntimeInitializeOnLoadMethod]
//    public static void Initialize() {    }
//}