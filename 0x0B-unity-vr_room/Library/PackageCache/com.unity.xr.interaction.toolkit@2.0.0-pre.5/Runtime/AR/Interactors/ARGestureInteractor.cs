//-----------------------------------------------------------------------
// <copyright file="ARGestureInteractor.cs" company="Google">
//
// Copyright 2018 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// </copyright>
//-----------------------------------------------------------------------

// Modifications copyright © 2020 Unity Technologies ApS

#if !AR_FOUNDATION_PRESENT && !PACKAGE_DOCS_GENERATION

// Stub class definition used to fool version defines that this MonoScript exists (fixed in 19.3)
namespace UnityEngine.XR.Interaction.Toolkit.AR
{
    /// <summary>
    /// The <see cref="ARGestureInteractor"/> allows the user to manipulate virtual objects (select, translate,
    /// rotate, scale, and elevate) through gestures (tap, drag, twist, and pinch).
    /// </summary>
    /// <remarks>
    /// To make use of this, add an <see cref="ARGestureInteractor"/> to your scene
    /// and an <see cref="ARBaseGestureInteractable"/> to any of your virtual objects.
    /// </remarks>
    public class ARGestureInteractor {}
}

#else

using System;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor.XR.Interaction.Toolkit.Utilities;
#endif
#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem.EnhancedTouch;
#endif
using UnityEngine.XR.ARFoundation;
using Unity.XR.CoreUtils;

namespace UnityEngine.XR.Interaction.Toolkit.AR
{
    /// <summary>
    /// The <see cref="ARGestureInteractor"/> allows the user to manipulate virtual objects (select, translate,
    /// rotate, scale, and elevate) through gestures (tap, drag, twist, and pinch).
    /// </summary>
    /// <remarks>
    /// To make use of this, add an <see cref="ARGestureInteractor"/> to your scene
    /// and an <see cref="ARBaseGestureInteractable"/> to any of your virtual objects.
    /// </remarks>
    [HelpURL(XRHelpURLConstants.k_ARGestureInteractor)]
    public class ARGestureInteractor : XRBaseInteractor
    {
        [SerializeField]
        XROrigin m_XROrigin;

        /// <summary>
        /// The <see cref="XROrigin"/> that this Interactor will use
        /// (such as to get the <see cref="Camera"/> or to transform from Session space).
        /// Will find one if <see langword="null"/>.
        /// </summary>
        public XROrigin xrOrigin
        {
            get => m_XROrigin;
            set
            {
                m_XROrigin = value;
                if (Application.isPlaying)
                    PushXROrigin();
            }
        }

        [SerializeField]
        ARSessionOrigin m_ARSessionOrigin;

        /// <summary>
        /// The <a href="https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@4.1/api/UnityEngine.XR.ARFoundation.ARSessionOrigin.html">ARSessionOrigin</a>
        /// that this Interactor will use (such as to get the <see cref="Camera"/>
        /// or to transform from Session space). Will find one if <see langword="null"/>.
        /// </summary>
        [Obsolete("arSessionOrigin is marked for deprecation and will be removed in a future version. Please use xrOrigin instead.")]
        public ARSessionOrigin arSessionOrigin
        {
            get => m_ARSessionOrigin;
            set
            {
                m_ARSessionOrigin = value;
                if (Application.isPlaying)
                    PushARSessionOrigin();
            }
        }

        /// <summary>
        /// (Read Only) The Drag gesture recognizer.
        /// </summary>
        public DragGestureRecognizer dragGestureRecognizer { get; private set; }

        /// <summary>
        /// (Read Only) The Pinch gesture recognizer.
        /// </summary>
        public PinchGestureRecognizer pinchGestureRecognizer { get; private set; }

        /// <summary>
        /// (Read Only) The two-finger Drag gesture recognizer.
        /// </summary>
        public TwoFingerDragGestureRecognizer twoFingerDragGestureRecognizer { get; private set; }

        /// <summary>
        /// (Read Only) The Tap gesture recognizer.
        /// </summary>
        public TapGestureRecognizer tapGestureRecognizer { get; private set; }

        /// <summary>
        /// (Read Only) The Twist gesture recognizer.
        /// </summary>
        public TwistGestureRecognizer twistGestureRecognizer { get; private set; }

#pragma warning disable IDE1006 // Naming Styles
        static ARGestureInteractor s_Instance;
        /// <summary>
        /// (Read Only) The <see cref="ARGestureInteractor"/> instance.
        /// </summary>
        /// <remarks>
        /// <c>instance</c> has been deprecated. Use <see cref="ARBaseGestureInteractable.gestureInteractor"/> instead of singleton.
        /// </remarks>
        [Obsolete("instance has been deprecated. Use ARBaseGestureInteractable.gestureInteractor instead of singleton.")]
        public static ARGestureInteractor instance
        {
            get
            {
                if (s_Instance == null)
                {
                    s_Instance = FindObjectOfType<ARGestureInteractor>();
                    if (s_Instance == null)
                    {
                        Debug.LogError("No instance of ARGestureInteractor exists in the scene.");
                    }
                }

                return s_Instance;
            }
        }

        /// <inheritdoc cref="instance"/>
        /// <remarks>
        /// <c>Instance</c> has been deprecated. Use <see cref="instance"/> instead.
        /// </remarks>
        [Obsolete("Instance has been deprecated. Use instance instead. (UnityUpgradable) -> instance")]
        public static ARGestureInteractor Instance => instance;

        /// <inheritdoc cref="dragGestureRecognizer"/>
        /// <remarks><c>DragGestureRecognizer</c> has been deprecated. Use <see cref="dragGestureRecognizer"/> instead.</remarks>
        [Obsolete("DragGestureRecognizer has been deprecated. Use dragGestureRecognizer instead. (UnityUpgradable) -> dragGestureRecognizer")]
        public DragGestureRecognizer DragGestureRecognizer => dragGestureRecognizer;

        /// <inheritdoc cref="pinchGestureRecognizer"/>
        /// <remarks><c>PinchGestureRecognizer</c> has been deprecated. Use <see cref="pinchGestureRecognizer"/> instead.</remarks>
        [Obsolete("PinchGestureRecognizer has been deprecated. Use pinchGestureRecognizer instead. (UnityUpgradable) -> pinchGestureRecognizer")]
        public PinchGestureRecognizer PinchGestureRecognizer => pinchGestureRecognizer;

        /// <inheritdoc cref="twoFingerDragGestureRecognizer"/>
        /// <remarks><c>TwoFingerDragGestureRecognizer</c> has been deprecated. Use <see cref="twoFingerDragGestureRecognizer"/> instead.</remarks>
        [Obsolete("TwoFingerDragGestureRecognizer has been deprecated. Use twoFingerDragGestureRecognizer instead. (UnityUpgradable) -> twoFingerDragGestureRecognizer")]
        public TwoFingerDragGestureRecognizer TwoFingerDragGestureRecognizer => twoFingerDragGestureRecognizer;

        /// <inheritdoc cref="tapGestureRecognizer"/>
        /// <remarks><c>TapGestureRecognizer</c> has been deprecated. Use <see cref="tapGestureRecognizer"/> instead.</remarks>
        [Obsolete("TapGestureRecognizer has been deprecated. Use tapGestureRecognizer instead. (UnityUpgradable) -> tapGestureRecognizer")]
        public TapGestureRecognizer TapGestureRecognizer => tapGestureRecognizer;

        /// <inheritdoc cref="twistGestureRecognizer"/>
        /// <remarks><c>TwistGestureRecognizer</c> has been deprecated. Use <see cref="twistGestureRecognizer"/> instead.</remarks>
        [Obsolete("TwistGestureRecognizer has been deprecated. Use twistGestureRecognizer instead. (UnityUpgradable) -> twistGestureRecognizer")]
        public TwistGestureRecognizer TwistGestureRecognizer => twistGestureRecognizer;
#pragma warning restore IDE1006

        readonly List<IXRInteractable> m_ValidTargets = new List<IXRInteractable>();

        /// <summary>
        /// Cached reference to an <see cref="XROrigin"/> found with <see cref="Object.FindObjectOfType"/>.
        /// </summary>
        static XROrigin s_XROriginCache;

        /// <summary>
        /// Cached reference to an <see cref="ARSessionOrigin"/> found with <see cref="Object.FindObjectOfType"/>.
        /// </summary>
        static ARSessionOrigin s_ARSessionOriginCache;

        /// <summary>
        /// Temporary, reusable list of registered Interactables.
        /// </summary>
        static readonly List<IXRInteractable> s_Interactables = new List<IXRInteractable>();

        /// <inheritdoc />
        protected override void Reset()
        {
            base.Reset();
#if UNITY_EDITOR
            m_XROrigin = EditorComponentLocatorUtility.FindSceneComponentOfType<XROrigin>(gameObject);
            m_ARSessionOrigin = EditorComponentLocatorUtility.FindSceneComponentOfType<ARSessionOrigin>(gameObject);
#endif
        }

        /// <inheritdoc />
        protected override void Awake()
        {
            base.Awake();

            dragGestureRecognizer = new DragGestureRecognizer();
            pinchGestureRecognizer = new PinchGestureRecognizer();
            twoFingerDragGestureRecognizer = new TwoFingerDragGestureRecognizer();
            tapGestureRecognizer = new TapGestureRecognizer();
            twistGestureRecognizer = new TwistGestureRecognizer();

            FindXROrigin();
            PushXROrigin();

#pragma warning disable 618 // Calling deprecated method to help with backwards compatibility.
            FindARSessionOrigin();
            PushARSessionOrigin();
#pragma warning restore 618
        }

        /// <inheritdoc />
        protected override void OnEnable()
        {
            base.OnEnable();

#if ENABLE_INPUT_SYSTEM
            EnhancedTouchSupport.Enable();
#endif
            FindXROrigin();
            PushXROrigin();

#pragma warning disable 618 // Calling deprecated method to help with backwards compatibility.
            FindARSessionOrigin();
            PushARSessionOrigin();
#pragma warning restore 618
        }

        protected override void OnDisable()
        {
            base.OnDisable();

#if AR_FOUNDATION_PRESENT && ENABLE_INPUT_SYSTEM
            EnhancedTouchSupport.Disable();
#endif
        }

        /// <inheritdoc />
        public override void ProcessInteractor(XRInteractionUpdateOrder.UpdatePhase updatePhase)
        {
            base.ProcessInteractor(updatePhase);

            if (updatePhase == XRInteractionUpdateOrder.UpdatePhase.Dynamic)
                UpdateGestureRecognizers();
        }

        void FindXROrigin()
        {
            if (m_XROrigin != null)
                return;

            if (s_XROriginCache == null)
                s_XROriginCache = FindObjectOfType<XROrigin>();

            m_XROrigin = s_XROriginCache;
        }

        void FindARSessionOrigin()
        {
            if (m_ARSessionOrigin != null)
                return;

            if (s_ARSessionOriginCache == null)
                s_ARSessionOriginCache = FindObjectOfType<ARSessionOrigin>();

            m_ARSessionOrigin = s_ARSessionOriginCache;
        }

        /// <inheritdoc />
        public override void GetValidTargets(List<IXRInteractable> validTargets)
        {
            validTargets.Clear();
            validTargets.AddRange(m_ValidTargets);
        }

        /// <summary>
        /// Update all Gesture Recognizers.
        /// </summary>
        /// <seealso cref="GestureRecognizer{T}.Update"/>
        protected virtual void UpdateGestureRecognizers()
        {
            dragGestureRecognizer.Update();
            pinchGestureRecognizer.Update();
            twoFingerDragGestureRecognizer.Update();
            tapGestureRecognizer.Update();
            twistGestureRecognizer.Update();
        }

        /// <summary>
        /// Passes the <see cref="xrOrigin"/> to the Gesture Recognizers.
        /// </summary>
        /// <seealso cref="GestureRecognizer{T}.xrOrigin"/>
        protected virtual void PushXROrigin()
        {
            dragGestureRecognizer.xrOrigin = m_XROrigin;
            pinchGestureRecognizer.xrOrigin = m_XROrigin;
            twoFingerDragGestureRecognizer.xrOrigin = m_XROrigin;
            tapGestureRecognizer.xrOrigin = m_XROrigin;
            twistGestureRecognizer.xrOrigin = m_XROrigin;
        }

        /// <summary>
        /// Passes the <see cref="arSessionOrigin"/> to the Gesture Recognizers.
        /// </summary>
        /// <seealso cref="GestureRecognizer{T}.arSessionOrigin"/>
        [Obsolete("PushARSessionOrigin has been deprecated. Use PushXROrigin instead for similar functionality.")]
        protected virtual void PushARSessionOrigin()
        {
            dragGestureRecognizer.arSessionOrigin = m_ARSessionOrigin;
            pinchGestureRecognizer.arSessionOrigin = m_ARSessionOrigin;
            twoFingerDragGestureRecognizer.arSessionOrigin = m_ARSessionOrigin;
            tapGestureRecognizer.arSessionOrigin = m_ARSessionOrigin;
            twistGestureRecognizer.arSessionOrigin = m_ARSessionOrigin;
        }

        /// <inheritdoc />
        protected override void OnRegistered(InteractorRegisteredEventArgs args)
        {
            base.OnRegistered(args);
            args.manager.interactableRegistered += OnInteractableRegistered;
            args.manager.interactableUnregistered += OnInteractableUnregistered;

            // Get all of the registered gesture interactables to use as the valid targets
            m_ValidTargets.Clear();
            interactionManager.GetRegisteredInteractables(s_Interactables);
            foreach (var interactable in s_Interactables)
            {
                if (interactable is ARBaseGestureInteractable)
                    m_ValidTargets.Add(interactable);
            }

            s_Interactables.Clear();
        }

        /// <inheritdoc />
        protected override void OnUnregistered(InteractorUnregisteredEventArgs args)
        {
            base.OnUnregistered(args);
            args.manager.interactableRegistered -= OnInteractableRegistered;
            args.manager.interactableUnregistered -= OnInteractableUnregistered;
        }

        void OnInteractableRegistered(InteractableRegisteredEventArgs args)
        {
            if (args.interactableObject is ARBaseGestureInteractable)
                m_ValidTargets.Add(args.interactableObject);
        }

        void OnInteractableUnregistered(InteractableUnregisteredEventArgs args)
        {
            if (args.interactableObject is ARBaseGestureInteractable)
                m_ValidTargets.Remove(args.interactableObject);
        }
    }
}
#endif
