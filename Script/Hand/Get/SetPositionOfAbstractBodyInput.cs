using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SetPositionOfAbstractBodyInput : MonoBehaviour
{

    public AbstractBodyInput m_abstractInputSource;
    public AbstractBodyInputUtility.HandType m_handType;
    public AbstractBodyInputUtility.FingerName m_fingerName;
    public AbstractBodyInputUtility.FingerPart m_fingerAnchor;
    public Transform m_targetToAffect;


    private void Start()
    {
        m_abstractInputSource = new AbstractBodyInput();
        m_abstractInputSource.Enable();
        AbstractBodyInputUtility.AddListenerToStartCallback(DoOnChange, in m_abstractInputSource, in m_handType, in m_fingerName, in m_fingerAnchor);
        AbstractBodyInputUtility.AddListenerToUpdateCallback(DoOnChange, in m_abstractInputSource, in m_handType, in m_fingerName, in m_fingerAnchor);
    }

    private void OnDisable()
    {
        m_abstractInputSource.Disable();
        m_abstractInputSource.Dispose();
    }



    private void DoOnChange(InputAction.CallbackContext obj)
    {
        Vector3 position = obj.ReadValue<Vector3>();
        bool isDefined = position != Vector3.zero;
        if (isDefined && m_targetToAffect)
            m_targetToAffect.position = position;
        if(m_targetToAffect && m_targetToAffect.gameObject)
        m_targetToAffect.gameObject.SetActive(isDefined);
    }

    public void Reset()
    {
        m_targetToAffect = GetComponent<Transform>();
    }
}

