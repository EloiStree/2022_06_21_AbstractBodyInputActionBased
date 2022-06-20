using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AbstractBodyInputUtility
{
    public enum HandType { Left, Right }
    public enum FingerName { Pinky, Ring, Middle, Index, Thumb }


    public enum FingerPart { Start, MiddleStart, MiddleTip, Tip }
    public enum BodyAnchor
    {
        Nose,
        UpperNeck,
        LowerNeck,
        SpineChestUp,
        SpineNavalMiddle,
        SpinePelvisDown,
        LeftEye,
        LeftEar,
        LeftClavicle,
        LeftShoulder,
        LeftElbow,
        LeftWrist,
        LeftHand,
        LeftHandThumb,
        LeftHandTip,
        LeftHip,
        LeftKnee,
        LeftAnkle,
        LeftFoot,
        RightEye,
        RightEar,
        RightClavicle,
        RightShoulder,
        RightElbow,
        RightWrist,
        RightHand,
        RightHandThumb,
        RightHandTip,
        RightHip,
        RightKnee,
        RightAnkle,
        RightFoot
    }


    public static T GetInfoOfBody<T>(in TrackedBodyInfo<T> body
        , in BodyAnchor bodyAnchor)
    {
        switch (bodyAnchor)
        {
            case BodyAnchor.Nose: return body.nose;
            case BodyAnchor.UpperNeck: return body.upperNeck;
            case BodyAnchor.LowerNeck: return body.lowerNeck;
            case BodyAnchor.SpineChestUp: return body.spineChestUp;
            case BodyAnchor.SpineNavalMiddle: return body.spineNavalMiddle;
            case BodyAnchor.SpinePelvisDown: return body.spinePelvisDown;
            case BodyAnchor.LeftEye: return body.leftEye;
            case BodyAnchor.LeftEar: return body.leftEar;
            case BodyAnchor.LeftClavicle: return body.leftClavicle;
            case BodyAnchor.LeftShoulder: return body.leftShoulder;
            case BodyAnchor.LeftElbow: return body.leftElbow;
            case BodyAnchor.LeftWrist: return body.leftWrist;
            case BodyAnchor.LeftHand: return body.leftHand;
            case BodyAnchor.LeftHandThumb: return body.leftHandThumb;
            case BodyAnchor.LeftHandTip: return body.leftHandTip;
            case BodyAnchor.LeftHip: return body.leftHip;
            case BodyAnchor.LeftKnee: return body.leftKnee;
            case BodyAnchor.LeftAnkle: return body.leftAnkle;
            case BodyAnchor.LeftFoot: return body.leftFoot;
            case BodyAnchor.RightEye: return body.rightEye;
            case BodyAnchor.RightEar: return body.rightEar;
            case BodyAnchor.RightClavicle: return body.rightClavicle;
            case BodyAnchor.RightShoulder: return body.rightShoulder;
            case BodyAnchor.RightElbow: return body.rightElbow;
            case BodyAnchor.RightWrist: return body.rightWrist;
            case BodyAnchor.RightHand: return body.rightHand;
            case BodyAnchor.RightHandThumb: return body.rightHandThumb;
            case BodyAnchor.RightHandTip: return body.rightHandTip;
            case BodyAnchor.RightHip: return body.rightHip;
            case BodyAnchor.RightKnee: return body.rightKnee;
            case BodyAnchor.RightAnkle: return body.rightAnkle;
            case BodyAnchor.RightFoot: return body.rightFoot;

            default: break;

        }

        throw new Exception("Enum not managed");
    }

    public static void SetInfoOfBody<T>(in TrackedBodyInfo<T> body, in T value, in BodyAnchor bodyAnchor)
    {
        switch (bodyAnchor)
        {
            case BodyAnchor.Nose: body.nose = value; break;
            case BodyAnchor.UpperNeck: body.upperNeck = value; break;
            case BodyAnchor.LowerNeck: body.lowerNeck = value; break;
            case BodyAnchor.SpineChestUp: body.spineChestUp = value; break;
            case BodyAnchor.SpineNavalMiddle: body.spineNavalMiddle = value; break;
            case BodyAnchor.SpinePelvisDown: body.spinePelvisDown = value; break;
            case BodyAnchor.LeftEye: body.leftEye = value; break;
            case BodyAnchor.LeftEar: body.leftEar = value; break;
            case BodyAnchor.LeftClavicle: body.leftClavicle = value; break;
            case BodyAnchor.LeftShoulder: body.leftShoulder = value; break;
            case BodyAnchor.LeftElbow: body.leftElbow = value; break;
            case BodyAnchor.LeftWrist: body.leftWrist = value; break;
            case BodyAnchor.LeftHand: body.leftHand = value; break;
            case BodyAnchor.LeftHandThumb: body.leftHandThumb = value; break;
            case BodyAnchor.LeftHandTip: body.leftHandTip = value; break;
            case BodyAnchor.LeftHip: body.leftHip = value; break;
            case BodyAnchor.LeftKnee: body.leftKnee = value; break;
            case BodyAnchor.LeftAnkle: body.leftAnkle = value; break;
            case BodyAnchor.LeftFoot: body.leftFoot = value; break;
            case BodyAnchor.RightEye: body.rightEye = value; break;
            case BodyAnchor.RightEar: body.rightEar = value; break;
            case BodyAnchor.RightClavicle: body.rightClavicle = value; break;
            case BodyAnchor.RightShoulder: body.rightShoulder = value; break;
            case BodyAnchor.RightElbow: body.rightElbow = value; break;
            case BodyAnchor.RightWrist: body.rightWrist = value; break;
            case BodyAnchor.RightHand: body.rightHand = value; break;
            case BodyAnchor.RightHandThumb: body.rightHandThumb = value; break;
            case BodyAnchor.RightHandTip: body.rightHandTip = value; break;
            case BodyAnchor.RightHip: body.rightHip = value; break;
            case BodyAnchor.RightKnee: body.rightKnee = value; break;
            case BodyAnchor.RightAnkle: body.rightAnkle = value; break;
            case BodyAnchor.RightFoot: body.rightFoot = value; break;

            default: break;

        }

        throw new Exception("Enum not managed");


    }




    public static T GetInfoOfHand<T>(in TrackedHandsInfo<T> hand
        , in HandType handType, in FingerName finger, in FingerPart part)
    {

        if (handType == HandType.Left)
        {
            if (finger == FingerName.Thumb)
            {
                if (part == FingerPart.Start) return hand.leftThumbStart;
                else if (part == FingerPart.MiddleStart) return hand.leftThumbMiddleStart;
                else if (part == FingerPart.MiddleTip) return hand.leftThumbMiddleTip;
                else if (part == FingerPart.Tip) return hand.leftThumbTip;
            }
            else if (finger == FingerName.Index)
            {
                if (part == FingerPart.Start) return hand.leftIndexStart;
                else if (part == FingerPart.MiddleStart) return hand.leftIndexMiddleStart;
                else if (part == FingerPart.MiddleTip) return hand.leftIndexMiddleTip;
                else if (part == FingerPart.Tip) return hand.leftIndexTip;
            }
            else if (finger == FingerName.Middle)
            {
                if (part == FingerPart.Start) return hand.leftMiddleStart;
                else if (part == FingerPart.MiddleStart) return hand.leftMiddleMiddleStart;
                else if (part == FingerPart.MiddleTip) return hand.leftMiddleMiddleTip;
                else if (part == FingerPart.Tip) return hand.leftMiddleTip;
            }
            else if (finger == FingerName.Ring)
            {
                if (part == FingerPart.Start) return hand.leftRingStart;
                else if (part == FingerPart.MiddleStart) return hand.leftRingMiddleStart;
                else if (part == FingerPart.MiddleTip) return hand.leftRingMiddleTip;
                else if (part == FingerPart.Tip) return hand.leftRingTip;
            }
            else if (finger == FingerName.Pinky)
            {
                if (part == FingerPart.Start) return hand.leftPinkyStart;
                else if (part == FingerPart.MiddleStart) return hand.leftPinkyMiddleStart;
                else if (part == FingerPart.MiddleTip) return hand.leftPinkyMiddleTip;
                else if (part == FingerPart.Tip) return hand.leftPinkyTip;
            }
        }
        else
        {
            if (finger == FingerName.Thumb)
            {
                if (part == FingerPart.Start) return hand.rightThumbStart;
                else if (part == FingerPart.MiddleStart) return hand.rightThumbMiddleStart;
                else if (part == FingerPart.MiddleTip) return hand.rightThumbMiddleTip;
                else if (part == FingerPart.Tip) return hand.rightThumbTip;
            }
            else if (finger == FingerName.Index)
            {
                if (part == FingerPart.Start) return hand.rightIndexStart;
                else if (part == FingerPart.MiddleStart) return hand.rightIndexMiddleStart;
                else if (part == FingerPart.MiddleTip) return hand.rightIndexMiddleTip;
                else if (part == FingerPart.Tip) return hand.rightIndexTip;
            }
            else if (finger == FingerName.Middle)
            {
                if (part == FingerPart.Start) return hand.rightMiddleStart;
                else if (part == FingerPart.MiddleStart) return hand.rightMiddleMiddleStart;
                else if (part == FingerPart.MiddleTip) return hand.rightMiddleMiddleTip;
                else if (part == FingerPart.Tip) return hand.rightMiddleTip;
            }
            else if (finger == FingerName.Ring)
            {
                if (part == FingerPart.Start) return hand.rightRingStart;
                else if (part == FingerPart.MiddleStart) return hand.rightRingMiddleStart;
                else if (part == FingerPart.MiddleTip) return hand.rightRingMiddleTip;
                else if (part == FingerPart.Tip) return hand.rightRingTip;
            }
            else if (finger == FingerName.Pinky)
            {
                if (part == FingerPart.Start) return hand.rightPinkyStart;
                else if (part == FingerPart.MiddleStart) return hand.rightPinkyMiddleStart;
                else if (part == FingerPart.MiddleTip) return hand.rightPinkyMiddleTip;
                else if (part == FingerPart.Tip) return hand.rightPinkyTip;
            }
        }

        throw new Exception("Enum not managed");
    }

    public static void SetInfoOfHand<T>(in TrackedHandsInfo<T> hand, in T info
        , in HandType handType, in FingerName finger, in FingerPart part)
    {

        if (handType == HandType.Left)
        {
            if (finger == FingerName.Thumb)
            {
                if (part == FingerPart.Start) hand.leftThumbStart = info;
                else if (part == FingerPart.MiddleStart) hand.leftThumbMiddleStart = info;
                else if (part == FingerPart.MiddleTip) hand.leftThumbMiddleTip = info;
                else if (part == FingerPart.Tip) hand.leftThumbTip = info;
            }
            else if (finger == FingerName.Index)
            {
                if (part == FingerPart.Start) hand.leftIndexStart = info;
                else if (part == FingerPart.MiddleStart) hand.leftIndexMiddleStart = info;
                else if (part == FingerPart.MiddleTip) hand.leftIndexMiddleTip = info;
                else if (part == FingerPart.Tip) hand.leftIndexTip = info;
            }
            else if (finger == FingerName.Middle)
            {
                if (part == FingerPart.Start) hand.leftMiddleStart = info;
                else if (part == FingerPart.MiddleStart) hand.leftMiddleMiddleStart = info;
                else if (part == FingerPart.MiddleTip) hand.leftMiddleMiddleTip = info;
                else if (part == FingerPart.Tip) hand.leftMiddleTip = info;
            }
            else if (finger == FingerName.Ring)
            {
                if (part == FingerPart.Start) hand.leftRingStart = info;
                else if (part == FingerPart.MiddleStart) hand.leftRingMiddleStart = info;
                else if (part == FingerPart.MiddleTip) hand.leftRingMiddleTip = info;
                else if (part == FingerPart.Tip) hand.leftRingTip = info;
            }
            else if (finger == FingerName.Pinky)
            {
                if (part == FingerPart.Start) hand.leftPinkyStart = info;
                else if (part == FingerPart.MiddleStart) hand.leftPinkyMiddleStart = info;
                else if (part == FingerPart.MiddleTip) hand.leftPinkyMiddleTip = info;
                else if (part == FingerPart.Tip) hand.leftPinkyTip = info;
            }
        }
        else
        {
            if (finger == FingerName.Thumb)
            {
                if (part == FingerPart.Start) hand.rightThumbStart = info;
                else if (part == FingerPart.MiddleStart) hand.rightThumbMiddleStart = info;
                else if (part == FingerPart.MiddleTip) hand.rightThumbMiddleTip = info;
                else if (part == FingerPart.Tip) hand.rightThumbTip = info;
            }
            else if (finger == FingerName.Index)
            {
                if (part == FingerPart.Start) hand.rightIndexStart = info;
                else if (part == FingerPart.MiddleStart) hand.rightIndexMiddleStart = info;
                else if (part == FingerPart.MiddleTip) hand.rightIndexMiddleTip = info;
                else if (part == FingerPart.Tip) hand.rightIndexTip = info;
            }
            else if (finger == FingerName.Middle)
            {
                if (part == FingerPart.Start) hand.rightMiddleStart = info;
                else if (part == FingerPart.MiddleStart) hand.rightMiddleMiddleStart = info;
                else if (part == FingerPart.MiddleTip) hand.rightMiddleMiddleTip = info;
                else if (part == FingerPart.Tip) hand.rightMiddleTip = info;
            }
            else if (finger == FingerName.Ring)
            {
                if (part == FingerPart.Start) hand.rightRingStart = info;
                else if (part == FingerPart.MiddleStart) hand.rightRingMiddleStart = info;
                else if (part == FingerPart.MiddleTip) hand.rightRingMiddleTip = info;
                else if (part == FingerPart.Tip) hand.rightRingTip = info;
            }
            else if (finger == FingerName.Pinky)
            {
                if (part == FingerPart.Start) hand.rightPinkyStart = info;
                else if (part == FingerPart.MiddleStart) hand.rightPinkyMiddleStart = info;
                else if (part == FingerPart.MiddleTip) hand.rightPinkyMiddleTip = info;
                else if (part == FingerPart.Tip) hand.rightPinkyTip = info;
            }
        }

        throw new Exception("Enum not managed");
    }



    public static T GetInfoOfHand<T>(in TrackedHandInfo<T> hand
        , in FingerName finger, in FingerPart part)
    {

        if (finger == FingerName.Thumb)
        {
            if (part == FingerPart.Start) return hand.thumbStart;
            else if (part == FingerPart.MiddleStart) return hand.thumbMiddleStart;
            else if (part == FingerPart.MiddleTip) return hand.thumbMiddleTip;
            else if (part == FingerPart.Tip) return hand.thumbTip;
        }
        else if (finger == FingerName.Index)
        {
            if (part == FingerPart.Start) return hand.indexStart;
            else if (part == FingerPart.MiddleStart) return hand.indexMiddleStart;
            else if (part == FingerPart.MiddleTip) return hand.indexMiddleTip;
            else if (part == FingerPart.Tip) return hand.indexTip;
        }
        else if (finger == FingerName.Middle)
        {
            if (part == FingerPart.Start) return hand.middleStart;
            else if (part == FingerPart.MiddleStart) return hand.middleMiddleStart;
            else if (part == FingerPart.MiddleTip) return hand.middleMiddleTip;
            else if (part == FingerPart.Tip) return hand.middleTip;
        }
        else if (finger == FingerName.Ring)
        {
            if (part == FingerPart.Start) return hand.ringStart;
            else if (part == FingerPart.MiddleStart) return hand.ringMiddleStart;
            else if (part == FingerPart.MiddleTip) return hand.ringMiddleTip;
            else if (part == FingerPart.Tip) return hand.ringTip;
        }
        else if (finger == FingerName.Pinky)
        {
            if (part == FingerPart.Start) return hand.pinkyStart;
            else if (part == FingerPart.MiddleStart) return hand.pinkyMiddleStart;
            else if (part == FingerPart.MiddleTip) return hand.pinkyMiddleTip;
            else if (part == FingerPart.Tip) return hand.pinkyTip;
        }


        throw new Exception("Enum not managed");
    }

    public static void SetInfoOfHand<T>(in TrackedHandInfo<T> hand, in T info
        , in FingerName finger, in FingerPart part)
    {
        if (finger == FingerName.Thumb)
        {
            if (part == FingerPart.Start) hand.thumbStart = info;
            else if (part == FingerPart.MiddleStart) hand.thumbMiddleStart = info;
            else if (part == FingerPart.MiddleTip) hand.thumbMiddleTip = info;
            else if (part == FingerPart.Tip) hand.thumbTip = info;
        }
        else if (finger == FingerName.Index)
        {
            if (part == FingerPart.Start) hand.indexStart = info;
            else if (part == FingerPart.MiddleStart) hand.indexMiddleStart = info;
            else if (part == FingerPart.MiddleTip) hand.indexMiddleTip = info;
            else if (part == FingerPart.Tip) hand.indexTip = info;
        }
        else if (finger == FingerName.Middle)
        {
            if (part == FingerPart.Start) hand.middleStart = info;
            else if (part == FingerPart.MiddleStart) hand.middleMiddleStart = info;
            else if (part == FingerPart.MiddleTip) hand.middleMiddleTip = info;
            else if (part == FingerPart.Tip) hand.middleTip = info;
        }
        else if (finger == FingerName.Ring)
        {
            if (part == FingerPart.Start) hand.ringStart = info;
            else if (part == FingerPart.MiddleStart) hand.ringMiddleStart = info;
            else if (part == FingerPart.MiddleTip) hand.ringMiddleTip = info;
            else if (part == FingerPart.Tip) hand.ringTip = info;
        }
        else if (finger == FingerName.Pinky)
        {
            if (part == FingerPart.Start) hand.pinkyStart = info;
            else if (part == FingerPart.MiddleStart) hand.pinkyMiddleStart = info;
            else if (part == FingerPart.MiddleTip) hand.pinkyMiddleTip = info;
            else if (part == FingerPart.Tip) hand.pinkyTip = info;
        }

        throw new Exception("Enum not managed");
    }



    public static Vector3 GetInfoOfBodyPosition(in AbstractBodyInput source, in BodyAnchor anchor)
    {
        switch (anchor)
        {
            case BodyAnchor.Nose:   return source.BodyPointWorldSpace.Nose.ReadValue<Vector3>() ;
            case BodyAnchor.UpperNeck:   return source.BodyPointWorldSpace.UpperNeck .ReadValue<Vector3>() ;
            case BodyAnchor.LowerNeck:   return source.BodyPointWorldSpace.LowerNeck .ReadValue<Vector3>() ;
            case BodyAnchor.SpineChestUp:   return source.BodyPointWorldSpace.SpineChestUp .ReadValue<Vector3>() ;
            case BodyAnchor.SpineNavalMiddle:   return source.BodyPointWorldSpace.SpineNavalMiddle .ReadValue<Vector3>() ;
            case BodyAnchor.SpinePelvisDown:   return source.BodyPointWorldSpace.SpinePelvisDown .ReadValue<Vector3>() ;
            case BodyAnchor.LeftEye:   return source.BodyPointWorldSpace.EyeLeft .ReadValue<Vector3>() ;
            case BodyAnchor.LeftEar:   return source.BodyPointWorldSpace.EarLeft .ReadValue<Vector3>() ;
            case BodyAnchor.LeftClavicle:   return source.BodyPointWorldSpace.ClavicleLeft.ReadValue<Vector3>() ;
            case BodyAnchor.LeftShoulder:   return source.BodyPointWorldSpace.ShoulderLeft .ReadValue<Vector3>() ;
            case BodyAnchor.LeftElbow:      return source.BodyPointWorldSpace.ElbowLeft.ReadValue<Vector3>() ;
            case BodyAnchor.LeftWrist:      return source.BodyPointWorldSpace.WristLeft.ReadValue<Vector3>() ;
            case BodyAnchor.LeftHand:       return source.BodyPointWorldSpace.HandLeft.ReadValue<Vector3>() ;
            case BodyAnchor.LeftHandThumb:  return source.BodyPointWorldSpace.HandThumbLeft.ReadValue<Vector3>() ;
            case BodyAnchor.LeftHandTip:    return source.BodyPointWorldSpace.HandTipLeft.ReadValue<Vector3>() ;
            case BodyAnchor.LeftHip:        return source.BodyPointWorldSpace.HipLeft.ReadValue<Vector3>() ;
            case BodyAnchor.LeftKnee:       return source.BodyPointWorldSpace.KneeLeft.ReadValue<Vector3>() ;
            case BodyAnchor.LeftAnkle:      return source.BodyPointWorldSpace.AnkleLeft.ReadValue<Vector3>() ;
            case BodyAnchor.LeftFoot:       return source.BodyPointWorldSpace.FootLeft .ReadValue<Vector3>() ;
            case BodyAnchor.RightEye:       return source.BodyPointWorldSpace.EyeRight.ReadValue<Vector3>() ;
            case BodyAnchor.RightEar:       return source.BodyPointWorldSpace.EarRight .ReadValue<Vector3>() ;
            case BodyAnchor.RightClavicle:  return source.BodyPointWorldSpace.ClavicleRight .ReadValue<Vector3>() ;
            case BodyAnchor.RightShoulder:  return source.BodyPointWorldSpace.ShoulderRight .ReadValue<Vector3>() ;
            case BodyAnchor.RightElbow:     return source.BodyPointWorldSpace.ElbowRight .ReadValue<Vector3>() ;
            case BodyAnchor.RightWrist:     return source.BodyPointWorldSpace.WristRight .ReadValue<Vector3>() ;
            case BodyAnchor.RightHand:      return source.BodyPointWorldSpace.HandRight .ReadValue<Vector3>() ;
            case BodyAnchor.RightHandThumb: return source.BodyPointWorldSpace.HandThumbRight .ReadValue<Vector3>() ;
            case BodyAnchor.RightHandTip:   return source.BodyPointWorldSpace.HandTipRight .ReadValue<Vector3>() ;
            case BodyAnchor.RightHip:       return source.BodyPointWorldSpace.HipRight .ReadValue<Vector3>() ;
            case BodyAnchor.RightKnee:      return source.BodyPointWorldSpace.KneeRight .ReadValue<Vector3>() ;
            case BodyAnchor.RightAnkle:     return source.BodyPointWorldSpace.AnkleRight .ReadValue<Vector3>() ;
            case BodyAnchor.RightFoot:      return source.BodyPointWorldSpace.FootRight .ReadValue<Vector3>() ;

            default: break;

        }
        return Vector3.zero;
    }


    public static Vector3 GetWorldPosition(in AbstractBodyInput source, in HandType handType, in FingerName finger, in FingerPart part)
    {

        if (handType == HandType.Left)
        {

            var hand = source.LeftHandWorldSpace;
            if (finger == FingerName.Thumb)
            {
                if (part == FingerPart.Start) return hand.ThumbStart.ReadValue<Vector3>();
                else if (part == FingerPart.Tip) return hand.ThumbTip.ReadValue<Vector3>();
            }
            else if (finger == FingerName.Index)
            {
                if (part == FingerPart.Start) return hand.IndexStart.ReadValue<Vector3>();
                else if (part == FingerPart.Tip) return hand.IndexTip.ReadValue<Vector3>();
            }
            else if (finger == FingerName.Middle)
            {
                if (part == FingerPart.Start) return hand.MiddleStart.ReadValue<Vector3>();
                else if (part == FingerPart.Tip) return hand.MiddleTip.ReadValue<Vector3>();
            }
            else if (finger == FingerName.Ring)
            {
                if (part == FingerPart.Start) return hand.RingStart.ReadValue<Vector3>();
                else if (part == FingerPart.Tip) return hand.RingTip.ReadValue<Vector3>();
            }
            else if (finger == FingerName.Pinky)
            {
                if (part == FingerPart.Start) return hand.PinkyStart.ReadValue<Vector3>();
                else if (part == FingerPart.Tip) return hand.PinkyTip.ReadValue<Vector3>();
            }
        }
        else
        {
            var hand = source.RightHandWorldSpace;
            if (finger == FingerName.Thumb)
            {
                if (part == FingerPart.Start) return hand.ThumbStart.ReadValue<Vector3>();
                else if (part == FingerPart.Tip) return hand.ThumbTip.ReadValue<Vector3>();
            }
            else if (finger == FingerName.Index)
            {
                if (part == FingerPart.Start) return hand.IndexStart.ReadValue<Vector3>();
                else if (part == FingerPart.Tip) return hand.IndexTip.ReadValue<Vector3>();
            }
            else if (finger == FingerName.Middle)
            {
                if (part == FingerPart.Start) return hand.MiddleStart.ReadValue<Vector3>();
                else if (part == FingerPart.Tip) return hand.MiddleTip.ReadValue<Vector3>();
            }
            else if (finger == FingerName.Ring)
            {
                if (part == FingerPart.Start) return hand.RingStart.ReadValue<Vector3>();
                else if (part == FingerPart.Tip) return hand.RingTip.ReadValue<Vector3>();
            }
            else if (finger == FingerName.Pinky)
            {
                if (part == FingerPart.Start) return hand.PinkyStart.ReadValue<Vector3>();
                else if (part == FingerPart.Tip) return hand.PinkyTip.ReadValue<Vector3>();
            }
        }

        return Vector3.zero;

    }
    public static void AddListenerToUpdateCallback(Action<InputAction.CallbackContext> callback, in AbstractBodyInput source, in HandType handType, in FingerName finger, in FingerPart part)
    {

        if (handType == HandType.Left)
        {

            var hand = source.LeftHandWorldSpace;
            if (finger == FingerName.Thumb)
            {
                if (part == FingerPart.Start) hand.ThumbStart.performed += callback;
                else if (part == FingerPart.Tip) hand.ThumbTip.performed += callback;
            }
            else if (finger == FingerName.Index)
            {
                if (part == FingerPart.Start) hand.IndexStart.performed += callback;
                else if (part == FingerPart.Tip) hand.IndexTip.performed += callback;
            }
            else if (finger == FingerName.Middle)
            {
                if (part == FingerPart.Start) hand.MiddleStart.performed += callback;
                else if (part == FingerPart.Tip) hand.MiddleTip.performed += callback;
            }
            else if (finger == FingerName.Ring)
            {
                if (part == FingerPart.Start) hand.RingStart.performed += callback;
                else if (part == FingerPart.Tip) hand.RingTip.performed += callback;
            }
            else if (finger == FingerName.Pinky)
            {
                if (part == FingerPart.Start) hand.PinkyStart.performed += callback;
                else if (part == FingerPart.Tip) hand.PinkyTip.performed += callback;
            }
        }
        else
        {
            var hand = source.RightHandWorldSpace;
            if (finger == FingerName.Thumb)
            {
                if (part == FingerPart.Start) hand.ThumbStart.performed += callback;
                else if (part == FingerPart.Tip) hand.ThumbTip.performed += callback;
            }
            else if (finger == FingerName.Index)
            {
                if (part == FingerPart.Start) hand.IndexStart.performed += callback;
                else if (part == FingerPart.Tip) hand.IndexTip.performed += callback;
            }
            else if (finger == FingerName.Middle)
            {
                if (part == FingerPart.Start) hand.MiddleStart.performed += callback;
                else if (part == FingerPart.Tip) hand.MiddleTip.performed += callback;
            }
            else if (finger == FingerName.Ring)
            {
                if (part == FingerPart.Start) hand.RingStart.performed += callback;
                else if (part == FingerPart.Tip) hand.RingTip.performed += callback;
            }
            else if (finger == FingerName.Pinky)
            {
                if (part == FingerPart.Start) hand.PinkyStart.performed += callback;
                else if (part == FingerPart.Tip) hand.PinkyTip.performed += callback;
            }
        }


    }



    public static void AddListenerToStartCallback(Action<InputAction.CallbackContext> callback, in AbstractBodyInput source, in HandType handType, in FingerName finger, in FingerPart part)
    {

        if (handType == HandType.Left)
        {

            var hand = source.LeftHandWorldSpace;
            if (finger == FingerName.Thumb)
            {
                if (part == FingerPart.Start) hand.ThumbStart.canceled += callback;
                else if (part == FingerPart.Tip) hand.ThumbTip.canceled += callback;
            }
            else if (finger == FingerName.Index)
            {
                if (part == FingerPart.Start) hand.IndexStart.canceled += callback;
                else if (part == FingerPart.Tip) hand.IndexTip.canceled += callback;
            }
            else if (finger == FingerName.Middle)
            {
                if (part == FingerPart.Start) hand.MiddleStart.canceled += callback;
                else if (part == FingerPart.Tip) hand.MiddleTip.canceled += callback;
            }
            else if (finger == FingerName.Ring)
            {
                if (part == FingerPart.Start) hand.RingStart.canceled += callback;
                else if (part == FingerPart.Tip) hand.RingTip.canceled += callback;
            }
            else if (finger == FingerName.Pinky)
            {
                if (part == FingerPart.Start) hand.PinkyStart.canceled += callback;
                else if (part == FingerPart.Tip) hand.PinkyTip.canceled += callback;
            }
        }
        else
        {
            var hand = source.RightHandWorldSpace;
            if (finger == FingerName.Thumb)
            {
                if (part == FingerPart.Start) hand.ThumbStart.canceled += callback;
                else if (part == FingerPart.Tip) hand.ThumbTip.canceled += callback;
            }
            else if (finger == FingerName.Index)
            {
                if (part == FingerPart.Start) hand.IndexStart.canceled += callback;
                else if (part == FingerPart.Tip) hand.IndexTip.canceled += callback;
            }
            else if (finger == FingerName.Middle)
            {
                if (part == FingerPart.Start) hand.MiddleStart.canceled += callback;
                else if (part == FingerPart.Tip) hand.MiddleTip.canceled += callback;
            }
            else if (finger == FingerName.Ring)
            {
                if (part == FingerPart.Start) hand.RingStart.canceled += callback;
                else if (part == FingerPart.Tip) hand.RingTip.canceled += callback;
            }
            else if (finger == FingerName.Pinky)
            {
                if (part == FingerPart.Start) hand.PinkyStart.canceled += callback;
                else if (part == FingerPart.Tip) hand.PinkyTip.canceled += callback;
            }
        }


    }

    public static void SetWorldPosition(in Vector3 position, in AbstractBodyInput source, in HandType handType, in FingerName finger, in FingerPart part)
    {

        throw new System.NotImplementedException();


    }
}