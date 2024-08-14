using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace NiGames.Extensions
{
    [PublicAPI]
    public static class CameraExtensions
    {
        /// <summary>
        /// Captures a screenshot from the specified camera and returns <c>Texture2D</c>.
        /// </summary>
        public static Texture2D CaptureScreenshot(this Camera camera, int width, int height)
        {
            var rt = new RenderTexture(width, height, 24);
            var prevTargetTexture = camera.targetTexture;
            var prevRt = RenderTexture.active;
            
            camera.targetTexture = rt;
            RenderTexture.active = rt;
            
            camera.Render();
            
            var screenshot = new Texture2D(width, height, TextureFormat.RGB24, false);
            screenshot.ReadPixels(new Rect(0, 0, width, height), 0, 0);
            screenshot.Apply();
            
            camera.targetTexture = prevTargetTexture;
            RenderTexture.active = prevRt;
            
            Object.Destroy(rt);
            
            return screenshot;
        }
        
        /// <summary>
        /// Captures a screenshot from the specified camera and returns <c>Texture2D</c>. Uses the current screen resolution.
        /// </summary>
        [MethodImpl(256)]
        public static Texture2D CaptureScreenshot(this Camera camera)
        {
            return camera.CaptureScreenshot(Screen.width, Screen.height);
        }
    }
}