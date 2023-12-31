﻿using UnityEngine;

namespace Tiger.Util
{

    /// <summary>
    /// Usage:
    /// <para>   [MethodButton("MethodName1", "MethodName2", "MethodNameN")]  // Must match a the method name!</para>
    /// <para>   [SerializeField] private bool showButtons; // this bool is mandatory!</para>
    /// </summary>
    public class MethodButtonAttribute : PropertyAttribute
    {
        /// <summary>
        /// Array of different method names for which a button will be displayed.
        /// <para>"MethodOne", MethodTwo" ... "MethodN"</para>
        /// </summary>
        public string[] MethodNames { get; private set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public MethodButtonAttribute(params string[] args)
        {
            MethodNames = args;
        }
    }
}
