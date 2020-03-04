﻿using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.UI;
using UnityEngine.Video;

public class ARUXAnimationManager : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Instructional test for visual UI")]
    TMP_Text m_InstructionText;
    
    /// <summary>
    /// Get the <c>Instructional Text</c>
    /// </summary>
    public TMP_Text instructionText => m_InstructionText;
    
    [SerializeField]
    [Tooltip("Move device animation")]
    VideoClip m_FindAPlaneClip;

    /// <summary>
    /// Get the <c>Move device Clip</c>
    /// </summary>
    public VideoClip findAPlaneClip => m_FindAPlaneClip;

    [SerializeField]
    [Tooltip("Tap to place animation")]
    VideoClip m_TapToPlaceClip;
    
    /// <summary>
    /// Get the <c>Tap to place Clip</c>
    /// </summary>
    public VideoClip tapToPlaceClip => m_TapToPlaceClip;

    [SerializeField]
    [Tooltip("Find Clip animation")]
    VideoClip m_FindImageClip;
    
    /// <summary>
    /// Get the <c>Find Image Clip</c>
    /// </summary>
    public VideoClip findImageClip => m_FindImageClip;

    [SerializeField]
    [Tooltip("Find body animation")]
    VideoClip m_FindBodyClip;
    
    /// <summary>
    /// Get the <c>Find body Clip</c>
    /// </summary>
    public VideoClip findBodyClip => m_FindBodyClip;

    [SerializeField]
    [Tooltip("Find object animation")]
    VideoClip m_FindObjectClip;
    
    /// <summary>
    /// Get the <c>Find object Clip</c>
    /// </summary>
    public VideoClip findObjectClip => m_FindObjectClip;

    [SerializeField]
    [Tooltip("Find face animation")]
    VideoClip m_FindFaceClip;
    
    /// <summary>
    /// Get the <c>Find face iamge</c>
    /// </summary>
    public VideoClip findFaceClip => m_FindFaceClip;

    [SerializeField]
    [Tooltip("ARKit Coaching overlay reference")]
    ARKitCoachingOverlay m_CoachingOverlay;

    /// <summary>
    /// Get the <c>ARKit coaching overlay</c>
    /// </summary>
    public ARKitCoachingOverlay coachingOverlay => m_CoachingOverlay;

    [SerializeField]
    [Tooltip("Video player reference")]
    VideoPlayer m_VideoPlayer;
    
    public VideoPlayer videoPlayer => m_VideoPlayer;

    [SerializeField]
    [Tooltip("Raw image used for videoplayer reference")]
    RawImage m_RawImage;

    public RawImage rawImage => m_RawImage;
    
    [SerializeField]
    [Tooltip("time the UI takes to fade on")]
    float m_FadeOnDuration = 1.0f;
    [SerializeField]
    [Tooltip("time the UI takes to fade off")]
    float m_FadeOffDuration = 0.5f;
    
    Color m_AlphaWhite = new Color(1,1,1,0);
    Color m_White = new Color(1,1,1,1);

    Color m_TargetColor;
    Color m_StartColor;
    Color m_LerpingColor;
    bool m_FadeOn;
    bool m_FadeOff;
    bool m_Tweening;
    bool m_UsingARKitCoaching;
    float m_TweenTime;
    float m_TweenDuration;

    const string k_MoveDeviceText = "Move device slowly";
    const string k_TapToPlaceText = "Tap to place AR";
    const string k_FindABodyText = "Find a body to track";
    const string k_FindAFaceText = "Find a face to track";
    const string k_FindClipText = "Find an image to track";
    const string k_FindObjectText = "Find an object to track";

    public static event Action onFadeOffComplete;

    [SerializeField]
    Texture m_Transparent;

    RenderTexture m_RenderTexture;

    void Start()
    {
        m_StartColor = m_AlphaWhite;
        m_TargetColor = m_White;
    }

    void Update()
    {
        if (!m_VideoPlayer.isPrepared)
        {
            return;
        }
        
        if (m_FadeOff || m_FadeOn)
        {
            if (m_FadeOn)
            {
                m_StartColor = m_AlphaWhite;
                m_TargetColor = m_White;
                m_TweenDuration = m_FadeOnDuration;

                m_FadeOff = false;
            }
        
            if(m_FadeOff)
            {
                m_StartColor = m_White;
                m_TargetColor = m_AlphaWhite;
                m_TweenDuration = m_FadeOffDuration;

                m_FadeOn = false;
            }
            
            if (m_TweenTime < 1)
            {
                m_TweenTime += Time.deltaTime / m_TweenDuration;
                m_LerpingColor = Color.Lerp(m_StartColor, m_TargetColor, m_TweenTime);
                m_RawImage.color = m_LerpingColor;
                m_InstructionText.color = m_LerpingColor;
                
                m_Tweening = true;
            }
            else
            {
                m_TweenTime = 0;
                m_FadeOff = false;
                m_FadeOn = false;
                m_Tweening = false;
 
                // was it a fade off?
                if (m_TargetColor == m_AlphaWhite)
                {
                    if (onFadeOffComplete != null)
                    {
                        onFadeOffComplete();
                    }

                    // fix issue with render texture showing a single frame of the previous video
                    m_RenderTexture = m_VideoPlayer.targetTexture;
                    m_RenderTexture.DiscardContents();
                    m_RenderTexture.Release();
                    Graphics.Blit(m_Transparent, m_RenderTexture);
                }
            }
        }
    }
    
    public void ShowTapToPlace()
    {
        m_VideoPlayer.clip = m_TapToPlaceClip;
        m_InstructionText.text = k_TapToPlaceText;
        m_FadeOn = true;
    }

    public void ShowFindImage()
    {
        m_VideoPlayer.clip = m_FindImageClip;
        m_InstructionText.text = k_FindClipText;
        m_FadeOn = true;
    }

    public void ShowFindBody()
    {
        m_VideoPlayer.clip = m_FindBodyClip;
        m_InstructionText.text = k_FindABodyText;
        m_FadeOn = true;
        
    }

    public void ShowFindObject()
    {
        m_VideoPlayer.clip = m_FindObjectClip;
        m_InstructionText.text = k_FindObjectText;
        m_FadeOn = true;
    }

    public void ShowFindFace()
    {
        m_VideoPlayer.clip = m_FindFaceClip;
        m_InstructionText.text = k_FindAFaceText;
        m_FadeOn = true;
    }

    public void ShowCrossPlatformFindAPlane()
    {
        m_VideoPlayer.clip = m_FindAPlaneClip;
        m_InstructionText.text = k_MoveDeviceText;
        m_FadeOn = true;
    }

    public void ShowCoachingOverlay()
    {
        if (m_CoachingOverlay)
        {
            if (m_CoachingOverlay.supported)
            {
                m_CoachingOverlay.ActivateCoaching(true);
                m_UsingARKitCoaching = true;
            }
            else
            {
                Debug.LogWarning("Coaching Overlay not supported on this platform");
            }
        }
    }

    public bool ARKitCoachingOverlaySupported()
    {
        if (m_CoachingOverlay)
        {
            return m_CoachingOverlay.supported;
        }

        return false;
    }
    
    public void FadeOffCurrentUI()
    {
        // assumes coaching overlay is first in the order
        if (m_UsingARKitCoaching)
        {
            // disables it instantly rather than animating it off
            m_CoachingOverlay.DisableCoaching(false);
            m_UsingARKitCoaching = false;
            m_InstructionText.color = m_AlphaWhite;
            m_FadeOff = true;
        }
        
        if (m_VideoPlayer.clip != null)
        {
            // handle exiting fade out early if currently fading out another Clip
            if (m_Tweening)
            {
                // stop tween immediately
                m_TweenTime = 1.0f;
                m_RawImage.color = m_AlphaWhite;
                m_InstructionText.color = m_AlphaWhite;
                if (onFadeOffComplete != null)
                {
                    onFadeOffComplete();
                }
            }

            m_FadeOff = true;
        }
    }
}