using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawActionBasedBodySkeletonBasicMono : MonoBehaviour
{
    public AbstractBodyInput m_bodyInput;

    public Color m_color = Color.red;

    private void Awake()
    {
        m_bodyInput = new AbstractBodyInput();
        m_bodyInput.Enable();
    }
    private void OnDisable()
    {
        m_bodyInput.Disable();
        m_bodyInput.Dispose();
    }
    public Vector3 leftEye;
    public Vector3 rightEye;
    void Update()
    {
        Debug.DrawLine(Vector3.zero, Vector3.up*5, Color.yellow, Time.deltaTime * 3);
        leftEye = AbstractBodyInputUtility.GetInfoOfBodyPosition(m_bodyInput, AbstractBodyInputUtility.BodyAnchor.LeftEye);
        rightEye = AbstractBodyInputUtility.GetInfoOfBodyPosition(m_bodyInput, AbstractBodyInputUtility.BodyAnchor.RightEye);

        DrawColor(AbstractBodyInputUtility.BodyAnchor.LeftAnkle, AbstractBodyInputUtility.BodyAnchor.RightAnkle, m_color);
        DrawColor(AbstractBodyInputUtility.BodyAnchor.LeftShoulder, AbstractBodyInputUtility.BodyAnchor.RightShoulder, m_color);
        DrawColor(AbstractBodyInputUtility.BodyAnchor.LeftEye, AbstractBodyInputUtility.BodyAnchor.RightEye, m_color);
        DrawColor(AbstractBodyInputUtility.BodyAnchor.LeftEye, AbstractBodyInputUtility.BodyAnchor.LeftEar, m_color);
        DrawColor(AbstractBodyInputUtility.BodyAnchor.RightEye, AbstractBodyInputUtility.BodyAnchor.RightEar, m_color);
        DrawColor(AbstractBodyInputUtility.BodyAnchor.LeftShoulder, AbstractBodyInputUtility.BodyAnchor.LeftWrist, m_color);
        DrawColor(AbstractBodyInputUtility.BodyAnchor.RightShoulder, AbstractBodyInputUtility.BodyAnchor.RightWrist, m_color);
    }
    public void DrawColor(AbstractBodyInputUtility.BodyAnchor from, AbstractBodyInputUtility.BodyAnchor to, Color color)
    {
        Vector3 worldPointFrom = AbstractBodyInputUtility.GetInfoOfBodyPosition(m_bodyInput,from);
        Vector3 worldPointTo = AbstractBodyInputUtility.GetInfoOfBodyPosition(m_bodyInput,to);
        Debug.DrawLine(worldPointFrom, worldPointTo, color, Time.deltaTime*3);
    }
}