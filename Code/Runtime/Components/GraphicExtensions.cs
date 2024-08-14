using System.Collections;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace NiGames.Extensions
{
    [PublicAPI]
    public static class GraphicExtensions
    {
        /// <summary>
        /// Fades the color of the graphic to the specified <paramref name="targetColor"/> over the specified <paramref name="duration"/>.
        /// </summary>
        public static void FadeColorTo(this Graphic graphic, Color targetColor, float duration)
        {
            graphic.StartCoroutine(graphic.FadeColor(targetColor, duration));
        }

        /// <summary>
        /// Fades the graphic in over the specified <paramref name="duration"/>.
        /// </summary>
        public static void FadeIn(this Graphic graphic, float duration)
        {
            var color = graphic.color;
            color.a = 1f;
            
            graphic.FadeColorTo(color, duration);
        }

        /// <summary>
        /// Fades the graphic out over the specified <paramref name="duration"/>.
        /// </summary>
        public static void FadeOut(this Graphic graphic, float duration)
        {
            var color = graphic.color;
            color.a = 0f;

            graphic.FadeColorTo(color, duration);
        }

        /// <summary>
        /// Fades the color of the graphic to the specified <paramref name="targetColor"/> over the specified <paramref name="duration"/>.
        /// </summary>
        /// <returns>An enumerator for the coroutine.</returns>
        public static IEnumerator FadeColor(this Graphic graphic, Color targetColor, float duration)
        {
            var startColor = graphic.color;
            var elapsedTime = 0f;

            while (elapsedTime < duration)
            {
                var t = elapsedTime / duration;
                graphic.color = Color.Lerp(startColor, targetColor, t);
                elapsedTime += Time.unscaledDeltaTime;

                yield return null;
            }

            graphic.color = targetColor;
        }
    }
}