using JetBrains.Annotations;

#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine;
#endif

namespace NiGames.Extensions
{
    [PublicAPI]
    public static class InputExtensions
    {
#if ENABLE_INPUT_SYSTEM
        /// <summary>
        /// Returns the InputSystem key that corresponds to a given KeyCode.
        /// </summary>
        /// <param name="keyCode">The KeyCode to convert to an InputSystem key.</param>
        /// <returns>The InputSystem key that corresponds to the given KeyCode, or None if no corresponding key was found.</returns>
        public static Key ToInputSystemKey(this KeyCode keyCode)
        {
            if (Keyboard.current == null) return Key.None;
            
            var keyControl = Keyboard.current[keyCode.ToString()] as KeyControl;
            
            return keyControl == null ? Key.None : keyControl.keyCode;
        }
#endif
    }
}