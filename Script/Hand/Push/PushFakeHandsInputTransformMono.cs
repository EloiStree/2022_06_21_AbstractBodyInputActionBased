using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class PushFakeHandsInputTransformMono : MonoBehaviour
{

    public FakeTrackedHandDeviceStateLeft m_fakeHandLeft;
    public FakeTrackedHandDeviceStateRight m_fakeHandRight;
    private FakeTrackedHandDeviceLeft m_deviceLeft;
    private FakeTrackedHandDeviceRight m_deviceRight;
    public TrackedHandsInfoTransform m_toPush;
    public enum PushType { ByQueueStateEvent, BySingleton}
    public PushType m_pushType;

    public void LateUpdate()
    {
        PushInfo();
    }

    private void PushInfo()
    {
        if (m_pushType == PushType.ByQueueStateEvent)
        {
            //if (m_deviceLeft == null)
            {
                m_deviceLeft = FakeTrackedHandDevice.GetLeftDevice();
            }
            //if (m_deviceRight == null)
            {
                m_deviceRight = FakeTrackedHandDevice.GetRightDevice();
            }


            if (m_toPush.leftPinkyTip)
                m_fakeHandLeft.pinkyTip = m_toPush.leftPinkyTip.position;

            if (m_toPush.leftRingTip)
                m_fakeHandLeft.ringTip = m_toPush.leftRingTip.position;

            if (m_toPush.leftMiddleTip)
                m_fakeHandLeft.middleTip = m_toPush.leftMiddleTip.position;

            if (m_toPush.leftIndexTip)
                m_fakeHandLeft.indexTip = m_toPush.leftIndexTip.position;

            if (m_toPush.leftThumbTip)
                m_fakeHandLeft.thumbTip = m_toPush.leftThumbTip.position;

            if (m_toPush.leftPinkyStart)
                m_fakeHandLeft.pinkyStart = m_toPush.leftPinkyStart.position;

            if (m_toPush.leftRingStart)
                m_fakeHandLeft.ringStart = m_toPush.leftRingStart.position;

            if (m_toPush.leftMiddleStart)
                m_fakeHandLeft.middleStart = m_toPush.leftMiddleStart.position;

            if (m_toPush.leftIndexStart)
                m_fakeHandLeft.indexStart = m_toPush.leftIndexStart.position;

            if (m_toPush.leftThumbStart)
                m_fakeHandLeft.thumbStart = m_toPush.leftThumbStart.position;

            if (m_toPush.leftWristAtThumbSide)
                m_fakeHandLeft.wristAtThumbSide = m_toPush.leftWristAtThumbSide.position;

            if (m_toPush.leftWristAtPinkySide)
                m_fakeHandLeft.wristAtPinkySide = m_toPush.leftWristAtPinkySide.position;

            if (m_toPush.leftArmAtPinkyElbowSide)
                m_fakeHandLeft.armAtPinkyElbowSide = m_toPush.leftArmAtPinkyElbowSide.position;

            if (m_toPush.leftArmAtThumbElbowSide)
                m_fakeHandLeft.armAtThumbElbowSide = m_toPush.leftArmAtThumbElbowSide.position;

            if (m_toPush.rightPinkyTip)
                m_fakeHandRight.pinkyTip = m_toPush.rightPinkyTip.position;

            if (m_toPush.rightRingTip)
                m_fakeHandRight.ringTip = m_toPush.rightRingTip.position;

            if (m_toPush.rightMiddleTip)
                m_fakeHandRight.middleTip = m_toPush.rightMiddleTip.position;

            if (m_toPush.rightIndexTip)
                m_fakeHandRight.indexTip = m_toPush.rightIndexTip.position;

            if (m_toPush.rightThumbTip)
                m_fakeHandRight.thumbTip = m_toPush.rightThumbTip.position;

            if (m_toPush.rightPinkyStart)
                m_fakeHandRight.pinkyStart = m_toPush.rightPinkyStart.position;

            if (m_toPush.rightRingStart)
                m_fakeHandRight.ringStart = m_toPush.rightRingStart.position;

            if (m_toPush.rightMiddleStart)
                m_fakeHandRight.middleStart = m_toPush.rightMiddleStart.position;

            if (m_toPush.rightIndexStart)
                m_fakeHandRight.indexStart = m_toPush.rightIndexStart.position;

            if (m_toPush.rightThumbStart)
                m_fakeHandRight.thumbStart = m_toPush.rightThumbStart.position;

            if (m_toPush.rightWristAtThumbSide)
                m_fakeHandRight.wristAtThumbSide = m_toPush.rightWristAtThumbSide.position;

            if (m_toPush.rightWristAtPinkySide)
                m_fakeHandRight.wristAtPinkySide = m_toPush.rightWristAtPinkySide.position;

            if (m_toPush.rightArmAtPinkyElbowSide)
                m_fakeHandRight.armAtPinkyElbowSide = m_toPush.rightArmAtPinkyElbowSide.position;

            if (m_toPush.rightArmAtThumbElbowSide)
                m_fakeHandRight.armAtThumbElbowSide = m_toPush.rightArmAtThumbElbowSide.position;

            InputSystem.QueueStateEvent(m_deviceLeft, m_fakeHandLeft, -1);
            InputSystem.QueueStateEvent(m_deviceRight, m_fakeHandRight, -1);
        }
        else {
            throw new System.NotImplementedException("I want to avoid the delay of Queue but I don't know how to do that. Wanted to do value access from static but not skilled enough to do that.");
            //    FakeStaticTrackedHandDeviceInstance.rightArmAtThumbElbowSide .QueueValueChange(  m_toPush.rightArmAtThumbElbowSide.position);
        }
    }
}
