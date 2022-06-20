using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class PushFakeBodyInputTransformMono : MonoBehaviour
{

    public FakeTrackedBodyDeviceState m_fakeBody;
    private FakeTrackedBodyDevice m_device;
    public TrackedBodyInfoTransform m_toPush;

    public void LateUpdate()
    {
        PushInfo();
    }

    private void PushInfo()
    {
        //if (m_pushType == PushType.ByQueueStateEvent)
        
            //if (m_deviceLeft == null)
            {
                m_device = FakeTrackedBodyDevice.GetBodyDevice();
            }

            m_fakeBody.nose = GetOrZero(AbstractBodyInputUtility.BodyAnchor.Nose);
            m_fakeBody.upperNeck = GetOrZero(AbstractBodyInputUtility.BodyAnchor.UpperNeck);
            m_fakeBody.lowerNeck = GetOrZero(AbstractBodyInputUtility.BodyAnchor.LowerNeck);
            m_fakeBody.spineChestUp = GetOrZero(AbstractBodyInputUtility.BodyAnchor.SpineChestUp);
            m_fakeBody.spineNavalMiddle = GetOrZero(AbstractBodyInputUtility.BodyAnchor.SpineNavalMiddle);
            m_fakeBody.spinePelvisDown = GetOrZero(AbstractBodyInputUtility.BodyAnchor.SpinePelvisDown);
            m_fakeBody.leftEye = GetOrZero(AbstractBodyInputUtility.BodyAnchor.LeftEye);
            m_fakeBody.leftEar = GetOrZero(AbstractBodyInputUtility.BodyAnchor.LeftEar);
            m_fakeBody.leftClavicle = GetOrZero(AbstractBodyInputUtility.BodyAnchor.LeftClavicle);
            m_fakeBody.leftShoulder = GetOrZero(AbstractBodyInputUtility.BodyAnchor.LeftShoulder);
            m_fakeBody.leftElbow = GetOrZero(AbstractBodyInputUtility.BodyAnchor.LeftElbow);
            m_fakeBody.leftWrist = GetOrZero(AbstractBodyInputUtility.BodyAnchor.LeftWrist);
            m_fakeBody.leftHand = GetOrZero(AbstractBodyInputUtility.BodyAnchor.LeftHand);
            m_fakeBody.leftHandThumb = GetOrZero(AbstractBodyInputUtility.BodyAnchor.LeftHandThumb);
            m_fakeBody.leftHandTip = GetOrZero(AbstractBodyInputUtility.BodyAnchor.LeftHandTip);
            m_fakeBody.leftHip = GetOrZero(AbstractBodyInputUtility.BodyAnchor.LeftHip);
            m_fakeBody.leftKnee = GetOrZero(AbstractBodyInputUtility.BodyAnchor.LeftKnee);
            m_fakeBody.leftAnkle = GetOrZero(AbstractBodyInputUtility.BodyAnchor.LeftAnkle);
            m_fakeBody.leftFoot = GetOrZero(AbstractBodyInputUtility.BodyAnchor.LeftFoot);
            m_fakeBody.rightEye = GetOrZero(AbstractBodyInputUtility.BodyAnchor.RightEye);
            m_fakeBody.rightEar = GetOrZero(AbstractBodyInputUtility.BodyAnchor.RightEar);
            m_fakeBody.rightClavicle = GetOrZero(AbstractBodyInputUtility.BodyAnchor.RightClavicle);
            m_fakeBody.rightShoulder = GetOrZero(AbstractBodyInputUtility.BodyAnchor.RightShoulder);
            m_fakeBody.rightElbow = GetOrZero(AbstractBodyInputUtility.BodyAnchor.RightElbow);
            m_fakeBody.rightWrist = GetOrZero(AbstractBodyInputUtility.BodyAnchor.RightWrist);
            m_fakeBody.rightHand = GetOrZero(AbstractBodyInputUtility.BodyAnchor.RightHand);
            m_fakeBody.rightHandThumb = GetOrZero(AbstractBodyInputUtility.BodyAnchor.RightHandThumb);
            m_fakeBody.rightHandTip = GetOrZero(AbstractBodyInputUtility.BodyAnchor.RightHandTip);
            m_fakeBody.rightHip = GetOrZero(AbstractBodyInputUtility.BodyAnchor.RightHip);
            m_fakeBody.rightKnee = GetOrZero(AbstractBodyInputUtility.BodyAnchor.RightKnee);
            m_fakeBody.rightAnkle = GetOrZero(AbstractBodyInputUtility.BodyAnchor.RightAnkle);
            m_fakeBody.rightFoot = GetOrZero(AbstractBodyInputUtility.BodyAnchor.RightFoot);
        InputSystem.QueueStateEvent(m_device, m_fakeBody, -1);
       

    }

    private Vector3 GetOrZero(AbstractBodyInputUtility.BodyAnchor anchor)
    {
        Transform t = m_toPush.GetInfoOfBody(anchor);
        if (t == null)
            return Vector3.zero;
       return t.position;
    }
}
